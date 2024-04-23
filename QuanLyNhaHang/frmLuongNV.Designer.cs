namespace QuanLyNhaHang
{
    partial class frmLuongNV
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
            this.dtgvHienThi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvHienThi
            // 
            this.dtgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHienThi.Location = new System.Drawing.Point(75, 103);
            this.dtgvHienThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvHienThi.Name = "dtgvHienThi";
            this.dtgvHienThi.RowHeadersWidth = 51;
            this.dtgvHienThi.RowTemplate.Height = 24;
            this.dtgvHienThi.Size = new System.Drawing.Size(1023, 246);
            this.dtgvHienThi.TabIndex = 0;
            // 
            // frmLuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1165, 450);
            this.Controls.Add(this.dtgvHienThi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLuongNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lương NV";
            this.Load += new System.EventHandler(this.frmLuongNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHienThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHienThi;
    }
}