using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_ccst
{
    public partial class orderlist_manager : Form
    {
        public orderlist_manager()
        {
            InitializeComponent();
            LoadOrderList();
        }
        private void LoadOrderList()
        {
            string search = txtSearch.Text.Trim();

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"SELECT sale_id, product_id, product_name, quantity, amount, sale_date 
                 FROM sales 
                 WHERE sale_id LIKE @search 
                 OR product_id LIKE @search 
                 OR product_name LIKE @search 
                 OR quantity LIKE @search 
                 OR amount LIKE @search 
                 OR sale_date LIKE @search";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);

                // 2. Bind the data to your DataGridView (Note: I changed the name to dgvAccounts to make it relevant, change it back if you kept dgvStudents!)
                dgvOrderlist.DataSource = table;

                // 3. Rename the headers so they look clean on your dashboard
                dgvOrderlist.Columns["sale_id"].HeaderText = "ID";
                dgvOrderlist.Columns["product_id"].HeaderText = "Product ID";
                dgvOrderlist.Columns["product_name"].HeaderText = "Product Name";
                dgvOrderlist.Columns["quantity"].HeaderText = "Quantity";
                dgvOrderlist.Columns["amount"].HeaderText = "Amount";
                dgvOrderlist.Columns["sale_date"].HeaderText = "Date";
                adapter.Dispose();
                cmd.Dispose();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { db.Close(); }

        }

        private void dgvOrderlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            // 1. Check if an order is actually selected in the DataGridView
            if (dgvOrderlist.CurrentRow == null || dgvOrderlist.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select an order from the list first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Ask the user for confirmation before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete this order record? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return; // Stop here if they click No
            }

            // 3. Grab the ID directly from the selected row's "sale_id" column
            // (This must match the exact column name from your SELECT query)
            int selectedSaleId = Convert.ToInt32(dgvOrderlist.CurrentRow.Cells["sale_id"].Value);

            // 4. Connect to the database and delete the record
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                // Target the 'sales' table using the sale_id
                string query = "DELETE FROM sales WHERE sale_id = @id";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@id", selectedSaleId);

                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Dispose();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. Instantly refresh the grid so the deleted order disappears
                    LoadOrderList();
                }
                else
                {
                    MessageBox.Show("Delete failed. Order could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            manager_dashboard dashboard = new manager_dashboard();
            dashboard.Show();
            this.Hide();
        } 
    }

}
