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

namespace QuanLyNhaHang
{
    public partial class frmQuanLyKho : Form
    {
        public frmQuanLyKho()
        {
            InitializeComponent();
        }
        HOADON hd=new HOADON();
        QLMONAN monan=new QLMONAN();
        public void fillGrid(SqlCommand command)
        {

            dtgvDSMon.ReadOnly = true;

            dtgvDSMon.RowTemplate.Height = 80;
            dtgvDSMon.DataSource = monan.getMonAn(command);


            dtgvDSMon.AllowUserToAddRows = false;

            // show the total students depending on dgv
            lblHienThi.Text = "So Mon An: " + dtgvDSMon.Rows.Count;
        }
        private void frmQuanLyKho_Load(object sender, EventArgs e)
        {
            cboMonAn.DataSource = hd.getHoaDon(new SqlCommand("SELECT * FROM QLMON"));
            cboMonAn.DisplayMember = "TENMON";
            cboMonAn.ValueMember = "MAMON";
            fillGrid(new SqlCommand("SELECT MAMON as N'Mã Món Ăn', TENMON as N'Tên Món', GIABAN as N'Giá Món',SOLUONG as N'Số Lượng' FROM QLMON"));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMonAn.Text.Trim() == "Thịt Heo Chiên")
            {
                lblKiemTra.Text = "Mỗi Phần thịt Heo Chiên Được Làm Từ: Thịt-100g ,Rau-10g,Sốt-5g ";
            }
            else if (cboMonAn.Text.Trim() == "Bò Nướng")
            {
                lblKiemTra.Text = "Mỗi Phần Bò Nướng Được Làm Từ: Thịt-100g ,Rau-5g,Sốt-5g";
            }
            else if (cboMonAn.Text.Trim() == "Cá Chiên")
            {
                lblKiemTra.Text = "Mỗi Phần Cá Chiên Được Làm Từ: Cá-100g ,Rau-1g,Sốt-5g";
            }
            else
            {
                lblKiemTra.Text = "Mỗi Phần " + cboMonAn.Text.Trim() + " Được Làm Từ: TP Chính-100g ,Rau-5g,TP Phụ-5g";
            }
        }
        public int TimMin(int a, int b, int c)
        {
            int min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            return min;
        }
        int sl = 0;
        private void btnKTra_Click(object sender, EventArgs e)
        {
            if (txtTPPhu.Text == "" || txtTPChinh.Text == "" || txtRau.Text == "")
            {
                MessageBox.Show("Không Thể Để Trống Dữ Liệu Input Kiểm Tra");
            }
            else if (txtRau.Text != "" && txtTPChinh.Text != "" && txtRau.Text != "")
            {
                if (cboMonAn.Text.Trim() == "Pho")
                {
                    if (Convert.ToInt32(txtRau.Text) < 10 || Convert.ToInt32(txtTPPhu.Text) < 5 || Convert.ToInt32(txtTPChinh.Text) < 100)
                    {
                        lblKiemTra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện Phần Ăn " + cboMonAn.Text.Trim();
                    }
                    else if (Convert.ToInt32(txtRau.Text) >= 10 && Convert.ToInt32(txtTPPhu.Text) >= 20 && Convert.ToInt32(txtTPChinh.Text) >= 100)
                    {
                        int slrau = Convert.ToInt32(txtRau.Text) / 10;
                        int sltinhbot = Convert.ToInt32(txtTPPhu.Text) / 5;
                        int slthit = Convert.ToInt32(txtTPChinh.Text) / 100;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        lblKiemTra.Text = "Ta Có Thể Tạo Ra " + kq + " Phần " + cboMonAn.Text.Trim();
                        sl = kq;
                    }
                }
                else if (cboMonAn.Text.Trim() == "Bun")
                {
                    if (Convert.ToInt32(txtRau.Text) < 5 || Convert.ToInt32(txtTPPhu.Text) < 5 || Convert.ToInt32(txtTPChinh.Text) < 100)
                    {
                        lblKiemTra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện Phần Ăn " + cboMonAn.Text.Trim();
                    }
                    else if (Convert.ToInt32(txtRau.Text) >= 5 || Convert.ToInt32(txtTPPhu.Text) >= 50 || Convert.ToInt32(txtTPChinh.Text) >= 100)
                    {
                        int slrau = Convert.ToInt32(txtRau.Text) / 5;
                        int sltinhbot = Convert.ToInt32(txtTPPhu.Text) / 5;
                        int slthit = Convert.ToInt32(txtTPChinh.Text) / 100;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        lblKiemTra.Text = "Ta Có Thể Tạo Ra " + kq + " Phần " + cboMonAn.Text.Trim();
                        sl = kq;
                    }
                }
                else if (cboMonAn.Text.Trim() == "Com")
                {
                    if (Convert.ToInt32(txtRau.Text) < 5 || Convert.ToInt32(txtTPPhu.Text) < 1 || Convert.ToInt32(txtTPChinh.Text) < 100)
                    {
                        lblKiemTra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện Phần Ăn " + cboMonAn.Text.Trim();
                    }
                    else if (Convert.ToInt32(txtRau.Text) >= 15 || Convert.ToInt32(txtTPPhu.Text) >= 10 || Convert.ToInt32(txtTPChinh.Text) >= 100)
                    {
                        int slrau = Convert.ToInt32(txtRau.Text) / 5;
                        int sltinhbot = Convert.ToInt32(txtTPPhu.Text) / 1;
                        int slthit = Convert.ToInt32(txtTPChinh.Text) / 20;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        lblKiemTra.Text = "Ta Có Thể Tạo Ra " + kq + " Phần " + cboMonAn.Text.Trim();
                        sl = kq;
                    }
                }
                else if (cboMonAn.Text.Trim() == "Banh mi")
                {
                    if (Convert.ToInt32(txtRau.Text) < 5 || Convert.ToInt32(txtTPPhu.Text) < 1 || Convert.ToInt32(txtTPChinh.Text) < 100)
                    {
                        lblKiemTra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện Phần Ăn " + cboMonAn.Text.Trim();
                    }
                    else if (Convert.ToInt32(txtRau.Text) >= 15 || Convert.ToInt32(txtTPPhu.Text) >= 10 || Convert.ToInt32(txtTPChinh.Text) >= 100)
                    {
                        int slrau = Convert.ToInt32(txtRau.Text) / 5;
                        int sltinhbot = Convert.ToInt32(txtTPPhu.Text) / 1;
                        int slthit = Convert.ToInt32(txtTPChinh.Text) / 20;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        lblKiemTra.Text = "Ta Có Thể Tạo Ra " + kq + " Phần " + cboMonAn.Text.Trim();
                        sl = kq;
                    }
                }
                else if (cboMonAn.Text.Trim() == "Che")
                {
                    if (Convert.ToInt32(txtRau.Text) < 5 || Convert.ToInt32(txtTPPhu.Text) < 1 || Convert.ToInt32(txtTPChinh.Text) < 100)
                    {
                        lblKiemTra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện Phần Ăn " + cboMonAn.Text.Trim();
                    }
                    else if (Convert.ToInt32(txtRau.Text) >= 15 || Convert.ToInt32(txtTPPhu.Text) >= 10 || Convert.ToInt32(txtTPChinh.Text) >= 100)
                    {
                        int slrau = Convert.ToInt32(txtRau.Text) / 5;
                        int sltinhbot = Convert.ToInt32(txtTPPhu.Text) / 1;
                        int slthit = Convert.ToInt32(txtTPChinh.Text) / 20;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        lblKiemTra.Text = "Ta Có Thể Tạo Ra " + kq + " Phần " + cboMonAn.Text.Trim();
                        sl = kq;
                    }
                }
                else
                {
                        lblKiemTra.Text = "Món ăn mới thêm " + cboMonAn.Text.Trim()+"Chưa Thêm Công Thức";                 
                }
              
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            
            try
            {
                string ten = cboMonAn.Text;
                int kt = monan.getSLMon(ten);
                int soluong = sl+kt;               
                if (monan.updateSLMonAn(ten, soluong))
                {
                    MessageBox.Show("Số lượng đã được update", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
