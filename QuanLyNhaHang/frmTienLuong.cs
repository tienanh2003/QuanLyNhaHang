using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmTienLuong : Form
    {
        public frmTienLuong()
        {
            InitializeComponent();
        }
        string user;
        public frmTienLuong(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        KetNoi kn=new KetNoi();
        LAMVIEC idl = new LAMVIEC();
        private int GetMaNhanVienFromUsername(string username)
        {
            int maNhanVien = 0;
            SqlCommand command = new SqlCommand("SELECT MANV FROM NHANVIEN WHERE USERNAME = @Username", kn.GetConnection);
            command.Parameters.AddWithValue("@Username", username);
            kn.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                maNhanVien = Convert.ToInt32(reader["MANV"]);
            }
            reader.Close();
            kn.closeConnection();
            return maNhanVien;
        }

        private void frmTienLuong_Load(object sender, EventArgs e)
        {
            int employeeId = GetMaNhanVienFromUsername(user);
            UpdateLuong(employeeId);
            if (TotalTimeLamViec() >= 7)
            {
                MessageBox.Show("Hôm Nay Bạn Đã Làm Đủ " + Convert.ToDouble(TotalTimeLamViec().ToString()) + " Tiếng Nên Sẽ Được Tính Lương!");
                lblLuong.Text = "Lương Hôm Nay Của Bạn Là: " + TinhTien();
                //MessageBox.Show("Lương Hôm Nay Của Bạn Là: " + TinhTien());
            }
            else
            {
                MessageBox.Show("Hôm Nay Bạn Chưa Làm Đủ Thời Gian. Chỉ " + Math.Abs(Convert.ToDouble(TotalTimeLamViec().ToString())) + " Giờ. Như Vậy Bạn Thiếu " + (8 - Math.Abs(Convert.ToDouble(TotalTimeLamViec().ToString()))) + " Giờ Nên Sẽ Tính Lương Nhưng Trừ 100.000 Mỗi Giờ Thiếu!");
                lblLuong.Text = "Lương Hôm Nay Của Bạn Là: " + TinhTien();
            }
            int name = GetMaNhanVienFromUsername(user);
            SqlCommand command = new SqlCommand(" SELECT * FROM LUONGNV WHERE MANV = '" + name + "'", kn.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            dtgvHienThi.DataSource = table;
            dtgvHienThi.AllowUserToAddRows = false;
        }
        public double TotalTimeLamViec()
        {
            int name = GetMaNhanVienFromUsername(user);
            SqlCommand command = new SqlCommand(" SELECT * FROM TIMELV WHERE MANV = '" + name + "'", kn.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            Double TotalTime1 = 0;
            Double TotalTime2 = 0;
            Double TotalTime3 = 0;

            if (table.Rows[0]["TIMESTAR1"].ToString().Trim() != "" && table.Rows[0]["TIMEEND1"].ToString().Trim() != "")
            {
                DateTime t1 = Convert.ToDateTime(table.Rows[0]["TIMESTAR1"].ToString().Trim());
                DateTime t2 = Convert.ToDateTime(table.Rows[0]["TIMEEND1"].ToString().Trim());
                TimeSpan ts = t1.Subtract(t2);
                TotalTime1 = Convert.ToDouble(ts.TotalHours.ToString());
            }
            if (table.Rows[0]["TIMESTAR2"].ToString().Trim() != "" && table.Rows[0]["TIMEEND2"].ToString().Trim() != "")
            {
                DateTime t1 = Convert.ToDateTime(table.Rows[0]["TIMESTAR2"].ToString().Trim());
                DateTime t2 = Convert.ToDateTime(table.Rows[0]["TIMEEND2"].ToString().Trim());
                TimeSpan ts = t1.Subtract(t2);
                TotalTime2 = Convert.ToDouble(ts.TotalHours.ToString());
            }
            if (table.Rows[0]["TIMESTAR3"].ToString().Trim() != "" && table.Rows[0]["TIMEEND3"].ToString().Trim() != "")
            {
                DateTime t1 = Convert.ToDateTime(table.Rows[0]["TIMESTAR3"].ToString().Trim());
                DateTime t2 = Convert.ToDateTime(table.Rows[0]["TIMEEND3"].ToString().Trim());
                TimeSpan ts = t1.Subtract(t2);
                TotalTime3 = Convert.ToDouble(ts.TotalHours.ToString());
            }
            return TotalTime1 + TotalTime2 + TotalTime3;
        }

        public int TinhTien()
        {
            int LuongMacDinh = 0;
            int i = Convert.ToInt32(TotalTimeLamViec());
            if (i > 8)
            {
                int x = i - 8;
                LuongMacDinh = 400000 + 50000 * x;
            }
            if (i < 8)
            {
                int x = 8 - i;
                LuongMacDinh = 400000 - 100000 * x;
            }
            if (LuongMacDinh < 0)
                LuongMacDinh = 0;
            return LuongMacDinh;
        }

        public void UpdateLuong(int employeeId)
        {
            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
            int kk = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, dd, kk);
            string dayOfWeek = dt.DayOfWeek.ToString().Trim();

            int totalHours = (int)TotalTimeLamViec();
            int salaryRate = 50000; // Adjust this value as needed
            int salary = 400000; // Default base salary

            if (totalHours > 8)
            {
                int extraHours = totalHours - 8;
                salary += extraHours * salaryRate;
            }
            else if (totalHours < 8)
            {
                int missingHours = 8 - totalHours;
                salary -= missingHours * salaryRate;
            }

            if (salary < 0)
                salary = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                    idl.updateLuongThu2(employeeId, salary);
                    break;
                case "Tuesday":
                    idl.updateLuongThu3(employeeId, salary);
                    break;
                case "Wednesday":
                    idl.updateLuongThu4(employeeId, salary);
                    break;
                case "Thursday":
                    idl.updateLuongThu5(employeeId, salary);
                    break;
                case "Friday":
                    idl.updateLuongThu6(employeeId, salary);
                    break;
                case "Saturday":
                    idl.updateLuongThu7(employeeId, salary);
                    break;
                case "Sunday":
                    idl.updateLuongCN(employeeId, salary);
                    break;
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            // Tạo đường dẫn đến word
            _Application oWord = new Microsoft.Office.Interop.Word.Application();
            //Tạo một Document
            _Document wordDoc = oWord.Documents.Add();
            int ColumnCount = dtgvHienThi.Columns.Count;
            object missing = System.Reflection.Missing.Value;
            Paragraph para1 = wordDoc.Content.Paragraphs.Add(ref missing);
            string time = "Ngày " + DateTime.Today.Day.ToString("00") + " Tháng " + DateTime.Today.Month.ToString("00") + " Năm "
                + DateTime.Today.Year.ToString("0000");
            foreach (Section section in wordDoc.Sections)
            {
                //Get the header range and add the header details.
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdRed;
                headerRange.Font.Size = 16;
                headerRange.Text = "LƯƠNG NHÂN VIÊN\n" + time;



                Range footersRange = section.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footersRange.Fields.Add(footersRange, WdFieldType.wdFieldPage);
                footersRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                footersRange.Font.ColorIndex = WdColorIndex.wdBlack;   // Màu
                footersRange.Font.Bold = 2;        // Độ Đậm Chữ
                footersRange.Font.Size = 16;
                footersRange.Text = "TP.HCM, " + time;
                footersRange.Text = "\n";

                section.Borders.Enable = 1;
                section.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                section.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth300pt;
                section.Borders.OutsideColor = WdColor.wdColorBlack;

            }

            // Tạo bảng danh sách sinh viên
            Table tableST = wordDoc.Tables.Add(para1.Range, dtgvHienThi.Rows.Count + 1, dtgvHienThi.Columns.Count, ref missing, ref missing);
            //Xuất hiện khung table
            tableST.Borders.Enable = 1;
            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                tableST.Rows[1].Cells[c + 1].Range.Text = dtgvHienThi.Columns[c].HeaderText;
                tableST.Rows[1].Cells[c + 1].Range.Font.Name = "Times New Roman";
            }
            for (int i = 2; i <= tableST.Rows.Count; i++)
            {

                for (int j = 1; j < tableST.Columns.Count + 1; j++)
                {

                    //Lưu text
                    tableST.Rows[i].Cells[j].Range.Text = dtgvHienThi.Rows[i - 2].Cells[j - 1].Value.ToString();
                    tableST.Rows[i].Cells[j].Range.Font.Bold = 1;
                    tableST.Rows[i].Cells[j].Range.Font.Name = "Times New Roman";
                }
            }
            // Lưu thông tin 
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tệp Word (*.docx)|*.docx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                object filename = saveFileDialog.FileName;
                wordDoc.SaveAs2(ref filename);
                wordDoc.Close();
                oWord.Quit();

                // Mở tệp Word sau khi lưu
                Process.Start(filename.ToString());

                MessageBox.Show("Đã In và Thanh Toán Hóa Đơn", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string str = "";
            int row = dtgvHienThi.Rows.Count;
            int cell = dtgvHienThi.Rows[1].Cells.Count;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cell; j++)
                {
                    if (dtgvHienThi.Rows[i].Cells[j].Value == null)
                    {
                        dtgvHienThi.Rows[i].Cells[j].Value = "null";
                    }
                    str += dtgvHienThi.Rows[i].Cells[j].Value.ToString().Trim() + " , ";
                }
                str += "\n";
            }

            e.Graphics.DrawString(str, new System.Drawing.Font("Arial", 30), Brushes.Black, new System.Drawing.Point(10, 10));
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
    }
}
