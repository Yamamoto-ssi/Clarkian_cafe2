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
        private float totalAmountToPay = 0;
        private string currentReceipt = ""; // <--- NEW

        // 2. Update these parentheses to catch BOTH the total AND the receipt string
        public Pay(string totalFromMenu, string receiptFromMenu)
        {
            InitializeComponent();

            // Put the total on the screen
            lblTotal.Text = $"₱ {totalFromMenu}";

            // Safely convert that string into our float variable
            float.TryParse(totalFromMenu, out totalAmountToPay);

            // Save the receipt text into memory so we can use it later!
            currentReceipt = receiptFromMenu; // <--- NEW
        }

        // ... the rest of your code (panel1_Paint, btnPay_Click, etc.) stays exactly the same!

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCash.Text))
            {
                MessageBox.Show("Please enter the customer's cash amount!");
                return;
            }

            // Try to read the cash they typed
            if (float.TryParse(txtCash.Text, out float cashAmount))
            {
                // Did they give enough money?
                if (cashAmount < totalAmountToPay)
                {
                    MessageBox.Show("Insufficient cash!");
                    return;
                }

                // Calculate the exact change
                float chnge = cashAmount - totalAmountToPay;

                // ==========================================
                // --- NEW RECEIPT FINISHING CODE ---
                // ==========================================
                currentReceipt += "Cash:     ₱ " + cashAmount.ToString("0.00") + "\n";
                currentReceipt += "Change:   ₱ " + chnge.ToString("0.00") + "\n";
                currentReceipt += "=======================\n";
                currentReceipt += "      THANK YOU!       ";
                // ==========================================

                // Open the Change form and pass BOTH the change number and the finished receipt!
                Change changeScreen = new Change(chnge, currentReceipt);

                // If they click PROCEED on the change screen...
                if (changeScreen.ShowDialog() == DialogResult.OK)
                {
                    // Send the "OK" signal back down the chain to the Menu form!
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the cash!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


}
    

