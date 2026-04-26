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
            btnSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(510, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 38);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(659, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(276, 23);
            txtSearch.TabIndex = 1;
            // 
            // dgvAccounts
            // 
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.BackgroundColor = SystemColors.ActiveCaption;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(31, 72);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.Size = new Size(904, 402);
            dgvAccounts.TabIndex = 2;
            dgvAccounts.CellContentClick += dgvAccounts_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(31, 496);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 38);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(180, 496);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 38);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(361, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(143, 38);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(1024, 768);
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