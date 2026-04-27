namespace Cafe_ccst
{
    partial class manager_dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_dashboard));
            btnProducts = new Button();
            btnOrders = new Button();
            btnLogout = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.LightBlue;
            btnProducts.BackgroundImage = (Image)resources.GetObject("btnProducts.BackgroundImage");
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = SystemColors.ButtonHighlight;
            btnProducts.Location = new Point(349, 435);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(283, 96);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.LightBlue;
            btnOrders.BackgroundImage = (Image)resources.GetObject("btnOrders.BackgroundImage");
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.ForeColor = SystemColors.ButtonFace;
            btnOrders.Location = new Point(349, 287);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(283, 96);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "ORDERS";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(196, 164, 132);
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(111, 78, 55);
            btnLogout.FlatAppearance.BorderSize = 3;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Location = new Point(777, 532);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(165, 55);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(229, -25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(617, 185);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(80, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 113);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // manager_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 611);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnOrders);
            Controls.Add(btnProducts);
            Controls.Add(pictureBox2);
            Name = "manager_dashboard";
            Text = "manager_dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInventory;
        private Button btnProducts;
        private Button btnOrders;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}