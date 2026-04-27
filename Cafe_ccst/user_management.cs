using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_ccst
{
    public partial class user_management : Form
    {
        public user_management()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            string search = txtSearch.Text.Trim();

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"SELECT id, lastname, firstname, middlename, email, username, password 
                 FROM accounts 
                 WHERE firstname LIKE @search 
                 OR lastname LIKE @search 
                 OR username LIKE @search 
                 OR email LIKE @search";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);

                // 2. Bind the data to your DataGridView (Note: I changed the name to dgvAccounts to make it relevant, change it back if you kept dgvStudents!)
                dgvAccounts.DataSource = table;

                // 3. Rename the headers so they look clean on your dashboard
                dgvAccounts.Columns["id"].HeaderText = "ID";
                dgvAccounts.Columns["lastname"].HeaderText = "Last Name";
                dgvAccounts.Columns["firstname"].HeaderText = "First Name";
                dgvAccounts.Columns["middlename"].HeaderText = "Middle Name";
                dgvAccounts.Columns["email"].HeaderText = "Email Address";
                dgvAccounts.Columns["username"].HeaderText = "Username";
                dgvAccounts.Columns["password"].HeaderText = "Password";

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add_user addUserForm = new add_user();
            addUserForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow == null || dgvAccounts.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select an account from the table first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Grab the ID directly from the selected row's "id" column
            int ID = Convert.ToInt32(dgvAccounts.CurrentRow.Cells["id"].Value);

            // 3. Updated confirmation message
            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            // ... The rest of your database connection and DELETE code stays exactly the same!
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "DELETE FROM accounts WHERE id=@id";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", ID);

                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Dispose();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // You can clear whatever text boxes you DO have here (like txtFirstname.Clear();)

                    // Refresh the grid
                    LoadStudents();
                }
                else
                {
                    MessageBox.Show("Delete failed. Account could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            admin_dashboard adminDashboard = new admin_dashboard();
            adminDashboard.Show();
            this.Hide();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // 1. Check if an account is actually selected
            if (dgvAccounts.CurrentRow == null || dgvAccounts.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select an account from the table first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Grab all the data from the selected row
            int selectedID = Convert.ToInt32(dgvAccounts.CurrentRow.Cells["id"].Value);
            string lastname = dgvAccounts.CurrentRow.Cells["lastname"].Value.ToString();
            string firstname = dgvAccounts.CurrentRow.Cells["firstname"].Value.ToString();
            string middlename = dgvAccounts.CurrentRow.Cells["middlename"].Value.ToString();
            string email = dgvAccounts.CurrentRow.Cells["email"].Value.ToString();
            string username = dgvAccounts.CurrentRow.Cells["username"].Value.ToString();
            string password = dgvAccounts.CurrentRow.Cells["password"].Value.ToString();

            // 3. Open the update form and pass the data directly into it
            // (You will see a red line here until we complete Step 2!)
            update_user updateForm = new update_user(selectedID, lastname, firstname, middlename, email, username, password);

            // 4. Show the form, and wait for it to close
            updateForm.ShowDialog();

            // 5. Refresh the grid so the new changes appear instantly!
            LoadStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_dashboard adminDashboard = new admin_dashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void user_management_Load(object sender, EventArgs e)
        {

        }
    }

}
