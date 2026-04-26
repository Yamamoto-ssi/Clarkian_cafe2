using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_ccst
{
    public partial class admin_dashboard : Form
    {
        public admin_dashboard()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            user_management userManagementForm = new user_management();
            userManagementForm.Show();
            this.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnOverview_Click(object sender, EventArgs e)
        {

        }

        private void admin_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            Logs logsForm = new Logs();
            logsForm.Show();
            this.Hide();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
        
            // 1. Create a "Save As" popup window
            SaveFileDialog saveDialog = new SaveFileDialog();

            // Force it to save as an SQL file
            saveDialog.Filter = "SQL Database Backup (*.sql)|*.sql";
            saveDialog.Title = "Save Database Backup";

            // Automatically name the file with today's date (e.g., CafeBackup_2026-04-26.sql)
            saveDialog.FileName = "CafeBackup_" + DateTime.Now.ToString("yyyy-MM-dd") + ".sql";

            // 2. If the user clicks "Save" in the popup window...
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                DBConnect db = new DBConnect();

                try
                {
                    db.Open();

                    // 3. Prepare the command using your existing connection
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand())
                    {
                        cmd.Connection = db.Connection;

                        // 4. Use the new MySqlBackup tool to do all the heavy lifting!
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            // This tells the backup to include the "CREATE TABLE" commands
                            mb.ExportInfo.AddCreateDatabase = true;

                            // Export the entire database to the file path the user chose!
                            mb.ExportToFile(saveDialog.FileName);
                        }
                    }

                    MessageBox.Show("Database successfully backed up to:\n" + saveDialog.FileName, "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error backing up database: " + ex.Message, "Backup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.Close();
                }
            }
        }
    }
    
}
