namespace Cafe_ccst
{
    partial class orderlist_manager
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvOrderlist = new DataGridView();
            btnDelete = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderlist).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(185, 46);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(543, 39);
            txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkGray;
            btnSearch.FlatAppearance.BorderColor = Color.Gray;
            btnSearch.FlatAppearance.BorderSize = 3;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(749, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(165, 55);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvOrderlist
            // 
            dgvOrderlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderlist.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvOrderlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderlist.Location = new Point(36, 117);
            dgvOrderlist.Name = "dgvOrderlist";
            dgvOrderlist.Size = new Size(914, 402);
            dgvOrderlist.TabIndex = 3;
            dgvOrderlist.CellContentClick += dgvOrderlist_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.FlatAppearance.BorderColor = Color.Brown;
            btnDelete.FlatAppearance.BorderSize = 3;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(785, 544);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(165, 55);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkRed;
            btnBack.FlatAppearance.BorderColor = Color.Brown;
            btnBack.FlatAppearance.BorderSize = 3;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(36, 544);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(165, 55);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // orderlist_manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(984, 611);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvOrderlist);
            Name = "orderlist_manager";
            Text = "orderlist_manager";
            ((System.ComponentModel.ISupportInitialize)dgvOrderlist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvOrderlist;
        private Button btnDelete;
        private Button btnBack;
    }
}