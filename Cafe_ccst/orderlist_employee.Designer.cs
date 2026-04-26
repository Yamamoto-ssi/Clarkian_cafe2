namespace Cafe_ccst
{
    partial class orderlist_employee
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
            dgvOrderlist = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderlist).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderlist
            // 
            dgvOrderlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderlist.Location = new Point(13, 83);
            dgvOrderlist.Name = "dgvOrderlist";
            dgvOrderlist.Size = new Size(779, 514);
            dgvOrderlist.TabIndex = 0;
            dgvOrderlist.CellContentClick += dgvOrderlist_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(367, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 38);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(516, 54);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(276, 23);
            txtSearch.TabIndex = 2;
            // 
            // orderlist_employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 608);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvOrderlist);
            Name = "orderlist_employee";
            Text = "orderlist_employee";
            Load += orderlist_employee_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderlist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderlist;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}