namespace Cafe_ccst
{
    partial class inventoryForm
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
            txtName = new TextBox();
            lblProductID = new Label();
            lblCategory_ID = new Label();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtImage = new TextBox();
            btnUpdate = new Button();
            btnClear = new Button();
            btnRestock = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(54, 183);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(293, 26);
            txtName.TabIndex = 0;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(56, 85);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(65, 15);
            lblProductID.TabIndex = 2;
            lblProductID.Text = "Product_ID";
            // 
            // lblCategory_ID
            // 
            lblCategory_ID.AutoSize = true;
            lblCategory_ID.Location = new Point(54, 129);
            lblCategory_ID.Name = "lblCategory_ID";
            lblCategory_ID.Size = new Size(71, 15);
            lblCategory_ID.TabIndex = 3;
            lblCategory_ID.Text = "Category_ID";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(54, 242);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(293, 26);
            txtDescription.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(68, 299);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(293, 26);
            txtPrice.TabIndex = 5;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(54, 366);
            txtImage.Multiline = true;
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(293, 26);
            txtImage.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(165, 416);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.RightToLeft = RightToLeft.No;
            btnUpdate.Size = new Size(165, 55);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(12, 425);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(165, 55);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRestock
            // 
            btnRestock.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestock.Location = new Point(198, 549);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(165, 55);
            btnRestock.TabIndex = 11;
            btnRestock.Text = "Restock";
            btnRestock.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(182, 38);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(148, 39);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(822, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 42);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(363, 63);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(355, 26);
            txtSearch.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 165);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 15;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 224);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 16;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 281);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 17;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 348);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 18;
            label4.Text = "Image";
            // 
            // dgvProductList
            // 
            dgvProductList.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(353, 106);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.Size = new Size(626, 483);
            dgvProductList.TabIndex = 1;
            dgvProductList.CellContentClick += dgvProductList_CellContentClick;
            // 
            // inventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1024, 629);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnRestock);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(txtImage);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(lblCategory_ID);
            Controls.Add(lblProductID);
            Controls.Add(dgvProductList);
            Controls.Add(txtName);
            Name = "inventoryForm";
            Text = "inventoryForm";
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblProductID;
        private Label lblCategory_ID;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtImage;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnRestock;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvProductList;
    }
}