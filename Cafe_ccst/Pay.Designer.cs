namespace Cafe_ccst
{
    partial class Pay
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
            panel2 = new Panel();
            lblTotal = new Label();
            btnPay = new Button();
            panel3 = new Panel();
            txtCash = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(lblTotal);
            panel2.Location = new Point(29, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 182);
            panel2.TabIndex = 9;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(94, 60);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(109, 50);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total";
            // 
            // btnPay
            // 
            btnPay.BackColor = SystemColors.ControlDark;
            btnPay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(237, 473);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(147, 37);
            btnPay.TabIndex = 8;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.Controls.Add(txtCash);
            panel3.Location = new Point(29, 236);
            panel3.Name = "panel3";
            panel3.Size = new Size(355, 231);
            panel3.TabIndex = 7;
            // 
            // txtCash
            // 
            txtCash.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCash.Location = new Point(22, 93);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(317, 39);
            txtCash.TabIndex = 0;
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 520);
            Controls.Add(panel2);
            Controls.Add(btnPay);
            Controls.Add(panel3);
            Name = "Pay";
            Text = "Pay";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblTotal;
        private Button btnPay;
        private Panel panel3;
        private TextBox txtCash;
    }
}