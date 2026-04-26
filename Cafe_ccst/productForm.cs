using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cafe_ccst
{
    public partial class productForm : Form
    {
        public productForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void productForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            int price;
            string image = txtImage.Text.Trim();
            int categoryId;

            if (name == "" || description == "" || image == "")
            {
                MessageBox.Show("Please fill in all required fields.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCategory_ID.Text.Trim(), out categoryId))
            {
                MessageBox.Show("Please enter a valid number for the Category ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtPrice.Text.Trim(), out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = "INSERT INTO products (category_id,name, description, price, image_url) VALUES (@category_id, @name, @description, @price, @image_url)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@category_id", categoryId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@image_url", image);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCategory_ID.Clear();
                txtName.Clear();
                txtDescription.Clear();
                txtPrice.Clear();
                txtImage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategory_ID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtImage.Clear();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";
                openFileDialog.Title = "Select Product Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtImage.Text = openFileDialog.FileName;
                }
            }
        }


        private void LoadProducts()
        {
            string search = txtSearch.Text.Trim();
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"SELECT product_id, category_id, name, description, price, image_url 
                         FROM products 
                         WHERE product_id LIKE @search 
                            OR category_id LIKE @search 
                            OR name LIKE @search 
                            OR description LIKE @search 
                            OR image_url LIKE @search";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);

                // --- NEW CODE: LOAD IMAGES INTO DATATABLE ---

                // 1. Add a new column specifically for the Image object
                table.Columns.Add("ProductImage", typeof(System.Drawing.Image));

                // 2. Loop through each row to load the image from the file path
                foreach (System.Data.DataRow row in table.Rows)
                {
                    string imagePath = row["image_url"].ToString();

                    // Check if the file actually exists to prevent the app from crashing
                    if (System.IO.File.Exists(imagePath))
                    {
                        // Using a stream prevents the image file from being locked by the application
                        using (var stream = new System.IO.FileStream(imagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            row["ProductImage"] = System.Drawing.Image.FromStream(stream);
                        }
                    }
                    else
                    {
                        // If the file doesn't exist, you can leave it null or load a default "Image Not Found" picture
                        row["ProductImage"] = null;
                    }
                }

                // ---------------------------------------------

                // Bind the data to your DataGridView
                dgvProductList.DataSource = table;

                // Hide the text-based URL column so it doesn't clutter the grid
                dgvProductList.Columns["image_url"].Visible = false;

                // Rename the headers
                dgvProductList.Columns["product_id"].HeaderText = "Product";
                dgvProductList.Columns["category_id"].HeaderText = "Category";
                dgvProductList.Columns["name"].HeaderText = "Name";
                dgvProductList.Columns["description"].HeaderText = "Description";
                dgvProductList.Columns["price"].HeaderText = "Price";
                dgvProductList.Columns["ProductImage"].HeaderText = "Image"; // Header for new image column

                // --- NEW CODE: FORMATTING THE IMAGE COLUMN ---

                // Make the rows taller so you can actually see the image
                dgvProductList.RowTemplate.Height = 80;

                // Make sure the image resizes to fit inside the cell perfectly without stretching
                if (dgvProductList.Columns["ProductImage"] is DataGridViewImageColumn imageCol)
                {
                    imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                adapter.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }



        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            manager_dashboard managerDashboard = new manager_dashboard();
            managerDashboard.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProductList.CurrentRow == null || dgvProductList.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a product from the list first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Ask the user for confirmation before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return; // Stop here if they click No
            }

            // 3. Grab the ID directly from the selected row's "product_id" column
            int selectedProductId = Convert.ToInt32(dgvProductList.CurrentRow.Cells["product_id"].Value);

            // 4. Connect to the database and delete the record
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "DELETE FROM products WHERE product_id = @id";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@id", selectedProductId);

                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Dispose();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. Instantly refresh the grid so the deleted product disappears
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Delete failed. Product could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }
        }
    }
}