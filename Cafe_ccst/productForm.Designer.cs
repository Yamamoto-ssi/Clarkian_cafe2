namespace Cafe_ccst
{
    partial class productForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnAdd = new Button();
            txtImage = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            lblCategory_ID = new Label();
            txtName = new TextBox();
            btnDelete = new Button();
            txtCategory_ID = new TextBox();
            btnBrowseImage = new Button();
            dgvProductList = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 356);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 35;
            label4.Text = "Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 289);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 34;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 232);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 33;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 173);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 32;
            label1.Text = "Name";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(31, 488);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 35);
            btnClear.TabIndex = 27;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(31, 425);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 35);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(28, 374);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(140, 23);
            txtImage.TabIndex = 25;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(28, 307);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(201, 23);
            txtPrice.TabIndex = 24;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(28, 250);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(201, 23);
            txtDescription.TabIndex = 23;
            // 
            // lblCategory_ID
            // 
            lblCategory_ID.AutoSize = true;
            lblCategory_ID.Location = new Point(28, 126);
            lblCategory_ID.Name = "lblCategory_ID";
            lblCategory_ID.Size = new Size(71, 15);
            lblCategory_ID.TabIndex = 22;
            lblCategory_ID.Text = "Category_ID";
            // 
            // txtName
            // 
            txtName.Location = new Point(28, 191);
            txtName.Name = "txtName";
            txtName.Size = new Size(201, 23);
            txtName.TabIndex = 19;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(149, 425);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 35);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtCategory_ID
            // 
            txtCategory_ID.Location = new Point(31, 147);
            txtCategory_ID.Name = "txtCategory_ID";
            txtCategory_ID.Size = new Size(201, 23);
            txtCategory_ID.TabIndex = 37;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(174, 374);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(55, 23);
            btnBrowseImage.TabIndex = 38;
            btnBrowseImage.Text = "Browse";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.BackgroundColor = SystemColors.ActiveCaption;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(315, 71);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.Size = new Size(697, 485);
            dgvProductList.TabIndex = 39;
            dgvProductList.CellContentClick += dgvProductList_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(492, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 40;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(716, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 23);
            btnSearch.TabIndex = 41;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(315, 31);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(171, 15);
            lblSearch.TabIndex = 42;
            lblSearch.Text = "Search Product by Name/Desc:";
            // 
            // productForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 761);
            Controls.Add(dgvProductList);
            Controls.Add(lblSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtCategory_ID);
            Controls.Add(btnDelete);
            Controls.Add(btnBrowseImage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtImage);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(lblCategory_ID);
            Controls.Add(txtName);
            Name = "productForm";
            Text = "productForm";
            Load += productForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnClear;
        private Button btnAdd;
        private TextBox txtImage;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private Label lblCategory_ID;
        private TextBox txtName;
        private Button btnDelete;
        private TextBox txtCategory_ID;
        private Button btnBrowseImage;
        private DataGridView dgvProductList;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblSearch;
    }
}