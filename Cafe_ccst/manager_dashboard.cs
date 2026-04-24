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
            inventoryForm inventory = new inventoryForm();
            inventory.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            productForm product = new productForm();
            product.ShowDialog();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }
    }
}
