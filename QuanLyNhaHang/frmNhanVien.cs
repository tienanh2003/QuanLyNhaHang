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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private string user;
        public frmNhanVien(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnTTNV_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien frmThongTinNhanVien = new frmThongTinNhanVien(user);
            frmThongTinNhanVien.TopLevel = false;
            frmThongTinNhanVien.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Clear();
            pnlHienThi.Controls.Add(frmThongTinNhanVien);
            frmThongTinNhanVien.Show();
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            frmGoiMon frmGoiMon = new frmGoiMon();
            frmGoiMon.TopLevel = false;
            frmGoiMon.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Clear();
            pnlHienThi.Controls.Add(frmGoiMon);
            frmGoiMon.Show();
        }

        private void btnTienLuong_Click(object sender, EventArgs e)
        {
            frmTienLuong frmTienLuong = new frmTienLuong(user);
            frmTienLuong.TopLevel = false;
            frmTienLuong.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Clear();
            pnlHienThi.Controls.Add(frmTienLuong);
            frmTienLuong.Show();
        }

        private void btnLichLamViec_Click(object sender, EventArgs e)
        {
            frmLichLamViec frmLichLamViec = new frmLichLamViec(user);
            frmLichLamViec.TopLevel = false;
            frmLichLamViec.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Clear();
            pnlHienThi.Controls.Add(frmLichLamViec);
            frmLichLamViec.Show();
        }

        private void btnBatDauKetThuc_Click(object sender, EventArgs e)
        {
            frmTienLuong frmTienLuong = new frmTienLuong(user);
            frmCheckInOut frmCheckInOut = new frmCheckInOut(user, frmTienLuong);
            frmCheckInOut.TopLevel = false;
            frmCheckInOut.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Clear();
            pnlHienThi.Controls.Add(frmCheckInOut);
            frmCheckInOut.Show();
        }
    }
}
