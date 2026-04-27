using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_ccst
{
    public partial class manager_dashboard : Form
    {
        public manager_dashboard()
        {
            InitializeComponent();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            productForm product = new productForm();
            product.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            orderlist_manager orderList = new orderlist_manager();
            orderList.Show();
            this.Hide();


        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
