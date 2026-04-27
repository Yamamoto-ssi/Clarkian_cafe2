using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cafe_ccst
{
    public partial class update_product : Form
    {

        private int currentID;


        public update_product(int id, int category, string name, string description, string price, string image)
        {
            InitializeComponent();

            currentID = id;

            // 2. Populate your textboxes with the data from the grid
            // (Make sure these textbox names match what you actually named them on this form)
            txtCategory.Text = category.ToString();
            txtName.Text = name;
            txtDescription.Text = description;
            txtPrice.Text = price;
            txtImage.Text = image;
        }

        private void update_product_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                // The SQL UPDATE command
                string query = @"UPDATE products 
                         SET category_id = @category_id, 
                             name = @name, 
                             description = @description, 
                             price = @price, 
                             image_url = @image_url 
                         WHERE product_id = @id";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                // Bind the parameters to your textboxes
                cmd.Parameters.AddWithValue("@category_id", txtCategory.Text.Trim());
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@image_url", txtImage.Text.Trim());
                // Don't forget the ID so it knows WHO to update!
                cmd.Parameters.AddWithValue("@id", currentID);

                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Dispose();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the update form
                }
                else
                {
                    MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 1. Get the current user's profile path (C:\Users\Username)
                string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                // 2. Combine it with the rest of your specific folder path
                string targetFolder = System.IO.Path.Combine(userProfile, @"Downloads\Clarkian_cafe2-main\Cafe_ccst\Resources");

                // 3. Tell the file dialog to start in this folder
                openFileDialog.InitialDirectory = targetFolder;

                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";
                openFileDialog.Title = "Select Product Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtImage.Text = openFileDialog.FileName;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
