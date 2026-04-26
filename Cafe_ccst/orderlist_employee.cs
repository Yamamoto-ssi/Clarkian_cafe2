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
    public partial class orderlist_employee : Form
    {
        public orderlist_employee()
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

        private void orderlist_employee_Load(object sender, EventArgs e)
        {

        }
    }
}
