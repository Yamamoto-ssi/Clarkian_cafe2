namespace Cafe_ccst
{
    partial class Logs
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
            dgvLogs = new DataGridView();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(21, 89);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.Size = new Size(942, 500);
            dgvLogs.TabIndex = 0;
            dgvLogs.CellContentClick += dgvLogs_CellContentClick;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ActiveCaptionText;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(21, 16);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(165, 55);
            btnLogout.TabIndex = 23;
            btnLogout.Text = "Back";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Logs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(984, 611);
            Controls.Add(btnLogout);
            Controls.Add(dgvLogs);
            Name = "Logs";
            Text = "Logs";
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLogs;
        private Button btnLogout;
    }
}