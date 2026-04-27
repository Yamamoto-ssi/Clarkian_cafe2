namespace Cafe_ccst
{
    partial class update_product
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtImage = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            txtCategory = new TextBox();
            btnBack = new Button();
            btnSaveChange = new Button();
            btnBrowse = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 242);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 26;
            label5.Text = "Image:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 185);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 25;
            label4.Text = "Price:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 129);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 24;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 71);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 23;
            label2.Text = " Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 11);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 22;
            label1.Text = "Category ID:";
            // 
            // txtImage
            // 
            txtImage.Location = new Point(22, 270);
            txtImage.Multiline = true;
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(240, 29);
            txtImage.TabIndex = 18;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(21, 213);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(335, 29);
            txtPrice.TabIndex = 17;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(22, 157);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(334, 29);
            txtDescription.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Location = new Point(22, 99);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(334, 29);
            txtName.TabIndex = 15;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(22, 39);
            txtCategory.Multiline = true;
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(334, 29);
            txtCategory.TabIndex = 14;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(20, 334);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 41);
            btnBack.TabIndex = 27;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSaveChange
            // 
            btnSaveChange.Location = new Point(212, 334);
            btnSaveChange.Name = "btnSaveChange";
            btnSaveChange.Size = new Size(138, 41);
            btnSaveChange.TabIndex = 28;
            btnSaveChange.Text = "Save Changes";
            btnSaveChange.UseVisualStyleBackColor = true;
            btnSaveChange.Click += btnSaveChange_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(268, 270);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(88, 29);
            btnBrowse.TabIndex = 29;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // update_product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 450);
            Controls.Add(btnBrowse);
            Controls.Add(btnSaveChange);
            Controls.Add(btnBack);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtImage);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtCategory);
            Name = "update_product";
            Text = "update_product";
            Load += update_product_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnBack;
        private TextBox txtImage;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtCategory;
        private Button btnSaveChange;
        private Button btnBrowse;
    }
}