namespace Cafe_ccst
{
    partial class admin_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_dashboard));
            btnUser = new Button();
            btnLogs = new Button();
            btnBackup = new Button();
            btnOverview = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(215, 204, 200);
            btnUser.FlatAppearance.BorderColor = Color.FromArgb(111, 78, 55);
            btnUser.FlatAppearance.BorderSize = 3;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.Location = new Point(176, 225);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(253, 119);
            btnUser.TabIndex = 0;
            btnUser.Text = "USER MANAGEMENT";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnLogs
            // 
            btnLogs.BackColor = Color.FromArgb(215, 204, 200);
            btnLogs.FlatAppearance.BorderColor = Color.FromArgb(111, 78, 55);
            btnLogs.FlatAppearance.BorderSize = 3;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogs.Location = new Point(619, 225);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(253, 119);
            btnLogs.TabIndex = 1;
            btnLogs.Text = "LOGS";
            btnLogs.UseVisualStyleBackColor = false;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.FromArgb(215, 204, 200);
            btnBackup.FlatAppearance.BorderColor = Color.FromArgb(111, 78, 55);
            btnBackup.FlatAppearance.BorderSize = 3;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackup.Location = new Point(176, 437);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(253, 119);
            btnBackup.TabIndex = 2;
            btnBackup.Text = "BACKUP";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.FromArgb(215, 204, 200);
            btnOverview.FlatAppearance.BorderColor = Color.FromArgb(111, 78, 55);
            btnOverview.FlatAppearance.BorderSize = 3;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOverview.Location = new Point(619, 437);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(253, 119);
            btnOverview.TabIndex = 3;
            btnOverview.Text = "OVERVIEW";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(196, 164, 132);
            button1.FlatAppearance.BorderColor = Color.FromArgb(111, 78, 55);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(842, 620);
            button1.Name = "button1";
            button1.Size = new Size(143, 46);
            button1.TabIndex = 4;
            button1.Text = "LOG OUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(59, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 137);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(208, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(653, 171);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // admin_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 768);
            Controls.Add(pictureBox1);
            Controls.Add(btnUser);
            Controls.Add(btnLogs);
            Controls.Add(button1);
            Controls.Add(btnOverview);
            Controls.Add(btnBackup);
            Controls.Add(pictureBox2);
            Name = "admin_dashboard";
            Text = "admin_dashboard";
            Load += admin_dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUser;
        private Button btnLogs;
        private Button btnBackup;
        private Button btnOverview;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}