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
    public partial class update_user : Form
    {
        private int currentID;
        public update_user(int id, string last, string first, string middle, string email, string user, string pass)
        {
            InitializeComponent();

            currentID = id;

            // 2. Populate your textboxes with the data from the grid
            // (Make sure these textbox names match what you actually named them on this form)
            txtLastname.Text = last;
            txtFirstname.Text = first;
            txtMiddlename.Text = middle;
            txtEmail.Text = email;
            txtUsername.Text = user;
            txtPassword.Text = pass;


        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            user_management userManagementForm = new user_management();
            userManagementForm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                // The SQL UPDATE command
                string query = @"UPDATE accounts 
                         SET lastname = @last, 
                             firstname = @first, 
                             middlename = @middle, 
                             email = @email, 
                             username = @user, 
                             password = @pass 
                         WHERE id = @id";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                // Bind the parameters to your textboxes
                cmd.Parameters.AddWithValue("@last", txtLastname.Text.Trim());
                cmd.Parameters.AddWithValue("@first", txtFirstname.Text.Trim());
                cmd.Parameters.AddWithValue("@middle", txtMiddlename.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());

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
    }
}
