namespace QuanLyNhaHang
{
    partial class frmLichLamViec
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
            this.dtgvLich = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLich)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLich
            // 
            this.dtgvLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLich.Location = new System.Drawing.Point(87, 98);
            this.dtgvLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvLich.Name = "dtgvLich";
            this.dtgvLich.RowHeadersWidth = 51;
            this.dtgvLich.RowTemplate.Height = 24;
            this.dtgvLich.Size = new System.Drawing.Size(1016, 118);
            this.dtgvLich.TabIndex = 0;
            this.dtgvLich.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLich_CellContentClick);
            // 
            // frmLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 562);
            this.Controls.Add(this.dtgvLich);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLichLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Làm Việc";
            this.Load += new System.EventHandler(this.frmLichLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLich;
    }
}