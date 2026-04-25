namespace Cafe_ccst
{
    partial class Menu
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
            flpProducts = new FlowLayoutPanel();
            panel2 = new Panel();
            lstOrders = new ListBox();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTotal = new TextBox();
            txtDiscount = new TextBox();
            txtRaw = new TextBox();
            rbRegular = new RadioButton();
            rbPWD = new RadioButton();
            rbSeniorCitizen = new RadioButton();
            btnPay = new Button();
            pnlDiscount = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pnlDiscount.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(flpProducts);
            panel1.Location = new Point(2, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 683);
            panel1.TabIndex = 0;
            // 
            // flpProducts
            // 
            flpProducts.AutoScroll = true;
            flpProducts.BackColor = SystemColors.ButtonHighlight;
            flpProducts.Dock = DockStyle.Fill;
            flpProducts.Location = new Point(0, 0);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(742, 683);
            flpProducts.TabIndex = 0;
            flpProducts.Paint += flpProducts_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(lstOrders);
            panel2.Location = new Point(766, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 390);
            panel2.TabIndex = 1;
            // 
            // lstOrders
            // 
            lstOrders.FormattingEnabled = true;
            lstOrders.ItemHeight = 15;
            lstOrders.Location = new Point(12, 15);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(307, 364);
            lstOrders.TabIndex = 0;
            lstOrders.SelectedIndexChanged += lstOrders_SelectedIndexChanged;
            lstOrders.DoubleClick += lstOrders_DoubleClick_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cornsilk;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(txtDiscount);
            panel3.Controls.Add(txtRaw);
            panel3.Location = new Point(766, 484);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 208);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 164);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 10;
            label3.Text = "Total:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 102);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Discount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 8;
            label1.Text = "Raw Amount:";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(110, 156);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(206, 29);
            txtTotal.TabIndex = 7;
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(110, 94);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(206, 29);
            txtDiscount.TabIndex = 6;
            // 
            // txtRaw
            // 
            txtRaw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRaw.Location = new Point(110, 33);
            txtRaw.Name = "txtRaw";
            txtRaw.Size = new Size(206, 29);
            txtRaw.TabIndex = 0;
            // 
            // rbRegular
            // 
            rbRegular.AutoSize = true;
            rbRegular.Checked = true;
            rbRegular.Location = new Point(24, 20);
            rbRegular.Name = "rbRegular";
            rbRegular.Size = new Size(65, 19);
            rbRegular.TabIndex = 5;
            rbRegular.TabStop = true;
            rbRegular.Text = "Regular";
            rbRegular.UseVisualStyleBackColor = true;
            rbRegular.CheckedChanged += rbRegular_CheckedChanged;
            // 
            // rbPWD
            // 
            rbPWD.AutoSize = true;
            rbPWD.Location = new Point(237, 20);
            rbPWD.Name = "rbPWD";
            rbPWD.Size = new Size(51, 19);
            rbPWD.TabIndex = 4;
            rbPWD.Text = "PDW";
            rbPWD.UseVisualStyleBackColor = true;
            rbPWD.CheckedChanged += rbPWD_CheckedChanged;
            // 
            // rbSeniorCitizen
            // 
            rbSeniorCitizen.AutoSize = true;
            rbSeniorCitizen.Location = new Point(117, 20);
            rbSeniorCitizen.Name = "rbSeniorCitizen";
            rbSeniorCitizen.Size = new Size(97, 19);
            rbSeniorCitizen.TabIndex = 3;
            rbSeniorCitizen.Text = "Senior Citizen";
            rbSeniorCitizen.UseVisualStyleBackColor = true;
            rbSeniorCitizen.CheckedChanged += rbSeniorCitizen_CheckedChanged_1;
            // 
            // btnPay
            // 
            btnPay.BackColor = SystemColors.ControlDark;
            btnPay.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(954, 712);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(131, 49);
            btnPay.TabIndex = 3;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // pnlDiscount
            // 
            pnlDiscount.BackColor = SystemColors.ActiveCaption;
            pnlDiscount.Controls.Add(rbSeniorCitizen);
            pnlDiscount.Controls.Add(rbPWD);
            pnlDiscount.Controls.Add(rbRegular);
            pnlDiscount.Enabled = false;
            pnlDiscount.Location = new Point(768, 418);
            pnlDiscount.Name = "pnlDiscount";
            pnlDiscount.Size = new Size(317, 49);
            pnlDiscount.TabIndex = 4;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 766);
            Controls.Add(pnlDiscount);
            Controls.Add(btnPay);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlDiscount.ResumeLayout(false);
            pnlDiscount.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtRaw;
        private Button btnPay;
        private FlowLayoutPanel flpProducts;
        private ListBox lstOrders;
        private TextBox txtTotal;
        private TextBox txtDiscount;
        private RadioButton rbRegular;
        private RadioButton rbPWD;
        private RadioButton rbSeniorCitizen;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel pnlDiscount;
    }
}