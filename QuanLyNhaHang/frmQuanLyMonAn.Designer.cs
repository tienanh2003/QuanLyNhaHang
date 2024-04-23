namespace QuanLyNhaHang
{
    partial class frmQuanLyMonAn
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
            this.btnTimTheoMa = new System.Windows.Forms.Button();
            this.txtTimTheoMa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvDSMon = new System.Windows.Forms.DataGridView();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.btnQuanLyKho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimTheoMa
            // 
            this.btnTimTheoMa.Location = new System.Drawing.Point(755, 27);
            this.btnTimTheoMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimTheoMa.Name = "btnTimTheoMa";
            this.btnTimTheoMa.Size = new System.Drawing.Size(115, 22);
            this.btnTimTheoMa.TabIndex = 34;
            this.btnTimTheoMa.Text = "Tìm";
            this.btnTimTheoMa.UseVisualStyleBackColor = true;
            this.btnTimTheoMa.Click += new System.EventHandler(this.btnTimTheoMa_Click);
            // 
            // txtTimTheoMa
            // 
            this.txtTimTheoMa.Location = new System.Drawing.Point(499, 27);
            this.txtTimTheoMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimTheoMa.Name = "txtTimTheoMa";
            this.txtTimTheoMa.Size = new System.Drawing.Size(231, 22);
            this.txtTimTheoMa.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tìm Theo Mã";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(259, 350);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(152, 350);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(52, 350);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvDSMon
            // 
            this.dtgvDSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSMon.Location = new System.Drawing.Point(395, 90);
            this.dtgvDSMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvDSMon.Name = "dtgvDSMon";
            this.dtgvDSMon.RowHeadersWidth = 51;
            this.dtgvDSMon.RowTemplate.Height = 24;
            this.dtgvDSMon.Size = new System.Drawing.Size(779, 351);
            this.dtgvDSMon.TabIndex = 28;
            this.dtgvDSMon.DoubleClick += new System.EventHandler(this.dtgvDSMon_DoubleClick);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(103, 276);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(231, 22);
            this.txtSoLuong.TabIndex = 27;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(103, 207);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(231, 22);
            this.txtDonGia.TabIndex = 26;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(103, 144);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(231, 22);
            this.txtTenMon.TabIndex = 24;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(103, 90);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(231, 22);
            this.txtMaMon.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Giá Bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Món";
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Location = new System.Drawing.Point(391, 506);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(34, 16);
            this.lblHienThi.TabIndex = 35;
            this.lblHienThi.Text = ".........";
            // 
            // btnQuanLyKho
            // 
            this.btnQuanLyKho.Location = new System.Drawing.Point(941, 27);
            this.btnQuanLyKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanLyKho.Name = "btnQuanLyKho";
            this.btnQuanLyKho.Size = new System.Drawing.Size(152, 23);
            this.btnQuanLyKho.TabIndex = 36;
            this.btnQuanLyKho.Text = "Quản Lý Kho";
            this.btnQuanLyKho.UseVisualStyleBackColor = true;
            this.btnQuanLyKho.Click += new System.EventHandler(this.btnQuanLyKho_Click);
            // 
            // frmQuanLyMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1185, 565);
            this.Controls.Add(this.btnQuanLyKho);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.btnTimTheoMa);
            this.Controls.Add(this.txtTimTheoMa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvDSMon);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Món Ăn";
            this.Load += new System.EventHandler(this.frmQuanLyMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimTheoMa;
        private System.Windows.Forms.TextBox txtTimTheoMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgvDSMon;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Button btnQuanLyKho;
    }
}