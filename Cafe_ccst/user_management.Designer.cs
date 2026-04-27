namespace Cafe_ccst
{
    partial class user_management
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvAccounts = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaptionText;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(734, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(165, 55);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ButtonFace;
            txtSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.ActiveCaptionText;
            txtSearch.Location = new Point(151, 34);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(543, 39);
            txtSearch.TabIndex = 1;
            // 
            // dgvAccounts
            // 
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(35, 114);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.Size = new Size(914, 402);
            dgvAccounts.TabIndex = 2;
            dgvAccounts.CellContentClick += dgvAccounts_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Goldenrod;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(411, 544);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(165, 55);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Maroon;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(784, 544);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(165, 55);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SteelBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ButtonFace;
            btnRefresh.Location = new Point(603, 544);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(165, 55);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(869, 710);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(143, 46);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Back";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // user_management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(984, 611);
            Controls.Add(btnLogout);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvAccounts);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Name = "user_management";
            Text = "user_management";
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvAccounts;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnLogout;
    }
}