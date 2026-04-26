using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_ccst
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            LoadMenu();
        }

        private void LoadMenu()
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                string query = @"SELECT name, price, image_url FROM products";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);

                // Clear out any old cards before loading
                flpProducts.Controls.Clear();

                // Loop through the database records
                foreach (System.Data.DataRow row in table.Rows)
                {
                    // 1. Create the card
                    ProductCard card = new ProductCard();

                    // 2. Assign the text data
                    card.ProductName = row["name"].ToString();
                    card.ProductPrice = row["price"].ToString();

                    // 3. Assign the image safely
                    string imagePath = row["image_url"].ToString();
                    if (System.IO.File.Exists(imagePath))
                    {
                        // 1. Open the file stream
                        using (var stream = new System.IO.FileStream(imagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            // 2. Load the image into a temporary variable
                            using (Image tempImg = Image.FromStream(stream))
                            {
                                // 3. Create a brand new standalone clone of the image in memory
                                card.ProductImage = new Bitmap(tempImg);
                            }
                        } // The stream safely closes, but our cloned Bitmap is safe!
                    }

                    // 4. Tell the program what to do when this specific card is clicked
                    card.Click += ProductCard_Click;

                    // 5. Add the card to the screen
                    flpProducts.Controls.Add(card);
                }

                adapter.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void SaveTransaction()
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                // Loop through every item ordered
                foreach (var item in lstOrders.Items)
                {
                    string itemText = item.ToString();
                    string[] parts = itemText.Split('-');

                    if (parts.Length > 1)
                    {
                        // Extract the name and price from the listbox
                        string productName = parts[0].Trim();
                        string priceText = parts[1].Replace("₱", "").Replace(",", "").Trim();

                        if (decimal.TryParse(priceText, out decimal itemPrice))
                        {
                            // UPDATED SQL: Added 'product_name' to the INSERT list, and reused '@name' in the VALUES
                            string query = @"INSERT INTO sales (product_id, product_name, quantity, amount, sale_date) 
                                     VALUES ((SELECT product_id FROM products WHERE name = @name LIMIT 1), 
                                     @name, 1, @amount, @saledate)";

                            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                            // These parameters safely fill in the @ symbols in the query above
                            cmd.Parameters.AddWithValue("@name", productName);
                            cmd.Parameters.AddWithValue("@amount", itemPrice);
                            cmd.Parameters.AddWithValue("@saledate", DateTime.Now);

                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving transaction: " + ex.Message);
            }
            finally
            {
                db.Close();
            }


        }

        private void ResetOrder()
        {
            // Clear the listbox
            lstOrders.Items.Clear();

            // Clear textboxes
            txtRaw.Text = "";
            txtDiscount.Text = "";
            txtTotal.Text = "";

            // Reset radio button to regular
            rbRegular.Checked = true;
            pnlDiscount.Enabled = false;
        }




        private void ProductCard_Click(object sender, EventArgs e)
        {
            // Safely figure out WHICH card was clicked
            ProductCard clickedCard = sender as ProductCard;

            if (clickedCard != null)
            {
                // Extract the data from that specific card
                string selectedName = clickedCard.ProductName;
                string selectedPrice = clickedCard.ProductPrice;

                // Add it directly to your ListBox
                lstOrders.Items.Add($"{selectedName} - {selectedPrice}");

                pnlDiscount.Enabled = true;

                // Calculate the new total and update the textbox
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            decimal rawAmount = 0;

            foreach (var item in lstOrders.Items)
            {
                string itemText = item.ToString();
                string[] parts = itemText.Split('-');

                if (parts.Length > 1)
                {
                    string priceText = parts[1].Replace("₱", "").Replace(",", "").Trim();

                    if (decimal.TryParse(priceText, out decimal itemPrice))
                    {
                        rawAmount += itemPrice;
                    }
                }
            }

            txtRaw.Text = $"₱ {rawAmount:0.00}";

            if (!rbSeniorCitizen.Checked && !rbPWD.Checked && !rbRegular.Checked)
            {
                txtDiscount.Text = ""; // Clear the box
                txtTotal.Text = "";    // Clear the box
                return; // This command safely exits the method early!
            }

            // 3. If the code makes it down here, it means a button IS checked. Compute the discount!
            decimal discountAmount = 0;

            if (rbSeniorCitizen.Checked)
            {
                discountAmount = rawAmount * 0.20m; // 20% discount
            }
            else if (rbPWD.Checked)
            {
                discountAmount = rawAmount * 0.15m; // 15% discount
            }
            else if (rbRegular.Checked)
            {
                discountAmount = 0; // No discount for regular customers
            }
            // If rbRegular is checked, the discount stays at 0 automatically.

            // 4. Apply the discount to get the final total
            decimal finalTotal = rawAmount - discountAmount;

            // 5. Update the textboxes with the final computed price
            txtDiscount.Text = $"₱ {discountAmount:0.00}";
            txtTotal.Text = $"₱ {finalTotal:0.00}";
        }

        private void lstOrders_DoubleClick(object sender, EventArgs e)
        {
            // 1. Check if an item is actually selected (SelectedIndex is -1 if nothing is selected)
            if (lstOrders.SelectedIndex != -1)
            {
                // 2. Remove the selected item from the ListBox
                lstOrders.Items.RemoveAt(lstOrders.SelectedIndex);

                // 3. Recalculate the total (this will automatically lower the price!)
                UpdateTotal();
            }
        }

        private void dtvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            // SAFETY CHECK 1: Is the cart empty?
            if (lstOrders.Items.Count == 0)
            {
                MessageBox.Show("Please add items to the order first!");
                return;
            }

            // Clean the total string and pass it to the Pay form
            string cleanTotal = txtTotal.Text.Replace("₱", "").Replace(",", "").Trim();


            // ==========================================
            // --- NEW RECEIPT GENERATOR START ---
            // ==========================================
            string receiptText = "====== CAFE CCST ======\n";
            receiptText += "Date: " + DateTime.Now.ToString() + "\n\n";

            // Loop through the listbox to add the items to the paper
            foreach (var item in lstOrders.Items)
            {
                receiptText += item.ToString() + "\n";
            }

            receiptText += "\n-----------------------\n";
            receiptText += "Subtotal: " + txtRaw.Text + "\n";

            // Only print the discount line if there is actually a discount!
            if (txtDiscount.Text != "₱ 0.00" && txtDiscount.Text != "")
            {
                receiptText += "Discount: " + txtDiscount.Text + "\n";
            }

            receiptText += "Total:    " + txtTotal.Text + "\n";
            // ==========================================
            // --- NEW RECEIPT GENERATOR END ---
            // ==========================================

            // Open your Pay form and hand it the cleaned total number
            Pay pay = new Pay(cleanTotal, receiptText);



            // Wait to see if the whole payment process finishes successfully...
            if (pay.ShowDialog() == DialogResult.OK)
            {
                // 1. Save all the items to the database!
                SaveTransaction();

                // 2. Wipe the screen clean for the next customer!
                ResetOrder();
            }

        }

        private void flpProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstOrders_DoubleClick_1(object sender, EventArgs e)
        {
            lstOrders_DoubleClick(sender, e);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbSeniorCitizen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSeniorCitizen_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateTotal();

        }

        private void rbRegular_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();

        }

        private void rbPWD_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            employee_dashboard employeeDashboard = new employee_dashboard();
            employeeDashboard.Show();
            this.Hide();
        }
    }
}
