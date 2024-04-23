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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        string user;
        public frmOrder(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        QLBANAN banan = new QLBANAN();
        HOADON hoadon = new HOADON();
        DOANHTHU doanhthu = new DOANHTHU();
        KetNoi kn = new KetNoi();
        QLMONAN monan = new QLMONAN();
        public void fillGrid(SqlCommand command)
        {

            dtgvHienThi.ReadOnly = true;
            dtgvHienThi.DataSource = hoadon.getHoaDon(command);
            dtgvHienThi.AllowUserToAddRows = false;
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            txtMaBan.Text = user;
            txtMaBan.Enabled = false;
            txtGiaThanh.Enabled = false;
            //lay thong tin tenmon
            cboMon.DataSource = hoadon.getHoaDon(new SqlCommand("SELECT * FROM QLMON"));
            cboMon.DisplayMember = "TENMON";
            cboMon.ValueMember = "MAMON";

            fillGrid(new SqlCommand("SELECT MABAN AS N'Mã Bàn', TENMON  AS N'Tên Món', SOLUONG AS N'Số Lượng', GIATHANH AS N'Giá Thành', NGAYLAP AS N'Thời Gian Lập' FROM HOADON WHERE MABAN = '" + user + "'"));
        }
        
        private void dtgvHienThi_DoubleClick(object sender, EventArgs e)
        {
            txtMaBan.Text = dtgvHienThi.CurrentRow.Cells[0].Value.ToString();
            cboMon.Text = dtgvHienThi.CurrentRow.Cells[1].Value.ToString();
            txtSL.Text = dtgvHienThi.CurrentRow.Cells[2].Value.ToString();
            txtGiaThanh.Text = dtgvHienThi.CurrentRow.Cells[3].Value.ToString();
            dtpNgay.Text = dtgvHienThi.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            int MonSelect = Convert.ToInt32(this.cboMon.SelectedIndex.ToString().Trim());
            SqlCommand command = new SqlCommand("SELECT * FROM QLMON", kn.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            double Price = Convert.ToDouble(table.Rows[MonSelect]["GIABAN"].ToString().Trim());
            if (txtSL.Text.Trim() != "")
            {
                int sl = Convert.ToInt32(txtSL.Text.Trim());
                txtGiaThanh.Text = Convert.ToString(sl * Price);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                string tenmon = cboMon.Text.Trim();

                SqlCommand command = new SqlCommand("SELECT TENMON,SOLUONG FROM QLMON WHERE TENMON = N'" + tenmon + "'", kn.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                int sl = Convert.ToInt32(table.Rows[0][1].ToString());
                int slcheck = Convert.ToInt32(table.Rows[0][1].ToString()) - Convert.ToInt32(txtSL.Text);

                if (sl <= 0)
                {
                    MessageBox.Show("Món Ăn Này Tạm Hết Số Lượng Bán Trong Ngày. Bạn Vui Lòng Oder Món Khác");
                }
                else if (slcheck < 0)
                {
                    MessageBox.Show("Món Ăn Này Không Đủ Số Lượng Để Bạn Oder. Nhà Hàng Chỉ Còn " + sl + " Phần. Bạn Có Thể Oder Số Lượng Khác Hoặc Vui Lòng Gọi Món Mới");
                }
                else
                {
                    string mahoadon = txtMaHoaDon.Text;
                    string madoanhthu = txtMaHoaDon.Text;
                    string idban = txtMaBan.Text;
                    string tenmonhd = cboMon.Text.Trim();
                    int soluong = Convert.ToInt32(txtSL.Text);
                    int giathanh= Convert.ToInt32(txtGiaThanh.Text);
                    DateTime thoigian = dtpNgay.Value;

                    if (hoadon.insertHoaDon(mahoadon,idban, tenmonhd, soluong, giathanh, thoigian))
                    {
                        doanhthu.insertDoanhThu(madoanhthu,user, tenmonhd, soluong, giathanh, thoigian);
                        monan.updateSLMonAn(tenmon, slcheck);
                        banan.updateBanAnTrong(user, 1);
                        MessageBox.Show("Đã Oder", " Oder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Oder Not Inserted", "Add Oder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    fillGrid(new SqlCommand("SELECT MABAN as N'Mã Bàn Ăn', TENMON as N'Tên Món', SOLUONG as N'Số Lượng Món', GIATHANH as N'Giá Tổng', NGAYLAP as N'Thời Gian' FROM HOADON WHERE MABAN = '" + user + "'"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Oder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cboMon.Text = "";
            txtGiaThanh.Text = "";
            txtSL.Text = "";

            /*
            string name = txtMaBan.Text;
            SqlCommand command1 = new SqlCommand(" SELECT MABAN as N'Mã Bàn Ăn', TENMON as N'Tên Món', SOLUONG as N'Số Lượng Món', GIATHANH as N'Giá Tổng', NGAYLAP as N'Thời Gian' FROM HOADON WHERE MABAN = '" + name + "'", kn.GetConnection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            /*
            int tien = 0;
            SqlCommand commandban = new SqlCommand(" SELECT MABAN, GIABAN FROM QLBAN WHERE MABAN = '" + name + "'", kn.GetConnection);
            SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
            DataTable tableban = new DataTable();
            adapterban.Fill(tableban);            
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                int giathanh;
                if (int.TryParse(table1.Rows[i]["Giá Tổng"].ToString(), out giathanh))
                {
                    tien += giathanh;
                }
            }

            lblTongTien.Text = "Tổng Tiền Thanh Toán (Đã Tính Tiền Bàn) Là: " + (int.TryParse(tableban.Rows[0]["GIABAN"].ToString()) + tien);
            */
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string mahoadon = txtMaHoaDon.Text;
                string madoanhthu = txtMaHoaDon.Text;
                string idban = txtMaBan.Text;
                string tenmonhd = cboMon.Text.Trim();
                int soluong = Convert.ToInt32(txtSL.Text);
                int giathanh = Convert.ToInt32(txtGiaThanh.Text);
                DateTime thoigian = dtpNgay.Value;
                if (hoadon.updateHoaDon(mahoadon,idban,tenmonhd, soluong, giathanh, thoigian))
                {
                    doanhthu.updateDoanhThu(madoanhthu,tenmonhd, soluong, giathanh, thoigian);
                    MessageBox.Show("Món ăn đã được sửa", "Sửa món ăn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("a", "b", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sửa món ăn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            fillGrid(new SqlCommand("SELECT MABAN AS N'Mã Bàn', TENMON AS N'Tên Món', SOLUONG AS N'Số Lượng', GIATHANH AS N'Giá Thành', NGAYLAP AS N'Thời Gian' FROM HOADON WHERE MABAN = '" + user + "'"));

            cboMon.Text = "";
            txtSL.Text = "";
            txtGiaThanh.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string tenm = cboMon.Text;
                if (MessageBox.Show("Are You Sure You Want To Remove This Mon An", "Delete Mon An", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (hoadon.deleteMonAn(tenm))
                    {
                        doanhthu.deleteMonAn(tenm);
                        for (int i = 0; i < dtgvHienThi.Rows.Count; i++)
                        {
                            int k = Convert.ToInt32(dtgvHienThi.Rows[i].Cells[2].Value);
                            string name = dtgvHienThi.Rows[i].Cells[1].Value.ToString().Trim();
                            SqlCommand command = new SqlCommand("SELECT TENMON,SOLUONG FROM QLMON WHERE TENMON = '" + name + "'", kn.GetConnection);
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            int sl = Convert.ToInt32(table.Rows[0][1].ToString());
                            monan.updateSLMonAn(name, sl + k);
                        }
                        MessageBox.Show("Mon An Delete", "Remove Mon An", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mon An Not Delete", "Remove Mon An", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Remove Mon An", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid(new SqlCommand("SELECT MABAN AS N'Mã Bàn', TENMON AS N'Tên Món', SOLUONG AS N'Số Lượng', GIATHANH AS N'Giá Thành', NGAYLAP AS N'Thời Gian' FROM HOADON WHERE MABAN = '" + user + "'"));

            cboMon.Text = "";
            txtSL.Text = "";
            txtGiaThanh.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            /*
            string idban = txtMaBan.Text;
            if (MessageBox.Show("Are You Sure You Want To Remove This Mon An", "Delete Mon An", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hoadon.deleteHoaDon(idban);
                doanhthu.deleteHoaDon(idban);
                banan.updateBanAnTrong(user, 1);
                for (int i = 0; i < dtgvHienThi.Rows.Count; i++)
                {
                    int k = Convert.ToInt32(dtgvHienThi.Rows[i].Cells[2].Value);
                    string name = dtgvHienThi.Rows[i].Cells[1].Value.ToString().Trim();
                    SqlCommand command = new SqlCommand("SELECT TENMON,SOLUONG FROM QLMON WHERE TENMON = '" + name + "'", kn.GetConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    int sl = Convert.ToInt32(table.Rows[0][1].ToString());
                    monan.updateSLMonAn(name, sl + k);
                }
                MessageBox.Show("Mon An Delete", "Remove Mon An", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblTongTien.Text = "";
            fillGrid(new SqlCommand("SELECT MABAN AS N'Mã Bàn', TENMON AS N'Tên Món', SOLUONG AS N'Số Lượng', GIATHANH AS N'Giá Thành', NGAYLAP AS N'Thời Gian' FROM HOADON WHERE MABAN = '" + user + "'"));
            */
        }
    }
}
