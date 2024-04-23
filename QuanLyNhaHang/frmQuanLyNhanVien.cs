using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using Image = System.Drawing.Image;
using Microsoft.Office.Interop.Word;
namespace QuanLyNhaHang
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        KetNoi kn=new KetNoi();
        NHANVIEN nhanvien = new NHANVIEN();
        public void fillGrid(SqlCommand command)
        {
            dtgvDSNV.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dtgvDSNV.RowTemplate.Height = 80;
            dtgvDSNV.DataSource = nhanvien.getNhanVien(command);
            // column 7 is the image column index
            picCol = (DataGridViewImageColumn)dtgvDSNV.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtgvDSNV.AllowUserToAddRows = false;
        }
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT NHANVIEN.MANV as N'Mã Số NV',NHANVIEN.USERNAME as N'Tài Khoản',NHANVIEN.PASSWORDS as N'Mật Khẩu' ,NHANVIEN.HOTEN as N'Họ Tên', NHANVIEN.BDAY as N'Ngày Sinh', NHANVIEN.GIOITINH as N'Giới Tính', NHANVIEN.DIENTHOAI as N'Số Điện Thoại', NHANVIEN.EMAIL as N'Email', NHANVIEN.ANH as N'Hình Ảnh' " +
                                "FROM NHANVIEN "));
        }

        private void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            string search = txtTimTheoTen.Text;
            if (search.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Thông Tin Tìm Kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "SELECT NhanVien.MANV as N'Mã Số NV', NhanVien.HOTEN as N'Tên', NhanVien.BDAY as N'Ngày Sinh', NhanVien.GIOITINH as N'Giới Tính', NhanVien.DIENTHOAI as N'Số Điện Thoại', NhanVien.EMAIL as N'Email', NhanVien.ANH as N'Hình Ảnh' " +
                    "FROM NHANVIEN WHERE NhanVien.HOTEN LIKE '%" + txtTimTheoTen.Text + "%' OR NhanVien.MANV LIKE '%" + txtTimTheoTen.Text + "%'";
                SqlCommand command = new SqlCommand(query);
                fillGrid(command);
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int magv;
                bool isNumeric = int.TryParse(txtMaNV.Text, out magv);
                if (isNumeric)
                {
                    magv = Convert.ToInt32(txtMaNV.Text);
                    //check mssv
                    kn.openConnection();
                    string checkMSSVSql = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV=@ma";
                    SqlCommand checkMSSVCommand = new SqlCommand(checkMSSVSql,kn.GetConnection);
                    checkMSSVCommand.Parameters.AddWithValue("@ma", magv);
                    int mssvCount = (int)checkMSSVCommand.ExecuteScalar();
                    if (mssvCount > 0)
                    {
                        MessageBox.Show("Mã MaGV trùng");
                        txtMaNV.Focus();
                    }
                    kn.closeConnection();
                }
                else
                {
                    MessageBox.Show("Đầu vào phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNV.Focus();
                }
                string user=txtTK.Text;
                string pass=txtMK.Text;
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
                    if (nhanvien.insertNhanVien(magv,user,pass ,name, bdate, gender, phone,email, pic))
                    {
                        MessageBox.Show("Nhân Viên đã được thêm", "Thêm NV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT NHANVIEN.MANV as N'Mã Số NV',NHANVIEN.USERNAME as N'Tài Khoản',NHANVIEN.PASSWORDS as N'Mật Khẩu' ,NHANVIEN.HOTEN as N'Họ Tên', NHANVIEN.BDAY as N'Ngày Sinh', NHANVIEN.GIOITINH as N'Giới Tính', NHANVIEN.DIENTHOAI as N'Số Điện Thoại', NHANVIEN.EMAIL as N'Email', NHANVIEN.ANH as N'Hình Ảnh' " +
                                "FROM NHANVIEN "));
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
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    picAnh.Image = Image.FromFile(opf.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvDSNV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtMaNV.Text = dtgvDSNV.CurrentRow.Cells[0].Value.ToString();
                txtTK.Text = dtgvDSNV.CurrentRow.Cells[1].Value.ToString();
                txtMK.Text = dtgvDSNV.CurrentRow.Cells[2].Value.ToString();
                txtHoTen.Text = dtgvDSNV.CurrentRow.Cells[3].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dtgvDSNV.CurrentRow.Cells[4].Value;
                if (dtgvDSNV.CurrentRow.Cells[5].Value.ToString().Trim() == "Nam")
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }
                txtSDT.Text = dtgvDSNV.CurrentRow.Cells[6].Value.ToString();
                txtEmail.Text = dtgvDSNV.CurrentRow.Cells[7].Value.ToString();

                byte[] pic;
                pic = (byte[])dtgvDSNV.CurrentRow.Cells[8].Value;
                MemoryStream picture = new MemoryStream(pic);
                picAnh.Image = System.Drawing.Image.FromStream(picture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                        fillGrid(new SqlCommand("SELECT NHANVIEN.MANV as N'Mã Số NV',NHANVIEN.USERNAME as N'Tài Khoản',NHANVIEN.PASSWORDS as N'Mật Khẩu' ,NHANVIEN.HOTEN as N'Họ Tên', NHANVIEN.BDAY as N'Ngày Sinh', NHANVIEN.GIOITINH as N'Giới Tính', NHANVIEN.DIENTHOAI as N'Số Điện Thoại', NHANVIEN.EMAIL as N'Email', NHANVIEN.ANH as N'Hình Ảnh' " +
                                "FROM NHANVIEN "));
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                nhanvien.deleteNhanVien(txtMaNV.Text);
                MessageBox.Show("Xóa thành công");
                fillGrid(new SqlCommand("SELECT NHANVIEN.MANV as N'Mã Số NV',NHANVIEN.USERNAME as N'Tài Khoản',NHANVIEN.PASSWORDS as N'Mật Khẩu' ,NHANVIEN.HOTEN as N'Họ Tên', NHANVIEN.BDAY as N'Ngày Sinh', NHANVIEN.GIOITINH as N'Giới Tính', NHANVIEN.DIENTHOAI as N'Số Điện Thoại', NHANVIEN.EMAIL as N'Email', NHANVIEN.ANH as N'Hình Ảnh' " +
                            "FROM NHANVIEN "));
                txtMaNV.Clear();
                txtTK.Clear();
                txtMK.Clear();
                txtHoTen.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
                picAnh.Enabled = true;
                rbtnNu.Enabled = true;
                rbtnNam.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintDialog pDlg = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.DocumentName = "Print Document";
            pDlg.Document = pDoc;
            pDlg.AllowSelection = true;
            pDlg.AllowSomePages = true;
            pDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            if (pDlg.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = pDoc;
                printPreviewDialog1.ShowDialog();
                pDoc.Print();
            }
            else
            {
                MessageBox.Show("Ðã huy in");
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string str = "";
            int row = dtgvDSNV.Rows.Count;
            int cell = dtgvDSNV.Rows[1].Cells.Count;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cell; j++)
                {
                    if (dtgvDSNV.Rows[i].Cells[j].Value == null)
                    {
                        dtgvDSNV.Rows[i].Cells[j].Value = "null";
                    }
                    str += dtgvDSNV.Rows[i].Cells[j].Value.ToString().Trim() + " , ";
                }
                str += "\n";
            }

            e.Graphics.DrawString(str, new System.Drawing.Font("Arial", 30), Brushes.Black, new System.Drawing.Point(10, 10));
        }

        private void btnInWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word Document|*.docx";
            saveFileDialog1.Title = "Save Word Document";
            saveFileDialog1.ShowDialog();
            // Tạo đường dẫn đến word
            _Application oWord = new Microsoft.Office.Interop.Word.Application();
            //Tạo một Document
            _Document wordDoc = oWord.Documents.Add();
            int ColumnCount = dtgvDSNV.Columns.Count;
            object missing = System.Reflection.Missing.Value;
            Paragraph para1 = wordDoc.Content.Paragraphs.Add(ref missing);
            string time = "Ngày " + DateTime.Today.Day.ToString("00") + " Tháng " + DateTime.Today.Month.ToString("00") + " Năm "
                + DateTime.Today.Year.ToString("0000");
            foreach (Microsoft.Office.Interop.Word.Section section in wordDoc.Sections)
            {
                //Get the header range and add the header details.
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdRed;
                headerRange.Font.Size = 16;
                headerRange.Text = "DANH SÁCH NHÂN VIÊN\n" + time;



                Range footersRange = section.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footersRange.Fields.Add(footersRange, WdFieldType.wdFieldPage);
                footersRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                footersRange.Font.ColorIndex = WdColorIndex.wdBlack;   // Màu
                footersRange.Font.Bold = 2;        // Độ Đậm Chữ
                footersRange.Font.Size = 16;
                footersRange.Text = "TP.HCM, " + time;


                section.Borders.Enable = 1;
                section.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                section.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth300pt;
                section.Borders.OutsideColor = WdColor.wdColorBlack;

            }

            // Tạo bảng danh sách sinh viên
            Table tableST = wordDoc.Tables.Add(para1.Range, dtgvDSNV.Rows.Count + 1, dtgvDSNV.Columns.Count, ref missing, ref missing);
            //Xuất hiện khung table
            tableST.Borders.Enable = 1;
            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                tableST.Rows[1].Cells[c + 1].Range.Text = dtgvDSNV.Columns[c].HeaderText;
            }
            for (int i = 2; i <= tableST.Rows.Count; i++)
            {

                for (int j = 1; j < tableST.Columns.Count + 1; j++)
                {

                    //Lưu text
                    tableST.Rows[i].Cells[j].Range.Text = dtgvDSNV.Rows[i - 2].Cells[j - 1].Value.ToString();
                    tableST.Rows[i].Cells[j].Range.Font.Bold = 1;
                    tableST.Rows[i].Cells[j].Range.Font.Name = "Times New Roman";

                }
            }
            // Lưu thông tin 
            object filename = saveFileDialog1.FileName;
            wordDoc.SaveAs2(ref filename);
            wordDoc.Close();
            oWord.Quit();
            MessageBox.Show("Lưu File thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnChiaCa_Click(object sender, EventArgs e)
        {
            frmChiaCa frmChiaCa=new frmChiaCa();
            frmChiaCa.ShowDialog();
        }
        LAMVIEC lv=new LAMVIEC();
        private void btnTinhGio_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" SELECT MANV FROM TIMELV", kn.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                lv.updateTimeDayNew(Convert.ToInt32(table.Rows[i][0].ToString()));
            }
            MessageBox.Show("Đã Resest Thời Gian Làm Việc Cho Ngày Mới");
        }
    }
}
