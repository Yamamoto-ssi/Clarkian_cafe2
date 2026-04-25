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
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtRawAmount.Text, out float raw_amount))
            {
                MessageBox.Show("Please enter a valid number for the Amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stops the code from continuing and crashing
            }

            // 2. SAFELY try to read the Cash
            if (!float.TryParse(txtCash.Text, out float cash))
            {
                MessageBox.Show("Please enter a valid number for the Cash.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stops the code
            }

            // --- The rest of your code remains exactly the same! ---
            float discount = 0;
            float total = raw_amount;

            if (rbSeniorCitizen.Checked)
            {
                discount = raw_amount * 0.20f;
            }
            else if (rbPWD.Checked)
            {
                discount = raw_amount * 0.15f;
            }

            // ... [rest of your logic down to txtTotal.Text = total.ToString("0.00");]

        // 3. Apply the discount to the total
        total = raw_amount - discount;
        
            // 4. NOW check if the cash is sufficient (after the discount is applied)
            if (cash < total)
            {
                MessageBox.Show("Insufficient cash. The final total is ₱" + total.ToString("0.00"), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Calculate the change
            float change = cash - total;

            // 6. Update the UI for EVERYONE (not just Senior Citizens)
            txtTotal.Text = total.ToString("0.00");
            txtChange.Text = change.ToString("0.00");
            txtDiscont.Text = discount.ToString("0.00");
            // Optional: If you have textboxes for Discount and Change, you can display them like this:
            // txtDiscount.Text = discount.ToString("0.00");
            // txtChange.Text = change.ToString("0.00");
        }
    }

}
    

