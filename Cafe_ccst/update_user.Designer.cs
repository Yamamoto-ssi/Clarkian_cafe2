namespace Cafe_ccst
{
    partial class update_user
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
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            txtMiddlename = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnBack = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(40, 54);
            txtLastname.Multiline = true;
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(334, 27);
            txtLastname.TabIndex = 0;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(40, 114);
            txtFirstname.Multiline = true;
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(334, 27);
            txtFirstname.TabIndex = 1;
            // 
            // txtMiddlename
            // 
            txtMiddlename.Location = new Point(40, 172);
            txtMiddlename.Multiline = true;
            txtMiddlename.Name = "txtMiddlename";
            txtMiddlename.Size = new Size(334, 27);
            txtMiddlename.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(39, 228);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(335, 27);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 285);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(334, 27);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(40, 340);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(334, 27);
            txtPassword.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaptionText;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(24, 399);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(165, 55);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.OliveDrab;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(209, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 55);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 34);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 8;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 94);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 9;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 152);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 10;
            label3.Text = "Middle Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 208);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 11;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 265);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 320);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 13;
            label6.Text = "Password:";
            // 
            // update_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(413, 483);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtMiddlename);
            Controls.Add(txtFirstname);
            Controls.Add(txtLastname);
            ForeColor = SystemColors.ButtonFace;
            Name = "update_user";
            Text = "update_user";
            Load += update_user_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLastname;
        private TextBox txtFirstname;
        private TextBox txtMiddlename;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnBack;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}