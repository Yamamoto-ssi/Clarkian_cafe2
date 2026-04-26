using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Cafe_ccst
{
    public partial class Change : Form
    {
        // 1. Add this memory variable to hold the receipt text
        private string finalReceiptText = "";

        // 2. Add 'string receiptText' inside these parentheses!
        public Change(float calculatedChange, string receiptText)
        {
            InitializeComponent();

            // Put the change on the screen (Assuming your label is named lblChangeDisplay or something similar)
            lblChange.Text = $"₱ {calculatedChange:0.00}";

            // 3. Save the text into memory so the printer button can find it later
            finalReceiptText = receiptText;
        }

        // ... the rest of your code stays below ...

        public Change(float calculatedChange)
        {
            InitializeComponent();
            lblChange.Text = $"₱ {calculatedChange:0.00}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            // 1. Create a "virtual" piece of paper
            PrintDocument pd = new PrintDocument();

            // 2. Tell the paper to use our special drawing method below
            pd.PrintPage += new PrintPageEventHandler(PrintReceiptPage);

            // 3. Create the preview window and hand it the paper
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = pd;

            // Make the preview window pop up on the screen!
            previewDialog.ShowDialog();
        }

        // This is the "painter" method that actually draws the text onto the virtual paper
        private void PrintReceiptPage(object sender, PrintPageEventArgs e)
        {
            // Choose a font. (Courier New is a monospace font, perfect for receipts so everything lines up nicely!)
            Font font = new Font("Courier New", 12);

            // Draw our receipt text onto the paper, starting 10 pixels from the top and left
            e.Graphics.DrawString(finalReceiptText, font, Brushes.Black, new PointF(10, 10));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }
    }
}
