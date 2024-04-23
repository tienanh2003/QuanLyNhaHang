using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuanLyNhaHang
{
    public partial class frmGoiMon : Form
    {
        public frmGoiMon()
        {
            InitializeComponent();
        }
        KetNoi kn=new KetNoi();
        QLMONAN monan = new QLMONAN();
        QLBANAN banan=new QLBANAN();
        public void fillGridMenu(SqlCommand command)
        {
            dtgvMenu.ReadOnly = true;
            dtgvMenu.DataSource = monan.getMonAn(command);
            dtgvMenu.AllowUserToAddRows = false;
        }
        public void fillGridBan(SqlCommand command)
        {

            dtgvDSBanTrong.ReadOnly = true;
            dtgvDSBanTrong.DataSource = banan.getBanAn(command);
            dtgvDSBanTrong.AllowUserToAddRows = false;
        }
        private void frmGoiMon_Load(object sender, EventArgs e)
        {
            fillGridMenu(new SqlCommand("SELECT MAMON AS N'Mã Món Ăn', TENMON AS N'Tên Món', GIABAN AS N'Giá Món', SOLUONG AS N'Số Lượng' FROM QLMON"));
            fillGridBan(new SqlCommand("SELECT MABAN AS N'Mã Bàn', TENBAN AS N'Tên Bàn', SOLUONG AS N'Số Lượng', GIABAN AS N'Giá Bàn', TINHTRANG AS N'Tình Trạng' FROM QLBAN"));
            SqlCommand command = new SqlCommand(" SELECT MABAN as N'Mã Bàn Ăn', TENBAN as N'Tên Bàn', SOLUONG as N'Số Lượng Khách', GIABAN as N'Giá Bàn', TINHTRANG as N'Tình Trạng' FROM QLBAN", kn.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            SqlCommand commandM = new SqlCommand(" SELECT MABAN as N'Mã Bàn Ăn', TENBAN as N'Tên Bàn', SOLUONG as N'Số Lượng Khách', GIABAN as N'Giá Bàn' FROM QLBAN", kn.GetConnection);
            SqlDataAdapter adapterM = new SqlDataAdapter(commandM);
            DataTable tableM = new DataTable();
            adapterM.Fill(tableM);
            tableM.Columns.Add("Tình Trạng", typeof(string));
            dtgvDSBanTrong.DataSource = tableM;
            dtgvDSBanTrong.AllowUserToAddRows = false;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (Convert.ToInt32(table.Rows[i]["Tình Trạng"].ToString()) == 0)
                {
                    dtgvDSBanTrong.Rows[i].Cells["Tình Trạng"].Value = "Trống";
                }
                else if (Convert.ToInt32(table.Rows[i]["Tình Trạng"].ToString()) == 1)
                {
                    dtgvDSBanTrong.Rows[i].Cells["Tình Trạng"].Value = "Đã Được Đặt";
                }
            }

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cboBan.Text == "Bàn Trống")
            {
                fillGridBan(new SqlCommand("SELECT MABAN as N'Mã Bàn Ăn', TENBAN as N'Tên Bàn', SOLUONG as N'Số Lượng Khách', GIABAN as N'Giá Bàn', TINHTRANG as N'Tình Trạng' FROM QLBAN WHERE TINHTRANG = 0"));
            }
            if (cboBan.Text == "Bàn Có Người")
            {
                fillGridBan(new SqlCommand("SELECT MABAN as N'Mã Bàn Ăn', TENBAN as N'Tên Bàn', SOLUONG as N'Số Lượng Khách', GIABAN as N'Giá Bàn', TINHTRANG as N'Tình Trạng' FROM QLBAN WHERE TINHTRANG = 1"));
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            fillGridMenu(new SqlCommand("SELECT MAMON AS N'Mã Món Ăn', TENMON AS N'Tên Món', GIABAN AS N'Giá Món', SOLUONG AS N'Số Lượng' FROM QLMON"));
            //fillGridBan(new SqlCommand("SELECT MABAN AS N'Mã Bàn', TENBAN AS N'Tên Bàn', SOLUONG AS N'Số Lượng', GIABAN AS N'Giá Bàn', TINHTRANG AS N'Tình Trạng' FROM QLBAN"));
            SqlCommand command = new SqlCommand(" SELECT MABAN as N'Mã Bàn Ăn', TENBAN as N'Tên Bàn', SOLUONG as N'Số Lượng Khách', GIABAN as N'Giá Bàn', TINHTRANG as N'Tình Trạng' FROM QLBAN", kn.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            SqlCommand commandM = new SqlCommand(" SELECT MABAN as N'Mã Bàn Ăn', TENBAN as N'Tên Bàn', SOLUONG as N'Số Lượng Khách', GIABAN as N'Giá Bàn' FROM QLBAN", kn.GetConnection);
            SqlDataAdapter adapterM = new SqlDataAdapter(commandM);
            DataTable tableM = new DataTable();
            adapterM.Fill(tableM);
            tableM.Columns.Add("Tình Trạng", typeof(string));
            dtgvDSBanTrong.DataSource = tableM;
            dtgvDSBanTrong.AllowUserToAddRows = false;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (Convert.ToInt32(table.Rows[i]["Tình Trạng"].ToString()) == 0)
                {
                    dtgvDSBanTrong.Rows[i].Cells["Tình Trạng"].Value = "Trống";
                }
                else if (Convert.ToInt32(table.Rows[i]["Tình Trạng"].ToString()) == 1)
                {
                    dtgvDSBanTrong.Rows[i].Cells["Tình Trạng"].Value = "Đã Được Đặt";
                }
            }
        }

        private void dtgvDSBanTrong_DoubleClick(object sender, EventArgs e)
        {
            string idBan = dtgvDSBanTrong.CurrentRow.Cells[0].Value.ToString();
            frmOrder oder = new frmOrder(idBan);
            oder.Show();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            frmTinhTien frmTinhTien = new frmTinhTien();
            frmTinhTien.Show(this);
            
        }
    }
}
