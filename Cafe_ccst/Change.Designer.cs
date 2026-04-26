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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(lblChange);
            panel1.Location = new Point(19, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 202);
            panel1.TabIndex = 0;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(172, 64);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(144, 47);
            lblChange.TabIndex = 0;
            lblChange.Text = "Change";
            // 
            // btnReceipt
            // 
            btnReceipt.BackColor = Color.Olive;
            btnReceipt.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReceipt.Location = new Point(21, 273);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(216, 55);
            btnReceipt.TabIndex = 1;
            btnReceipt.Text = "RECEIPT";
            btnReceipt.UseVisualStyleBackColor = false;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.Olive;
            btnProceed.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceed.Location = new Point(301, 273);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(216, 55);
            btnProceed.TabIndex = 2;
            btnProceed.Text = "PROCEED";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // Change
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 534);
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
    }
}