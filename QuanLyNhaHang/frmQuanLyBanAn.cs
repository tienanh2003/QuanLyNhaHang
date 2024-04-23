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
    public partial class frmQuanLyBanAn : Form
    {
        public frmQuanLyBanAn()
        {
            InitializeComponent();
        }
        QLBANAN ban=new QLBANAN();
        KetNoi kn = new KetNoi();
        public void fillGrid(SqlCommand command)
        {
            dtgvDSBan.ReadOnly = true;

            dtgvDSBan.RowTemplate.Height = 80;
            dtgvDSBan.DataSource = ban.getBanAn(command);


            dtgvDSBan.AllowUserToAddRows = false;

            // show the total students depending on dgv
            lblHienThi.Text = "Tổng số bàn: " + dtgvDSBan.Rows.Count;
        }
        private void frmQuanLyBanAn_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT MABAN as N'Mã Bàn Ăn', TENBAN as N'Tên Bàn', SOLUONG as N'Số Lượng Khách', GIABAN as N'Giá Bàn', TINHTRANG as N'Tình Trạng' FROM QLBAN"));
        }
        //Thêm bàn ăn
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtMaBanAn.Text;
                //int id = Convert.ToInt32(textBoxCourseID.Text);
                string tenban = txtTenBanAn.Text;
                int soluong = Convert.ToInt32(txtSoLuong.Text);
                float giaban = Convert.ToInt32(txtDonGia.Text);
                int tinhtrang = Convert.ToInt32(txtTinhTrang.Text);
                if (tenban.Trim() == "")
                {
                    MessageBox.Show("Thêm tên bàn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ban.checkTenBanAn(tenban))
                {
                    if (ban.insertBanAn(id, tenban, soluong, giaban, tinhtrang))
                    {
                        MessageBox.Show("Đã Thêm Mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tên đã tồn tại", "Thêm bàn ăn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            fillGrid(new SqlCommand("SELECT MABAN as N'Mã Bàn Ăn', TENBAN as N'Tên Bàn', SOLUONG as N'Số Lượng Khách', GIABAN as N'Giá Bàn', TINHTRANG as N'Tình Trạng' FROM QLBAN"));
        }
        //tim theo ma-tên
        private void btnTimTheoMa_Click(object sender, EventArgs e)
        {
            string search = txtTimTheoMa.Text;
            if (search.Trim() == "")
            {
                MessageBox.Show("Nhập Mã Tên", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //SqlCommand command = new SqlCommand("SELECT MABAN as N'Mã Bàn Ăn', TENBAN as N'Tên Bàn', SOLUONG as N'Số Lượng Khách', GIABAN as N'Giá Bàn', TINHTRANG as N'Tình Trạng' FROM QLBAN WHERE CONCAT(MABAN,TENBAN) LIKE '%" + txtTimTheoMa.Text + "%'");
                //fillGrid(command);
                //txtMaBanAn.Text= dtgvDSBan.CurrentRow.Cells[0].Value.ToString();
                //txtTenBanAn.Text = dtgvDSBan.CurrentRow.Cells[1].Value.ToString();
                //txtSoLuong.Text = dtgvDSBan.CurrentRow.Cells[2].Value.ToString();
                //txtDonGia.Text = dtgvDSBan.CurrentRow.Cells[3].Value.ToString();
                //txtTinhTrang.Text = dtgvDSBan.CurrentRow.Cells[4].Value.ToString();
                // Sử dụng MABAN để tìm kiếm
                SqlCommand command = new SqlCommand("SELECT MABAN as N'Mã Bàn Ăn', TENBAN as N'Tên Bàn', SOLUONG as N'Số Lượng Khách', GIABAN as N'Giá Bàn', TINHTRANG as N'Tình Trạng' FROM QLBAN WHERE MABAN LIKE @Search", kn.GetConnection);
                command.Parameters.AddWithValue("@Search", "%" + search + "%");
                fillGrid(command);

                if (dtgvDSBan.Rows.Count > 0)
                {
                    txtMaBanAn.Text = dtgvDSBan.CurrentRow.Cells[0].Value.ToString();
                    txtTenBanAn.Text = dtgvDSBan.CurrentRow.Cells[1].Value.ToString();
                    txtSoLuong.Text = dtgvDSBan.CurrentRow.Cells[2].Value.ToString();
                    txtDonGia.Text = dtgvDSBan.CurrentRow.Cells[3].Value.ToString();
                    txtTinhTrang.Text = dtgvDSBan.CurrentRow.Cells[4].Value.ToString();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //int Idbanan = Convert.ToInt32(TextBoxSL.Text);
                string tenban = txtTenBanAn.Text;
                int soluong = Convert.ToInt32(txtSoLuong.Text);
                string giaban=txtDonGia.Text;
                int tinhtrang = Convert.ToInt32(txtTinhTrang.Text);
                if (ban.updateBanAn(tenban, soluong, giaban, tinhtrang))
                {
                    MessageBox.Show("Bàn Ăn đã được update", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            fillGrid(new SqlCommand("SELECT MABAN as N'Mã Bàn Ăn', TENBAN as N'Tên Bàn', SOLUONG as N'Số Lượng Khách', GIABAN as N'Giá Bàn', TINHTRANG as N'Tình Trạng' FROM QLBAN"));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string tenban = txtTenBanAn.Text;
                if (MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ban.deleteBanAn(tenban))
                    {
                        MessageBox.Show("Xóa bàn ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid(new SqlCommand("SELECT MABAN as N'Mã Bàn Ăn', TENBAN as N'Tên Bàn', SOLUONG as N'Số Lượng Khách', GIABAN as N'Giá Bàn', TINHTRANG as N'Tình Trạng' FROM QLBAN"));
        }

        private void dtgvDSBan_DoubleClick(object sender, EventArgs e)
        {
            txtMaBanAn.Text = dtgvDSBan.CurrentRow.Cells[0].Value.ToString();
            txtTenBanAn.Text = dtgvDSBan.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dtgvDSBan.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dtgvDSBan.CurrentRow.Cells[3].Value.ToString();
            txtTinhTrang.Text = dtgvDSBan.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
