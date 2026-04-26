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
            ((System.ComponentModel.ISupportInitialize)dgvOrderlist).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(514, 65);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(276, 23);
            txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(365, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 38);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvOrderlist
            // 
            dgvOrderlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderlist.Location = new Point(11, 94);
            dgvOrderlist.Name = "dgvOrderlist";
            dgvOrderlist.Size = new Size(779, 514);
            dgvOrderlist.TabIndex = 3;
            dgvOrderlist.CellContentClick += dgvOrderlist_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(254, 47);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 42);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // orderlist_manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 658);
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
    }
}