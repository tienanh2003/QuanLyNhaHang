namespace QuanLyNhaHang
{
    partial class frmQuanLyKho
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
            this.txtTPChinh = new System.Windows.Forms.TextBox();
            this.txtRau = new System.Windows.Forms.TextBox();
            this.txtTPPhu = new System.Windows.Forms.TextBox();
            this.cboMonAn = new System.Windows.Forms.ComboBox();
            this.btnKTra = new System.Windows.Forms.Button();
            this.lblKiemTra = new System.Windows.Forms.Label();
            this.dtgvDSMon = new System.Windows.Forms.DataGridView();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHienThi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTPChinh
            // 
            this.txtTPChinh.Location = new System.Drawing.Point(77, 149);
            this.txtTPChinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTPChinh.Name = "txtTPChinh";
            this.txtTPChinh.Size = new System.Drawing.Size(169, 22);
            this.txtTPChinh.TabIndex = 1;
            // 
            // txtRau
            // 
            this.txtRau.Location = new System.Drawing.Point(77, 210);
            this.txtRau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRau.Name = "txtRau";
            this.txtRau.Size = new System.Drawing.Size(169, 22);
            this.txtRau.TabIndex = 2;
            // 
            // txtTPPhu
            // 
            this.txtTPPhu.Location = new System.Drawing.Point(77, 270);
            this.txtTPPhu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTPPhu.Name = "txtTPPhu";
            this.txtTPPhu.Size = new System.Drawing.Size(169, 22);
            this.txtTPPhu.TabIndex = 3;
            // 
            // cboMonAn
            // 
            this.cboMonAn.FormattingEnabled = true;
            this.cboMonAn.Location = new System.Drawing.Point(77, 85);
            this.cboMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMonAn.Name = "cboMonAn";
            this.cboMonAn.Size = new System.Drawing.Size(169, 24);
            this.cboMonAn.TabIndex = 4;
            this.cboMonAn.SelectedIndexChanged += new System.EventHandler(this.cboMonAn_SelectedIndexChanged);
            // 
            // btnKTra
            // 
            this.btnKTra.Location = new System.Drawing.Point(77, 335);
            this.btnKTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKTra.Name = "btnKTra";
            this.btnKTra.Size = new System.Drawing.Size(171, 23);
            this.btnKTra.TabIndex = 5;
            this.btnKTra.Text = "Kiểm Tra";
            this.btnKTra.UseVisualStyleBackColor = true;
            this.btnKTra.Click += new System.EventHandler(this.btnKTra_Click);
            // 
            // lblKiemTra
            // 
            this.lblKiemTra.AutoSize = true;
            this.lblKiemTra.Location = new System.Drawing.Point(289, 342);
            this.lblKiemTra.Name = "lblKiemTra";
            this.lblKiemTra.Size = new System.Drawing.Size(44, 16);
            this.lblKiemTra.TabIndex = 6;
            this.lblKiemTra.Text = "label1";
            // 
            // dtgvDSMon
            // 
            this.dtgvDSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSMon.Location = new System.Drawing.Point(504, 57);
            this.dtgvDSMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvDSMon.Name = "dtgvDSMon";
            this.dtgvDSMon.RowHeadersWidth = 51;
            this.dtgvDSMon.RowTemplate.Height = 24;
            this.dtgvDSMon.Size = new System.Drawing.Size(611, 230);
            this.dtgvDSMon.TabIndex = 7;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(77, 388);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(171, 23);
            this.btnThemMon.TabIndex = 8;
            this.btnThemMon.Text = "Thêm Vào Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "TP Chính";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rau";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "TP Phụ";
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Location = new System.Drawing.Point(504, 316);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(16, 16);
            this.lblHienThi.TabIndex = 12;
            this.lblHienThi.Text = "...";
            // 
            // frmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1179, 514);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.dtgvDSMon);
            this.Controls.Add(this.lblKiemTra);
            this.Controls.Add(this.btnKTra);
            this.Controls.Add(this.cboMonAn);
            this.Controls.Add(this.txtTPPhu);
            this.Controls.Add(this.txtRau);
            this.Controls.Add(this.txtTPChinh);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho";
            this.Load += new System.EventHandler(this.frmQuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTPChinh;
        private System.Windows.Forms.TextBox txtRau;
        private System.Windows.Forms.TextBox txtTPPhu;
        private System.Windows.Forms.ComboBox cboMonAn;
        private System.Windows.Forms.Button btnKTra;
        private System.Windows.Forms.Label lblKiemTra;
        private System.Windows.Forms.DataGridView dtgvDSMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHienThi;
    }
}