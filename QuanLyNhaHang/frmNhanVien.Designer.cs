namespace QuanLyNhaHang
{
    partial class frmNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTienLuong = new System.Windows.Forms.Button();
            this.btnTTNV = new System.Windows.Forms.Button();
            this.btnBatDauKetThuc = new System.Windows.Forms.Button();
            this.btnGoiMon = new System.Windows.Forms.Button();
            this.btnLichLamViec = new System.Windows.Forms.Button();
            this.pnlHienThi = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin Chào Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnTienLuong);
            this.panel2.Controls.Add(this.btnTTNV);
            this.panel2.Controls.Add(this.btnBatDauKetThuc);
            this.panel2.Controls.Add(this.btnGoiMon);
            this.panel2.Controls.Add(this.btnLichLamViec);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 478);
            this.panel2.TabIndex = 1;
            // 
            // btnTienLuong
            // 
            this.btnTienLuong.Location = new System.Drawing.Point(15, 175);
            this.btnTienLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTienLuong.Name = "btnTienLuong";
            this.btnTienLuong.Size = new System.Drawing.Size(185, 49);
            this.btnTienLuong.TabIndex = 10;
            this.btnTienLuong.Text = "Tiền Lương";
            this.btnTienLuong.UseVisualStyleBackColor = true;
            this.btnTienLuong.Click += new System.EventHandler(this.btnTienLuong_Click);
            // 
            // btnTTNV
            // 
            this.btnTTNV.Location = new System.Drawing.Point(15, 10);
            this.btnTTNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTNV.Name = "btnTTNV";
            this.btnTTNV.Size = new System.Drawing.Size(185, 49);
            this.btnTTNV.TabIndex = 6;
            this.btnTTNV.Text = "Thông Tin Nhân Viên";
            this.btnTTNV.UseVisualStyleBackColor = true;
            this.btnTTNV.Click += new System.EventHandler(this.btnTTNV_Click);
            // 
            // btnBatDauKetThuc
            // 
            this.btnBatDauKetThuc.Location = new System.Drawing.Point(15, 230);
            this.btnBatDauKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBatDauKetThuc.Name = "btnBatDauKetThuc";
            this.btnBatDauKetThuc.Size = new System.Drawing.Size(185, 49);
            this.btnBatDauKetThuc.TabIndex = 11;
            this.btnBatDauKetThuc.Text = "Bắt  Đầu - Kết Thúc";
            this.btnBatDauKetThuc.UseVisualStyleBackColor = true;
            this.btnBatDauKetThuc.Click += new System.EventHandler(this.btnBatDauKetThuc_Click);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.Location = new System.Drawing.Point(15, 65);
            this.btnGoiMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(185, 49);
            this.btnGoiMon.TabIndex = 8;
            this.btnGoiMon.Text = "Gọi Món";
            this.btnGoiMon.UseVisualStyleBackColor = true;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // btnLichLamViec
            // 
            this.btnLichLamViec.Location = new System.Drawing.Point(15, 121);
            this.btnLichLamViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichLamViec.Name = "btnLichLamViec";
            this.btnLichLamViec.Size = new System.Drawing.Size(185, 49);
            this.btnLichLamViec.TabIndex = 9;
            this.btnLichLamViec.Text = "Lịch Làm Việc";
            this.btnLichLamViec.UseVisualStyleBackColor = true;
            this.btnLichLamViec.Click += new System.EventHandler(this.btnLichLamViec_Click);
            // 
            // pnlHienThi
            // 
            this.pnlHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHienThi.Location = new System.Drawing.Point(212, 80);
            this.pnlHienThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHienThi.Name = "pnlHienThi";
            this.pnlHienThi.Size = new System.Drawing.Size(980, 478);
            this.pnlHienThi.TabIndex = 2;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 558);
            this.Controls.Add(this.pnlHienThi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhà Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlHienThi;
        private System.Windows.Forms.Button btnTienLuong;
        private System.Windows.Forms.Button btnTTNV;
        private System.Windows.Forms.Button btnBatDauKetThuc;
        private System.Windows.Forms.Button btnGoiMon;
        private System.Windows.Forms.Button btnLichLamViec;
    }
}