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
            dgvOrderlist.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvOrderlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderlist.Location = new Point(30, 99);
            dgvOrderlist.Name = "dgvOrderlist";
            dgvOrderlist.Size = new Size(942, 500);
            dgvOrderlist.TabIndex = 0;
            dgvOrderlist.CellContentClick += dgvOrderlist_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlDark;
            btnSearch.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnSearch.FlatAppearance.BorderSize = 3;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(756, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(165, 55);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(185, 24);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(543, 39);
            txtSearch.TabIndex = 2;
            // 
            // orderlist_employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(984, 611);
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