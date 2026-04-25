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
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();

            // Wire up the clicks so hitting a label or picture clicks the whole card
            picProduct.Click += CardPiece_Click;
            lblName.Click += CardPiece_Click;
            lblPrice.Click += CardPiece_Click;
        }

        // Passes the click event from the pieces up to the main UserControl
        private void CardPiece_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }

        // --- PROPERTIES FOR DATA ---
        public string ProductName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string ProductPrice
        {
            get { return lblPrice.Text; }
            // Automatically adds the currency symbol when you set the price
            set { lblPrice.Text = "₱ " + value; }
        }





        public Image ProductImage
        {
            get { return picProduct.Image; }
            set { picProduct.Image = value; }
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
