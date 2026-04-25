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
            panel1 = new Panel();
            pnlTotal = new Panel();
            pnlCash = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlCash);
            panel1.Controls.Add(pnlTotal);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 397);
            panel1.TabIndex = 0;
            // 
            // pnlTotal
            // 
            pnlTotal.Location = new Point(9, 24);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(369, 132);
            pnlTotal.TabIndex = 0;
            // 
            // pnlCash
            // 
            pnlCash.Location = new Point(9, 190);
            pnlCash.Name = "pnlCash";
            pnlCash.Size = new Size(369, 132);
            pnlCash.TabIndex = 1;
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 395);
            Controls.Add(panel1);
            Name = "Pay";
            Text = "Pay";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlCash;
        private Panel pnlTotal;
    }
}