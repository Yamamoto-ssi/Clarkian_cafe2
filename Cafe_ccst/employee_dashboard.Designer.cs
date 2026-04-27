namespace Cafe_ccst
{
    partial class employee_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_dashboard));
            btnMenu = new Button();
            btnPayments = new Button();
            btnOrder = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(215, 204, 200);
            btnMenu.FlatAppearance.BorderColor = Color.FromArgb(111, 78, 55);
            btnMenu.FlatAppearance.BorderSize = 3;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(255, 334);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(249, 86);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "MENU";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnPayments
            // 
            btnPayments.BackColor = Color.FromArgb(215, 204, 200);
            btnPayments.FlatAppearance.BorderColor = Color.FromArgb(111, 78, 55);
            btnPayments.FlatAppearance.BorderSize = 3;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayments.Location = new Point(548, 334);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(249, 86);
            btnPayments.TabIndex = 5;
            btnPayments.Text = "PAYMENTS";
            btnPayments.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(215, 204, 200);
            btnOrder.FlatAppearance.BorderColor = Color.FromArgb(111, 78, 55);
            btnOrder.FlatAppearance.BorderSize = 3;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(388, 455);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(249, 86);
            btnOrder.TabIndex = 6;
            btnOrder.Text = "ORDER LIST";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(196, 164, 132);
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(111, 78, 55);
            btnLogout.FlatAppearance.BorderSize = 3;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(828, 646);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(143, 46);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "LOG OUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(64, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 137);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(188, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(683, 379);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // employee_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 768);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnOrder);
            Controls.Add(btnPayments);
            Controls.Add(btnMenu);
            Controls.Add(pictureBox2);
            Name = "employee_dashboard";
            Text = "employee_dashboard";
            Load += employee_dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private Button btnPayments;
        private Button btnOrder;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}