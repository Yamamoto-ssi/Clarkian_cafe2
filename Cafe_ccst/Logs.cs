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
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
            LoadLoginHistory();
        }

        private void LoadLoginHistory()
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                // Fetch the logs, putting the newest logins at the very top
                string query = @"
            SELECT 
                id AS 'Log ID', 
                username AS 'User', 
                login_time AS 'Date & Time'
            FROM logs
            ORDER BY login_time DESC";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);

                // Display the data in your grid!
                dgvLogs.DataSource = table;

                adapter.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void dgvLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            admin_dashboard adminDashboard = new admin_dashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
