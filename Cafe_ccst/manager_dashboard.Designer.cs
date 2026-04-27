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
            btnInventory = new Button();
            btnProducts = new Button();
            btnOrders = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.LightBlue;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = SystemColors.ActiveCaptionText;
            btnInventory.Location = new Point(240, 60);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(577, 96);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "INVENTORY";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.LightBlue;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = SystemColors.ActiveCaptionText;
            btnProducts.Location = new Point(240, 389);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(577, 96);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.LightBlue;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.ForeColor = SystemColors.ActiveCaptionText;
            btnOrders.Location = new Point(240, 230);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(577, 96);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "ORDERS";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Black;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(793, 533);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(165, 55);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-2, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1007, 622);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // manager_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(984, 611);
            Controls.Add(btnLogout);
            Controls.Add(btnOrders);
            Controls.Add(btnProducts);
            Controls.Add(btnInventory);
            Controls.Add(pictureBox1);
            Name = "manager_dashboard";
            Text = "manager_dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInventory;
        private Button btnProducts;
        private Button btnOrders;
        private Button btnLogout;
        private PictureBox pictureBox1;
    }
}