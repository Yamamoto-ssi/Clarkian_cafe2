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
                string query = "INSERT INTO products (category_id, name, description, price, image_url) VALUES (@category_id, @name, @description, @price, @image_url)";
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
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                // 1. Search the products table for matches in the name or description
                string query = @"SELECT product_id, category_id, name, description, price, image_url 
                     FROM products 
                     WHERE name LIKE @search 
                     OR description LIKE @search";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);

                // 2. Bind the data to your specific DataGridView
                dgvProductList.DataSource = table;

                // 3. Rename the headers so they look clean on your dashboard
                dgvProductList.Columns["product_id"].HeaderText = "Product ID";
                dgvProductList.Columns["category_id"].HeaderText = "Category ID";
                dgvProductList.Columns["name"].HeaderText = "Product Name";
                dgvProductList.Columns["description"].HeaderText = "Description";
                dgvProductList.Columns["price"].HeaderText = "Price";
                dgvProductList.Columns["image_url"].HeaderText = "Image Path";

                adapter.Dispose();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}