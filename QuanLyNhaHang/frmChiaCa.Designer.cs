namespace QuanLyNhaHang
{
    partial class frmChiaCa
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
            this.btnChiaCa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvChiaCa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiaCa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChiaCa
            // 
            this.btnChiaCa.Location = new System.Drawing.Point(487, 30);
            this.btnChiaCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChiaCa.Name = "btnChiaCa";
            this.btnChiaCa.Size = new System.Drawing.Size(75, 23);
            this.btnChiaCa.TabIndex = 0;
            this.btnChiaCa.Text = "Chia Ca";
            this.btnChiaCa.UseVisualStyleBackColor = true;
            this.btnChiaCa.Click += new System.EventHandler(this.btnChiaCa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mỗi Nhân Viên Sẽ Được  Chia 1 Ngày 1 Ca";
            // 
            // dtgvChiaCa
            // 
            this.dtgvChiaCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiaCa.Location = new System.Drawing.Point(51, 110);
            this.dtgvChiaCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvChiaCa.Name = "dtgvChiaCa";
            this.dtgvChiaCa.RowHeadersWidth = 51;
            this.dtgvChiaCa.RowTemplate.Height = 24;
            this.dtgvChiaCa.Size = new System.Drawing.Size(1067, 356);
            this.dtgvChiaCa.TabIndex = 2;
            // 
            // frmChiaCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1160, 522);
            this.Controls.Add(this.dtgvChiaCa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChiaCa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChiaCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chia Ca";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiaCa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChiaCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvChiaCa;
    }
}