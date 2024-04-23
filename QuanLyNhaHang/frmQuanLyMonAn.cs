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

namespace QuanLyNhaHang
{
    public partial class frmQuanLyMonAn : Form
    {
        public frmQuanLyMonAn()
        {
            InitializeComponent();
        }
        QLMONAN monan = new QLMONAN();
        public void fillGrid(SqlCommand command)
        {

            dtgvDSMon.ReadOnly = true;

            dtgvDSMon.RowTemplate.Height = 80;
            dtgvDSMon.DataSource = monan.getMonAn(command);


            dtgvDSMon.AllowUserToAddRows = false;

            // show the total students depending on dgv
            lblHienThi.Text = "So Mon An: " + dtgvDSMon.Rows.Count;
        }
        private void frmQuanLyMonAn_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT MAMON as N'Mã Món Ăn', TENMON as N'Tên Món', GIABAN as N'Giá Món',SOLUONG as N'Số Lượng' FROM QLMON"));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtMaMon.Text;
                //int id = Convert.ToInt32(textBoxCourseID.Text);
                string ten = txtTenMon.Text;
                string giaban=txtDonGia.Text;
                int soluong = Convert.ToInt32(txtSoLuong.Text);
                if (ten.Trim() == "")
                {
                    MessageBox.Show("Thêm tên món", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (monan.checkTenMonAn(ten))
                {
                    if (monan.insertMonAn(id, ten, giaban,soluong))
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
                    MessageBox.Show("Tên đã tồn tại", "Thêm món", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            fillGrid(new SqlCommand("SELECT MAMON as N'Mã Món Ăn', TENMON as N'Tên Món', GIABAN as N'Giá Món',SOLUONG as N'Số Lượng' FROM QLMON"));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string tenban = txtTenMon.Text;
                if (MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (monan.deleteMonAn(tenban))
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
            fillGrid(new SqlCommand("SELECT MAMON as N'Mã Món Ăn', TENMON as N'Tên Món', GIABAN as N'Giá Món',SOLUONG as N'Số Lượng' FROM QLMON"));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //int Idbanan = Convert.ToInt32(TextBoxSL.Text);
                string ten = txtTenMon.Text;
                string giaban = txtDonGia.Text;
                int soluong = Convert.ToInt32(txtSoLuong.Text);
                if (monan.updateMonAn(ten, giaban, soluong))
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
            fillGrid(new SqlCommand("SELECT MAMON as N'Mã Món Ăn', TENMON as N'Tên Món', GIABAN as N'Giá Món',SOLUONG as N'Số Lượng' FROM QLMON"));
        }

        private void btnTimTheoMa_Click(object sender, EventArgs e)
        {
            string search = txtTimTheoMa.Text;
            if (search.Trim() == "")
            {
                MessageBox.Show("Nhập Mã Tên", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT MAMON as N'Mã Món Ăn', TENMON as N'Tên Món', GIABAN as N'Giá Món',SOLUONG as N'Số Lượng' FROM QLMON WHERE CONCAT(MAMON,TENMON) LIKE '%" + txtTimTheoMa.Text + "%'");
                fillGrid(command);
                txtMaMon.Text = dtgvDSMon.CurrentRow.Cells[0].Value.ToString();
                txtTenMon.Text = dtgvDSMon.CurrentRow.Cells[1].Value.ToString();
                txtDonGia.Text = dtgvDSMon.CurrentRow.Cells[2].Value.ToString();
                txtSoLuong.Text = dtgvDSMon.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void dtgvDSMon_DoubleClick(object sender, EventArgs e)
        {
            txtMaMon.Text = dtgvDSMon.CurrentRow.Cells[0].Value.ToString();
            txtTenMon.Text = dtgvDSMon.CurrentRow.Cells[1].Value.ToString();
            txtDonGia.Text = dtgvDSMon.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dtgvDSMon.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnQuanLyKho_Click(object sender, EventArgs e)
        {
            frmQuanLyKho frmQuanLyKho = new frmQuanLyKho();
            frmQuanLyKho.ShowDialog();
        }
    }
}
