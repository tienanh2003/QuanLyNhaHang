namespace QuanLyNhaHang
{
    partial class frmTienLuong
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
            this.btnWord = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvHienThi
            // 
            this.dtgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHienThi.Location = new System.Drawing.Point(110, 122);
            this.dtgvHienThi.Name = "dtgvHienThi";
            this.dtgvHienThi.RowHeadersWidth = 51;
            this.dtgvHienThi.RowTemplate.Height = 24;
            this.dtgvHienThi.Size = new System.Drawing.Size(1014, 150);
            this.dtgvHienThi.TabIndex = 0;
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(407, 332);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(75, 23);
            this.btnWord.TabIndex = 1;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(688, 332);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(370, 397);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(44, 16);
            this.lblLuong.TabIndex = 3;
            this.lblLuong.Text = "label1";
            // 
            // frmTienLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1198, 569);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.dtgvHienThi);
            this.Name = "frmTienLuong";
            this.Text = "Tiền Lương";
            this.Load += new System.EventHandler(this.frmTienLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHienThi;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblLuong;
    }
}