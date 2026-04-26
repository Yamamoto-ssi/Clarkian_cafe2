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
            txtLastname.Location = new Point(50, 61);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(261, 23);
            txtLastname.TabIndex = 0;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(50, 117);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(261, 23);
            txtFirstname.TabIndex = 1;
            // 
            // txtMiddlename
            // 
            txtMiddlename.Location = new Point(50, 173);
            txtMiddlename.Name = "txtMiddlename";
            txtMiddlename.Size = new Size(261, 23);
            txtMiddlename.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(50, 229);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(261, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(50, 286);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 23);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(50, 341);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(261, 23);
            txtPassword.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(22, 393);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(133, 44);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(209, 393);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 44);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 43);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 8;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 99);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 155);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 10;
            label3.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 211);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 11;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 268);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 323);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 13;
            label6.Text = "Password";
            // 
            // update_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 461);
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
            Name = "update_user";
            Text = "update_user";
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