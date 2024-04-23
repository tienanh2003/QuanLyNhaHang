using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaHang
{
    public partial class frmThongTinNhanVien : Form
    {
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }
        string user;
        public frmThongTinNhanVien(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        KetNoi kn=new KetNoi();
        NHANVIEN nhanvien= new NHANVIEN();
        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            string tk = user;
            SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN WHERE USERNAME = @username", kn.GetConnection);
            command.Parameters.AddWithValue("@username", tk);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            try
            {
                if (table.Rows.Count > 0)
                {
                    txtMaNV.Text = table.Rows[0]["MANV"].ToString();
                    txtTK.Text = table.Rows[0]["USERNAME"].ToString();
                    txtMK.Text = table.Rows[0]["PASSWORDS"].ToString();
                    txtHoTen.Text = table.Rows[0]["HOTEN"].ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(table.Rows[0]["BDAY"]);
                    if (table.Rows[0]["GIOITINH"].ToString().Trim() == "Nam")
                    {
                        rbtnNam.Checked = true;
                    }
                    else
                    {
                        rbtnNu.Checked = true;
                    }
                    txtSDT.Text = table.Rows[0]["DIENTHOAI"].ToString();
                    txtEmail.Text = table.Rows[0]["EMAIL"].ToString();

                    byte[] pic = (byte[])table.Rows[0]["ANH"];
                    MemoryStream picture = new MemoryStream(pic);
                    picAnh.Image = System.Drawing.Image.FromStream(picture);
                }
                else
                {
                    // Người dùng không tồn tại trong bảng NHANVIEN
                    MessageBox.Show("Không tìm thấy thông tin người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        bool verif()
        {
            if ((txtMaNV.Text.Trim() == "")
                || (txtHoTen.Text.Trim() == "")
                || (txtTK.Text.Trim() == "")
                || (txtMK.Text.Trim() == "")
                || (txtSDT.Text.Trim() == "")
                || (txtEmail.Text.Trim() == "")
                || (picAnh.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkName(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z\\sàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđĐ]{1,20}$");
        }

        public bool CheckEmail(string em)//check email (\w giong voi a-zA-Z0-9_)
        {
            return Regex.IsMatch(em, @"^[\w.]{3,20}@gmail.com(.vn|)$");
        }
        public bool checkPhone(string ac)//check phone
        {
            return Regex.IsMatch(ac, "^[0-9]{9,12}$");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int magv;
                bool isNumeric = int.TryParse(txtMaNV.Text, out magv);
                if (isNumeric)
                {
                    magv = Convert.ToInt32(txtMaNV.Text);
                }
                else
                {
                    MessageBox.Show("Đầu vào phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNV.Focus();
                }
                string user = txtTK.Text;
                string pass = txtMK.Text;
                string name = txtHoTen.Text;
                if (!checkName(name))
                {
                    MessageBox.Show("Vui lòng nhập tên hợp lệ!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DateTime bdate = dtpNgaySinh.Value;
                string gender = "";
                if (rbtnNu.Checked)
                {
                    gender = "Nữ";
                }
                if (rbtnNam.Checked)
                {
                    gender = "Nam";
                }
                if (!rbtnNam.Checked && !rbtnNu.Checked)
                {
                    MessageBox.Show("Bạn chưa chọn giới tính");
                }
                string phone = txtSDT.Text;
                if (!checkPhone(phone))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng sdt!", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string email = txtEmail.Text;
                if (!CheckEmail(email))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng email", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MemoryStream pic = new MemoryStream();
                int born_year = dtpNgaySinh.Value.Year;
                int now_year = DateTime.Now.Year;
                if ((now_year - born_year) < 10 || (now_year - born_year) > 100)
                {
                    MessageBox.Show("Tuổi học sinh phải từ 10-100", "Ngày tháng năm sinh không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    picAnh.Image.Save(pic, picAnh.Image.RawFormat);
                    if (nhanvien.updateNhanVien(magv, user, pass, name, bdate, gender, phone, email, pic))
                    {
                        MessageBox.Show("Nhân Viên đã được thêm", "Thêm NV", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thêm NV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picAnh.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text!=user)
            {
                MessageBox.Show("Bạn Không Có Quyền Edit ID Staff Khác", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string nv = txtMaNV.Text;
                    //string TenNV = 
                    if ((MessageBox.Show("Bạn có muốn xóa Nhân Viên này!!!", "Xóa Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        if (nhanvien.deleteNhanVien(nv))
                        {
                            nhanvien.deleteChiaCa(nv);
                            nhanvien.deleteLuongNV(nv);
                            nhanvien.deleteTimeLV(nv);
                            MessageBox.Show("Xóa Nhân Viên", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMaNV.Text = "";
                            txtTK.Text = "";
                            txtMK.Text = "";
                            txtHoTen.Text = "";
                            dtpNgaySinh.Value = DateTime.Now;
                            rbtnNam.Checked = false;
                            rbtnNu.Checked = false;
                            picAnh.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("Không xóa nhân viên được", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Nhập tên Nhân Viên", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            MessageBox.Show("Bạn Đã Hết Quyền Truy Cập, Mời Bạn Logout", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
