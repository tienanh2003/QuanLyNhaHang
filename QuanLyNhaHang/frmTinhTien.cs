using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuanLyNhaHang
{
    public partial class frmTinhTien : Form
    {
        public frmTinhTien()
        {
            InitializeComponent();
        }
        QLBANAN ban = new QLBANAN();
        KetNoi kn = new KetNoi();
        HOADON hoadon = new HOADON();
        public static int Tien;
        public static int TienB;
        private void frmTinhTien_Load(object sender, EventArgs e)
        {
            cboBan.DataSource = ban.getBanTrong();
            cboBan.DisplayMember = "MABAN";
            cboBan.ValueMember = "MABAN";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string name = cboBan.Text.Trim();

            SqlCommand commandban = new SqlCommand(" SELECT MABAN, GIABAN FROM QLBAN WHERE MABAN = '" + name + "'", kn.GetConnection);
            SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
            System.Data.DataTable tableban = new System.Data.DataTable();
            adapterban.Fill(tableban);
            decimal giaban;
            if (decimal.TryParse(tableban.Rows[0]["GIABAN"].ToString(), out giaban))
            {
                ban.updateBanAnTrong(name, 1);
                ban.insertDoanhThuBan(name, (int)giaban, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                hoadon.deleteHoaDon(name);
            }
            MessageBox.Show("Đã Thanh Toán", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (rbtnIn.Checked == true)
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
                    headerRange.Text = "HÓA ĐƠN TIỀN ĂN\n" + time;



                    Range footersRange = section.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footersRange.Fields.Add(footersRange, WdFieldType.wdFieldPage);
                    footersRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    footersRange.Font.ColorIndex = WdColorIndex.wdBlack;   // Màu
                    footersRange.Font.Bold = 2;        // Độ Đậm Chữ
                    footersRange.Font.Size = 16;
                    footersRange.Text = "TP.HCM, " + time + "\n\n";
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
                    tableST.Rows[1].Cells[c + 1].Range.Font.Bold = 1;
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
                para1.Range.Text = "\nTiền Bàn Thanh Toán Là: " + TienB;
                para1.Range.Font.Size = 12;
                para1.Range.Bold = 0;
                para1.Range.Underline = 0;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.InsertParagraphAfter();

                para1.Range.Text = "\nTổng Bill Thanh Toán Là: " + Tien;
                para1.Range.Font.Size = 12;
                para1.Range.Bold = 0;
                para1.Range.Underline = 0;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.InsertParagraphAfter();
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
        }
        public void fillGrid(SqlCommand command)
        {

            dtgvHienThi.ReadOnly = true;
            dtgvHienThi.DataSource = hoadon.getHoaDon(command);
            dtgvHienThi.AllowUserToAddRows = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = cboBan.Text.Trim();
            SqlCommand command = new SqlCommand(" SELECT MABAN as N'Mã Bàn Ăn', TENMON as N'Tên Món', SOLUONG as N'Số Lượng Món', GIATHANH as N'Giá Tổng', NGAYLAP as N'Thời Gian' FROM HOADON WHERE MABAN = '" + name + "'", kn.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            fillGrid(new SqlCommand(" SELECT MABAN as N'Mã Bàn Ăn', TENMON as N'Tên Món', SOLUONG as N'Số Lượng Món', GIATHANH as N'Giá Tổng', NGAYLAP as N'Thời Gian' FROM HOADON WHERE MABAN = '" + name + "'"));

            int tien = 0;
            SqlCommand commandban = new SqlCommand(" SELECT MABAN, GIABAN FROM QLBAN WHERE MABAN = '" + name + "'", kn.GetConnection);
            SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
            System.Data.DataTable tableban = new System.Data.DataTable();
            adapterban.Fill(tableban);

            decimal giaBan;
            decimal tongTien;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                decimal giaTong;
                if (decimal.TryParse(table.Rows[i]["Giá Tổng"].ToString(), out giaTong))
                {
                    tien += (int)giaTong; // Convert to int if necessary
                }
            }

            if (decimal.TryParse(tableban.Rows[0]["GIABAN"].ToString(), out giaBan))
            {
                label1.Text = "Giá Tiền Bàn Là: " + giaBan;
                tongTien = giaBan + tien;
                label2.Text = "Tổng Tiền Thanh Toán Là: " + tongTien;
                Tien = (int)tongTien; // Convert to int if necessary
                TienB = (int)giaBan; // Convert to int if necessary
            }

        }
    }
}
