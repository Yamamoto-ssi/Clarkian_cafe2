namespace Cafe_ccst
{
    partial class ProductCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picProduct = new PictureBox();
            lblName = new Label();
            lblPrice = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // picProduct
            // 
            picProduct.Location = new Point(3, 3);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(144, 123);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 0;
            picProduct.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(55, 129);
            lblName.Name = "lblName";
            lblName.Size = new Size(41, 15);
            lblName.TabIndex = 1;
            lblName.Text = "NAME";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Click += lblName_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = SystemColors.GrayText;
            lblPrice.ForeColor = SystemColors.HighlightText;
            lblPrice.Location = new Point(55, 161);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(37, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "PRIZE";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 200);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrice);
            Controls.Add(picProduct);
            Controls.Add(panel1);
            Name = "ProductCard";
            Size = new Size(150, 200);
            Load += ProductCard_Load;
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picProduct;
        private Label lblName;
        private Label lblPrice;
        private Panel panel1;
    }
}
