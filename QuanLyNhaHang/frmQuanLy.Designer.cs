namespace QuanLyNhaHang
{
    partial class frmQuanLy
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
            this.btnLuongNV = new System.Windows.Forms.Button();
            this.btnThongKeDoanhThu = new System.Windows.Forms.Button();
            this.btnQLMonAn = new System.Windows.Forms.Button();
            this.btnQLB = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(1249, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin Chào Quản Lý";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnLuongNV);
            this.panel2.Controls.Add(this.btnThongKeDoanhThu);
            this.panel2.Controls.Add(this.btnQLMonAn);
            this.panel2.Controls.Add(this.btnQLB);
            this.panel2.Controls.Add(this.btnQLNV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 448);
            this.panel2.TabIndex = 1;
            // 
            // btnLuongNV
            // 
            this.btnLuongNV.Location = new System.Drawing.Point(3, 171);
            this.btnLuongNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuongNV.Name = "btnLuongNV";
            this.btnLuongNV.Size = new System.Drawing.Size(185, 49);
            this.btnLuongNV.TabIndex = 4;
            this.btnLuongNV.Text = "Lương Nhân Viên";
            this.btnLuongNV.UseVisualStyleBackColor = true;
            this.btnLuongNV.Click += new System.EventHandler(this.btnLuongNV_Click);
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(3, 226);
            this.btnThongKeDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(185, 49);
            this.btnThongKeDoanhThu.TabIndex = 3;
            this.btnThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
            this.btnThongKeDoanhThu.UseVisualStyleBackColor = true;
            this.btnThongKeDoanhThu.Click += new System.EventHandler(this.btnThongKeDoanhThu_Click);
            // 
            // btnQLMonAn
            // 
            this.btnQLMonAn.Location = new System.Drawing.Point(3, 116);
            this.btnQLMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLMonAn.Name = "btnQLMonAn";
            this.btnQLMonAn.Size = new System.Drawing.Size(185, 49);
            this.btnQLMonAn.TabIndex = 2;
            this.btnQLMonAn.Text = "Quản Lý Món Ăn";
            this.btnQLMonAn.UseVisualStyleBackColor = true;
            this.btnQLMonAn.Click += new System.EventHandler(this.btnQLMonAn_Click);
            // 
            // btnQLB
            // 
            this.btnQLB.Location = new System.Drawing.Point(4, 59);
            this.btnQLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLB.Name = "btnQLB";
            this.btnQLB.Size = new System.Drawing.Size(185, 49);
            this.btnQLB.TabIndex = 1;
            this.btnQLB.Text = "Quản Lý Bàn";
            this.btnQLB.UseVisualStyleBackColor = true;
            this.btnQLB.Click += new System.EventHandler(this.btnQLB_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Location = new System.Drawing.Point(3, 6);
            this.btnQLNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(185, 49);
            this.btnQLNV.TabIndex = 0;
            this.btnQLNV.Text = "Quản Lý Nhân Viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // pnlHienThi
            // 
            this.pnlHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHienThi.Location = new System.Drawing.Point(195, 82);
            this.pnlHienThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHienThi.Name = "pnlHienThi";
            this.pnlHienThi.Size = new System.Drawing.Size(1054, 448);
            this.pnlHienThi.TabIndex = 2;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 530);
            this.Controls.Add(this.pnlHienThi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý";
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
        private System.Windows.Forms.Button btnLuongNV;
        private System.Windows.Forms.Button btnThongKeDoanhThu;
        private System.Windows.Forms.Button btnQLMonAn;
        private System.Windows.Forms.Button btnQLB;
        private System.Windows.Forms.Button btnQLNV;
    }
}