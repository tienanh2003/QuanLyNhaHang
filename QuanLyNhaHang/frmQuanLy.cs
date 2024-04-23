using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frmQuanLyNhanVien = new frmQuanLyNhanVien();
            frmQuanLyNhanVien.TopLevel = false;
            frmQuanLyNhanVien.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Clear();
            pnlHienThi.Controls.Add(frmQuanLyNhanVien);
            frmQuanLyNhanVien.Show();
        }

        private void btnQLB_Click(object sender, EventArgs e)
        {
            frmQuanLyBanAn frmQuanLyBanAn = new frmQuanLyBanAn();
            frmQuanLyBanAn.TopLevel = false;
            frmQuanLyBanAn.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Clear();
            pnlHienThi.Controls.Add(frmQuanLyBanAn);
            frmQuanLyBanAn.Show();
        }

        private void btnQLMonAn_Click(object sender, EventArgs e)
        {
            frmQuanLyMonAn frmQuanLyBanAn = new frmQuanLyMonAn();
            frmQuanLyBanAn.TopLevel = false;
            frmQuanLyBanAn.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Clear();
            pnlHienThi.Controls.Add(frmQuanLyBanAn);
            frmQuanLyBanAn.Show();
        }

        private void btnLuongNV_Click(object sender, EventArgs e)
        {
            frmLuongNV frmLuongNV = new frmLuongNV();
            frmLuongNV.TopLevel = false;
            frmLuongNV.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Clear();
            pnlHienThi.Controls.Add(frmLuongNV);
            frmLuongNV.Show();
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu frmThongKeDoanh=new frmThongKeDoanhThu();
            frmThongKeDoanh.TopLevel = false;
            frmThongKeDoanh.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Clear();
            pnlHienThi.Controls.Add(frmThongKeDoanh);
            frmThongKeDoanh.Show();
        }
    }
}
