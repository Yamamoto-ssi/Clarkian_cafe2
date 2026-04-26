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
            btnUser = new Button();
            btnLogs = new Button();
            btnBackup = new Button();
            btnOverview = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.Location = new Point(50, 45);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(249, 86);
            btnUser.TabIndex = 0;
            btnUser.Text = "USER MANAGEMENT";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnLogs
            // 
            btnLogs.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogs.Location = new Point(366, 45);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(249, 86);
            btnLogs.TabIndex = 1;
            btnLogs.Text = "LOGS";
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnBackup
            // 
            btnBackup.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackup.Location = new Point(50, 180);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(249, 86);
            btnBackup.TabIndex = 2;
            btnBackup.Text = "BACKUP";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnOverview
            // 
            btnOverview.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOverview.Location = new Point(366, 180);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(249, 86);
            btnOverview.TabIndex = 3;
            btnOverview.Text = "OVERVIEW";
            btnOverview.UseVisualStyleBackColor = true;
            btnOverview.Click += btnOverview_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(830, 12);
            button1.Name = "button1";
            button1.Size = new Size(143, 46);
            button1.TabIndex = 4;
            button1.Text = "LOG OUT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // admin_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(button1);
            Controls.Add(btnOverview);
            Controls.Add(btnBackup);
            Controls.Add(btnLogs);
            Controls.Add(btnUser);
            Name = "admin_dashboard";
            Text = "admin_dashboard";
            Load += admin_dashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnUser;
        private Button btnLogs;
        private Button btnBackup;
        private Button btnOverview;
        private Button button1;
    }
}