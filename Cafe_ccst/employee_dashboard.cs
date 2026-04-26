using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_ccst
{
    public partial class employee_dashboard : Form
    {
        public employee_dashboard()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
                        orderlist_employee orderList = new orderlist_employee();
                                    orderList.Show();
        }
    }
}
