namespace Cafe_ccst
{
    partial class Change
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
            panel1 = new Panel();
            lblChange = new Label();
            btnReceipt = new Button();
            btnProceed = new Button();
            printDialog1 = new PrintDialog();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblChange);
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(19, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 258);
            panel1.TabIndex = 0;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = SystemColors.ButtonFace;
            lblChange.Location = new Point(108, 104);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(144, 47);
            lblChange.TabIndex = 0;
            lblChange.Text = "Change";
            // 
            // btnReceipt
            // 
            btnReceipt.BackColor = Color.DarkGray;
            btnReceipt.FlatAppearance.BorderColor = Color.Gray;
            btnReceipt.FlatAppearance.BorderSize = 3;
            btnReceipt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReceipt.ForeColor = SystemColors.ButtonFace;
            btnReceipt.Location = new Point(19, 320);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(147, 37);
            btnReceipt.TabIndex = 1;
            btnReceipt.Text = "Receipt";
            btnReceipt.UseVisualStyleBackColor = false;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.DarkGray;
            btnProceed.FlatAppearance.BorderColor = Color.Gray;
            btnProceed.FlatAppearance.BorderSize = 3;
            btnProceed.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceed.ForeColor = SystemColors.ButtonFace;
            btnProceed.Location = new Point(239, 320);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(147, 37);
            btnProceed.TabIndex = 2;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 61);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 1;
            label1.Text = "CHANGE";
            // 
            // Change
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(413, 396);
            Controls.Add(btnProceed);
            Controls.Add(btnReceipt);
            Controls.Add(panel1);
            Name = "Change";
            Text = "Change";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblChange;
        private Button btnReceipt;
        private Button btnProceed;
        private PrintDialog printDialog1;
        private Label label1;
    }
}