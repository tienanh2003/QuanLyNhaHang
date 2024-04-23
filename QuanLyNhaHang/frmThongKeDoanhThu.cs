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
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
            chartCot.Series.Add("MonAn");
        }
        KetNoi kn=new KetNoi();
        QLMONAN monan=new QLMONAN();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //if (rbtnNgay.Checked == true)
            //{
            //    int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            //    int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
            //    int kk = Convert.ToInt32(DateTime.Now.Day.ToString());

            //    if (chkHoaDon.Checked == true)
            //    {
            //        SqlCommand command = new SqlCommand(" SELECT IDBAN as N'Mã Bàn Ăn', TENMONHD as N'Tên Món', SOLUONG as N'Số Lượng Món', GIATHANH as N'Giá Tổng', THOIGIAN as N'Thời Gian' FROM DOANHTHU WHERE(DATEPART(yy, THOIGIAN) = '" + yy + "' AND    DATEPART(mm, THOIGIAN) = '" + dd + "' AND    DATEPART(dd, THOIGIAN) = '" + kk + "')",kn.GetConnection);
            //        SqlDataAdapter adapter = new SqlDataAdapter(command);
            //        DataTable table = new DataTable();
            //        adapter.Fill(table);
            //        dtgvDTMon.DataSource = table;
            //        dtgvDTMon.AllowUserToAddRows = false;
            //    }
            //    if (chkBan.Checked == true)
            //    {
            //        SqlCommand commandban = new SqlCommand(" SELECT IDBAN as N'Mã Bàn Ăn', SOTIEN as N'Số Tiền', THOIGIAN as N'Thời Gian' FROM DANHTHUBAN WHERE(DATEPART(yy, THOIGIAN) = '" + yy + "' AND    DATEPART(mm, THOIGIAN) = '" + dd + "' AND    DATEPART(dd, THOIGIAN) = '" + kk + "')",kn.GetConnection);
            //        SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
            //        DataTable tableban = new DataTable();
            //        adapterban.Fill(tableban);
            //        dtgvDTMon.DataSource = tableban;
            //        dtgvDTMon.AllowUserToAddRows = false;
            //    }
            //    SqlCommand command1 = new SqlCommand("SELECT sum(SOTIEN) as N'SL'  FROM DANHTHUBAN WHERE(DATEPART(yy, THOIGIAN) = '" + yy + "' AND    DATEPART(mm, THOIGIAN) = '" + dd + "' AND    DATEPART(dd, THOIGIAN) = '" + kk + "')",kn.GetConnection);
            //    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            //    DataTable table1 = new DataTable();
            //    adapter1.Fill(table1);


            //    SqlCommand command11 = new SqlCommand("SELECT sum(GIATHANH) as N'SL'  FROM DOANHTHU WHERE(DATEPART(yy, THOIGIAN) = '" + yy + "' AND    DATEPART(mm, THOIGIAN) = '" + dd + "' AND    DATEPART(dd, THOIGIAN) = '" + kk + "')",kn.GetConnection);
            //    SqlDataAdapter adapter11 = new SqlDataAdapter(command11);
            //    DataTable table11 = new DataTable();
            //    adapter11.Fill(table11);

            //    //lblDoanhThu.Text = "TỔNG DOANH THU LÀ: " + (Convert.ToInt32(table1.Rows[0][0].ToString()) + Convert.ToInt32(table11.Rows[0][0].ToString()));
            //    int doanhThu1 = 0;
            //    int doanhThu2 = 0;
            //    if (int.TryParse(table1.Rows[0][0].ToString(), out int result1))
            //    {
            //        doanhThu1 = result1;
            //    }

            //    if (int.TryParse(table11.Rows[0][0].ToString(), out int result2))
            //    {
            //        doanhThu2 = result2;
            //    }

            //    lblDoanhThu.Text = "TỔNG DOANH THU LÀ: " + (doanhThu1 + doanhThu2).ToString();

            //}
            //if (rbtnThang.Checked == true)
            //{
            //    int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            //    int month = Convert.ToInt32(cboThang.Text);
            //    if (int.TryParse(cboThang.Text, out month))
            //    {
            //        if (chkHoaDon.Checked == true)
            //        {
            //            SqlCommand command = new SqlCommand(" SELECT IDBAN as N'Mã Bàn Ăn', TENMONHD as N'Tên Món', SOLUONG as N'Số Lượng Món', GIATHANH as N'Giá Tổng', THOIGIAN as N'Thời Gian' FROM DOANHTHU WHERE(DATEPART(yy, THOIGIAN) = '" + yy + "' AND    DATEPART(mm, THOIGIAN) = '" + month + "' )", kn.GetConnection);
            //            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //            DataTable table = new DataTable();
            //            adapter.Fill(table);
            //            dtgvDTMon.DataSource = table;
            //            dtgvDTMon.AllowUserToAddRows = false;
            //        }
            //        if (chkBan.Checked == true)
            //        {
            //            SqlCommand commandban = new SqlCommand(" SELECT IDBAN as N'Mã Bàn Ăn', SOTIEN as N'Số Tiền', THOIGIAN as N'Thời Gian' FROM DANHTHUBAN WHERE(DATEPART(yy, THOIGIAN) = '" + yy + "' AND    DATEPART(mm, THOIGIAN) = '" + month + "' )", kn.GetConnection);
            //            SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
            //            DataTable tableban = new DataTable();
            //            adapterban.Fill(tableban);
            //            dtgvDTMon.DataSource = tableban;
            //            dtgvDTMon.AllowUserToAddRows = false;
            //        }
            //        SqlCommand command1 = new SqlCommand("SELECT sum(SOTIEN) as N'SL'  FROM DANHTHUBAN  WHERE(DATEPART(yy, THOIGIAN) = '" + yy + "' AND    DATEPART(mm, THOIGIAN) = '" + month + "' )", kn.GetConnection);
            //        SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            //        DataTable table1 = new DataTable();
            //        adapter1.Fill(table1);


            //        SqlCommand command11 = new SqlCommand("SELECT sum(GIATHANH) as N'SL'  FROM DOANHTHU  WHERE(DATEPART(yy, THOIGIAN) = '" + yy + "' AND    DATEPART(mm, THOIGIAN) = '" + month + "' )", kn.GetConnection);
            //        SqlDataAdapter adapter11 = new SqlDataAdapter(command11);
            //        DataTable table11 = new DataTable();
            //        adapter11.Fill(table11);
            //        int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
            //        if (month == dd)
            //        {
            //            //lblDoanhThu.Text = "TỔNG DOANH THU LÀ: " + (Convert.ToInt32(table1.Rows[0][0].ToString()) + Convert.ToInt32(table11.Rows[0][0].ToString()));
            //            int doanhThu1 = 0;
            //            int doanhThu2 = 0;
            //            if (int.TryParse(table1.Rows[0][0].ToString(), out int result1))
            //            {
            //                doanhThu1 = result1;
            //            }

            //            if (int.TryParse(table11.Rows[0][0].ToString(), out int result2))
            //            {
            //                doanhThu2 = result2;
            //            }

            //            lblDoanhThu.Text = "TỔNG DOANH THU LÀ: " + (doanhThu1 + doanhThu2).ToString();

            //        }
            //        else
            //        {
            //            lblDoanhThu.Text = "KHÔNG CÓ DOANH THU THÁNG NÀY";
            //        }
            //    }                                             
            //}
            //if (rbtnNam.Checked == true)
            //{

            //    int year = Convert.ToInt32(numNam.Value);

            //    if (chkHoaDon.Checked == true)
            //    {
            //        SqlCommand command = new SqlCommand(" SELECT IDBAN as N'Mã Bàn Ăn', TENMONHD as N'Tên Món', SOLUONG as N'Số Lượng Món', GIATHANH as N'Giá Tổng', THOIGIAN as N'Thời Gian' FROM DOANHTHU WHERE(DATEPART(yy, THOIGIAN) = '" + year + "')",kn.GetConnection);
            //        SqlDataAdapter adapter = new SqlDataAdapter(command);
            //        DataTable table = new DataTable();
            //        adapter.Fill(table);
            //        dtgvDTMon.DataSource = table;
            //        dtgvDTMon.AllowUserToAddRows = false;
            //    }

            //    if (chkBan.Checked == true)
            //    {
            //        SqlCommand commandban = new SqlCommand(" SELECT IDBAN as N'Mã Bàn Ăn', SOTIEN as N'Số Tiền', THOIGIAN as N'Thời Gian' FROM DANHTHUBAN WHERE(DATEPART(yy, THOIGIAN) = '" + year + "')",kn.GetConnection);
            //        SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
            //        DataTable tableban = new DataTable();
            //        adapterban.Fill(tableban);
            //        dtgvDTMon.DataSource = tableban;
            //        dtgvDTMon.AllowUserToAddRows = false;
            //    }
            //    SqlCommand command1 = new SqlCommand("SELECT sum(SOTIEN) as N'SL'  FROM DANHTHUBAN WHERE(DATEPART(yy, THOIGIAN) = '" + year + "')",kn.GetConnection);
            //    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            //    DataTable table1 = new DataTable();
            //    adapter1.Fill(table1);


            //    SqlCommand command11 = new SqlCommand("SELECT sum(GIATHANH) as N'SL'  FROM DOANHTHU WHERE(DATEPART(yy, THOIGIAN) = '" + year + "')",kn.GetConnection);
            //    SqlDataAdapter adapter11 = new SqlDataAdapter(command11);
            //    DataTable table11 = new DataTable();
            //    adapter11.Fill(table11);

            //    int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            //    if (year == yy)
            //    {
            //        //lblDoanhThu.Text = "TỔNG DOANH THU LÀ: " + (Convert.ToInt32(table1.Rows[0][0].ToString()) + Convert.ToInt32(table11.Rows[0][0].ToString()));
            //        int doanhThu1 = 0;
            //        int doanhThu2 = 0;
            //        if (int.TryParse(table1.Rows[0][0].ToString(), out int result1))
            //        {
            //            doanhThu1 = result1;
            //        }

            //        if (int.TryParse(table11.Rows[0][0].ToString(), out int result2))
            //        {
            //            doanhThu2 = result2;
            //        }

            //        lblDoanhThu.Text = "TỔNG DOANH THU LÀ: " + (doanhThu1 + doanhThu2).ToString();

            //    }
            //    else
            //    {
            //        lblDoanhThu.Text = "KHÔNG CÓ DOANH THU NĂM NÀY";
            //    }


            //}
            if (rbtnNgay.Checked)
            {
                int yy = DateTime.Now.Year;
                int dd = DateTime.Now.Month;
                int kk = DateTime.Now.Day;

                if (chkHoaDon.Checked)
                {
                    SqlCommand command = new SqlCommand(" SELECT IDBAN as N'Mã Bàn Ăn', TENMONHD as N'Tên Món', SOLUONG as N'Số Lượng Món', GIATHANH as N'Giá Tổng', THOIGIAN as N'Thời Gian' FROM DOANHTHU WHERE DATEPART(yy, THOIGIAN) = @yy AND DATEPART(mm, THOIGIAN) = @dd AND DATEPART(dd, THOIGIAN) = @kk", kn.GetConnection);
                    command.Parameters.AddWithValue("@yy", yy);
                    command.Parameters.AddWithValue("@dd", dd);
                    command.Parameters.AddWithValue("@kk", kk);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtgvDTMon.DataSource = table;
                    dtgvDTMon.AllowUserToAddRows = false;
                }
                if (chkBan.Checked)
                {
                    SqlCommand commandban = new SqlCommand(" SELECT IDBAN as N'Mã Bàn Ăn', SOTIEN as N'Số Tiền', THOIGIAN as N'Thời Gian' FROM DANHTHUBAN WHERE DATEPART(yy, THOIGIAN) = @yy AND DATEPART(mm, THOIGIAN) = @dd AND DATEPART(dd, THOIGIAN) = @kk", kn.GetConnection);
                    commandban.Parameters.AddWithValue("@yy", yy);
                    commandban.Parameters.AddWithValue("@dd", dd);
                    commandban.Parameters.AddWithValue("@kk", kk);
                    SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
                    DataTable tableban = new DataTable();
                    adapterban.Fill(tableban);
                    dtgvDTMon.DataSource = tableban;
                    dtgvDTMon.AllowUserToAddRows = false;
                }
                SqlCommand command1 = new SqlCommand("SELECT SUM(SOTIEN) AS N'SL' FROM DANHTHUBAN WHERE DATEPART(yy, THOIGIAN) = @yy AND DATEPART(mm, THOIGIAN) = @dd AND DATEPART(dd, THOIGIAN) = @kk", kn.GetConnection);
                command1.Parameters.AddWithValue("@yy", yy);
                command1.Parameters.AddWithValue("@dd", dd);
                command1.Parameters.AddWithValue("@kk", kk);
                SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);

                SqlCommand command11 = new SqlCommand("SELECT SUM(GIATHANH) AS N'SL' FROM DOANHTHU WHERE DATEPART(yy, THOIGIAN) = @yy AND DATEPART(mm, THOIGIAN) = @dd AND DATEPART(dd, THOIGIAN) = @kk", kn.GetConnection);
                command11.Parameters.AddWithValue("@yy", yy);
                command11.Parameters.AddWithValue("@dd", dd);
                command11.Parameters.AddWithValue("@kk", kk);
                SqlDataAdapter adapter11 = new SqlDataAdapter(command11);
                DataTable table11 = new DataTable();
                adapter11.Fill(table11);

                int doanhThu1 = 0;
                int doanhThu2 = 0;
                if (int.TryParse(table1.Rows[0][0].ToString(), out int result1))
                {
                    doanhThu1 = result1;
                }

                if (int.TryParse(table11.Rows[0][0].ToString(), out int result2))
                {
                    doanhThu2 = result2;
                }

                lblDoanhThu.Text = "TỔNG DOANH THU LÀ: " + (doanhThu1 + doanhThu2).ToString();
            }
            else if (rbtnThang.Checked)
            {
                int yy = DateTime.Now.Year;
                int month = Convert.ToInt32(cboThang.Text);

                if (chkHoaDon.Checked)
                {
                    SqlCommand command = new SqlCommand(" SELECT IDBAN as N'Mã Bàn Ăn', TENMONHD as N'Tên Món', SOLUONG as N'Số Lượng Món', GIATHANH as N'Giá Tổng', THOIGIAN as N'Thời Gian' FROM DOANHTHU WHERE DATEPART(yy, THOIGIAN) = @yy AND DATEPART(mm, THOIGIAN) = @month", kn.GetConnection);
                    command.Parameters.AddWithValue("@yy", yy);
                    command.Parameters.AddWithValue("@month", month);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtgvDTMon.DataSource = table;
                    dtgvDTMon.AllowUserToAddRows = false;
                }
                if (chkBan.Checked)
                {
                    SqlCommand commandban = new SqlCommand(" SELECT IDBAN as N'Mã Bàn Ăn', SOTIEN as N'Số Tiền', THOIGIAN as N'Thời Gian' FROM DANHTHUBAN WHERE DATEPART(yy, THOIGIAN) = @yy AND DATEPART(mm, THOIGIAN) = @month", kn.GetConnection);
                    commandban.Parameters.AddWithValue("@yy", yy);
                    commandban.Parameters.AddWithValue("@month", month);
                    SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
                    DataTable tableban = new DataTable();
                    adapterban.Fill(tableban);
                    dtgvDTMon.DataSource = tableban;
                    dtgvDTMon.AllowUserToAddRows = false;
                }
                SqlCommand command1 = new SqlCommand("SELECT SUM(SOTIEN) AS N'SL' FROM DANHTHUBAN WHERE DATEPART(yy, THOIGIAN) = @yy AND DATEPART(mm, THOIGIAN) = @month", kn.GetConnection);
                command1.Parameters.AddWithValue("@yy", yy);
                command1.Parameters.AddWithValue("@month", month);
                SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);

                SqlCommand command11 = new SqlCommand("SELECT SUM(GIATHANH) AS N'SL' FROM DOANHTHU WHERE DATEPART(yy, THOIGIAN) = @yy AND DATEPART(mm, THOIGIAN) = @month", kn.GetConnection);
                command11.Parameters.AddWithValue("@yy", yy);
                command11.Parameters.AddWithValue("@month", month);
                SqlDataAdapter adapter11 = new SqlDataAdapter(command11);
                DataTable table11 = new DataTable();
                adapter11.Fill(table11);

                int dd = DateTime.Now.Month;
                if (month == dd)
                {
                    int doanhThu1 = 0;
                    int doanhThu2 = 0;
                    if (int.TryParse(table1.Rows[0][0].ToString(), out int result1))
                    {
                        doanhThu1 = result1;
                    }

                    if (int.TryParse(table11.Rows[0][0].ToString(), out int result2))
                    {
                        doanhThu2 = result2;
                    }

                    lblDoanhThu.Text = "TỔNG DOANH THU LÀ: " + (doanhThu1 + doanhThu2).ToString();
                }
                else
                {
                    lblDoanhThu.Text = "KHÔNG CÓ DOANH THU THÁNG NÀY";
                }
            }
            else if (rbtnNam.Checked)
            {
                int year = Convert.ToInt32(numNam.Value);

                if (chkHoaDon.Checked)
                {
                    SqlCommand command = new SqlCommand(" SELECT IDBAN as N'Mã Bàn Ăn', TENMONHD as N'Tên Món', SOLUONG as N'Số Lượng Món', GIATHANH as N'Giá Tổng', THOIGIAN as N'Thời Gian' FROM DOANHTHU WHERE DATEPART(yy, THOIGIAN) = @year", kn.GetConnection);
                    command.Parameters.AddWithValue("@year", year);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtgvDTMon.DataSource = table;
                    dtgvDTMon.AllowUserToAddRows = false;
                }

                if (chkBan.Checked)
                {
                    SqlCommand commandban = new SqlCommand(" SELECT IDBAN as N'Mã Bàn Ăn', SOTIEN as N'Số Tiền', THOIGIAN as N'Thời Gian' FROM DANHTHUBAN WHERE DATEPART(yy, THOIGIAN) = @year", kn.GetConnection);
                    commandban.Parameters.AddWithValue("@year", year);
                    SqlDataAdapter adapterban = new SqlDataAdapter(commandban);
                    DataTable tableban = new DataTable();
                    adapterban.Fill(tableban);
                    dtgvDTMon.DataSource = tableban;
                    dtgvDTMon.AllowUserToAddRows = false;
                }
                SqlCommand command1 = new SqlCommand("SELECT SUM(SOTIEN) AS N'SL' FROM DANHTHUBAN WHERE DATEPART(yy, THOIGIAN) = @year", kn.GetConnection);
                command1.Parameters.AddWithValue("@year", year);
                SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);

                SqlCommand command11 = new SqlCommand("SELECT SUM(GIATHANH) AS N'SL' FROM DOANHTHU WHERE DATEPART(yy, THOIGIAN) = @year", kn.GetConnection);
                command11.Parameters.AddWithValue("@year", year);
                SqlDataAdapter adapter11 = new SqlDataAdapter(command11);
                DataTable table11 = new DataTable();
                adapter11.Fill(table11);

                int yy = DateTime.Now.Year;
                if (year == yy)
                {
                    int doanhThu1 = 0;
                    int doanhThu2 = 0;
                    if (int.TryParse(table1.Rows[0][0].ToString(), out int result1))
                    {
                        doanhThu1 = result1;
                    }

                    if (int.TryParse(table11.Rows[0][0].ToString(), out int result2))
                    {
                        doanhThu2 = result2;
                    }

                    lblDoanhThu.Text = "TỔNG DOANH THU LÀ: " + (doanhThu1 + doanhThu2).ToString();
                }
                else
                {
                    lblDoanhThu.Text = "KHÔNG CÓ DOANH THU NĂM NÀY";
                }
            }
        }

        private void btnMonBanChay_Click(object sender, EventArgs e)
        {
            //if (rbtnNgay.Checked == true)
            //{
            //    int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            //    int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
            //    int kk = Convert.ToInt32(DateTime.Now.Day.ToString());

            //    SqlCommand command = new SqlCommand(" SELECT sum(SOLUONG) as N'Số Lượng', TENMONHD as N'Tên Món Ăn' FROM DOANHTHU WHERE(DATEPART(yy, THOIGIAN) = '" + yy + "' AND    DATEPART(mm, THOIGIAN) = '" + dd + "' AND    DATEPART(dd, THOIGIAN) = '" + kk + "') GROUP BY TENMONHD ORDER BY N'Số Lượng' DESC",kn.GetConnection);
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);
            //    dtgvDTMon.DataSource = table;

            //    dtgvDTMon.DataSource = table;
            //    dtgvDTMon.AllowUserToAddRows = false;
            //    try
            //    {
            //        int len = this.dtgvDTMon.Rows.Count;
            //        for (int i = 0; i < len; i++)
            //        {

            //            string s = dtgvDTMon.Rows[i].Cells[1].Value.ToString();
            //            string k = dtgvDTMon.Rows[i].Cells[0].Value.ToString();
            //            double kq = Convert.ToDouble(k);
            //            chartCot.Series["MonAn"].Points.AddXY(s, k);
            //        }
            //    }
            //    catch (NullReferenceException ee)
            //    {
            //        ee.InnerException.ToString();
            //    }


            //}
            //if (rbtnThang.Checked == true)
            //{
            //    int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            //    int month = Convert.ToInt32(cboThang.Text);


            //    SqlCommand command = new SqlCommand(" SELECT sum(SOLUONG) as N'Số Lượng', TENMONHD as N'Tên Món Ăn' FROM DOANHTHU WHERE(DATEPART(yy, THOIGIAN) = '" + yy + "' AND    DATEPART(mm, THOIGIAN) = '" + month + "' ) GROUP BY TENMONHD ORDER BY N'Số Lượng' DESC",kn.GetConnection);
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);
            //    dtgvDTMon.DataSource = table;
            //    dtgvDTMon.AllowUserToAddRows = false;

            //    dtgvDTMon.DataSource = table;
            //    dtgvDTMon.AllowUserToAddRows = false;
            //    try
            //    {
            //        int len = this.dtgvDTMon.Rows.Count;
            //        for (int i = 0; i < len; i++)
            //        {

            //            string s = dtgvDTMon.Rows[i].Cells[1].Value.ToString();
            //            string k = dtgvDTMon.Rows[i].Cells[0].Value.ToString();
            //            double kq = Convert.ToDouble(k);
            //            chartCot.Series["MonAn"].Points.AddXY(s, k);
            //        }
            //    }
            //    catch (NullReferenceException ee)
            //    {
            //        ee.InnerException.ToString();
            //    }

            //}
            //if (rbtnNam.Checked == true)
            //{
            //    int year = Convert.ToInt32(numNam.Value);



            //    SqlCommand command = new SqlCommand(" SELECT sum(SOLUONG) as N'Số Lượng', TENMONHD as N'Tên Món Ăn' FROM DOANHTHU WHERE(DATEPART(yy, THOIGIAN) = '" + year + "') GROUP BY TENMONHD ORDER BY N'Số Lượng' DESC",kn.GetConnection);
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);
            //    dtgvDTMon.DataSource = table;
            //    dtgvDTMon.AllowUserToAddRows = false;

            //    dtgvDTMon.DataSource = table;
            //    dtgvDTMon.AllowUserToAddRows = false;
            //    try
            //    {
            //        int len = this.dtgvDTMon.Rows.Count;
            //        for (int i = 0; i < len; i++)
            //        {

            //            string s = dtgvDTMon.Rows[i].Cells[1].Value.ToString();
            //            string k = dtgvDTMon.Rows[i].Cells[0].Value.ToString();
            //            double kq = Convert.ToDouble(k);
            //            chartCot.Series["MonAn"].Points.AddXY(s, k);
            //        }
            //    }
            //    catch (NullReferenceException ee)
            //    {
            //        ee.InnerException.ToString();
            //    }

            //}
            // Xóa dữ liệu cũ trong biểu đồ
            chartCot.Series["MonAn"].Points.Clear();

            // Lấy dữ liệu từ cơ sở dữ liệu
            // Xóa dữ liệu cũ trong biểu đồ
            chartCot.Series["MonAn"].Points.Clear();

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable table = new DataTable();
            if (rbtnNgay.Checked)
            {
                int year = DateTime.Now.Year;
                int month = DateTime.Now.Month;
                int day = DateTime.Now.Day;

                string query = @"
            SELECT TENMONHD, SUM(SOLUONG) AS SoLuong
            FROM DOANHTHU
            WHERE DATEPART(yy, THOIGIAN) = @year
              AND DATEPART(mm, THOIGIAN) = @month
              AND DATEPART(dd, THOIGIAN) = @day
            GROUP BY TENMONHD
            ORDER BY SoLuong DESC";

                using (SqlCommand command = new SqlCommand(query, kn.GetConnection))
                {
                    command.Parameters.AddWithValue("@year", year);
                    command.Parameters.AddWithValue("@month", month);
                    command.Parameters.AddWithValue("@day", day);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            else if (rbtnThang.Checked)
            {
                int year = DateTime.Now.Year;
                int month = Convert.ToInt32(cboThang.Text);

                string query = @"
            SELECT TENMONHD, SUM(SOLUONG) AS SoLuong
            FROM DOANHTHU
            WHERE DATEPART(yy, THOIGIAN) = @year
              AND DATEPART(mm, THOIGIAN) = @month
            GROUP BY TENMONHD
            ORDER BY SoLuong DESC";

                using (SqlCommand command = new SqlCommand(query, kn.GetConnection))
                {
                    command.Parameters.AddWithValue("@year", year);
                    command.Parameters.AddWithValue("@month", month);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            else if (rbtnNam.Checked)
            {
                int year = Convert.ToInt32(numNam.Value);

                string query = @"
            SELECT TENMONHD, SUM(SOLUONG) AS SoLuong
            FROM DOANHTHU
            WHERE DATEPART(yy, THOIGIAN) = @year
            GROUP BY TENMONHD
            ORDER BY SoLuong DESC";

                using (SqlCommand command = new SqlCommand(query, kn.GetConnection))
                {
                    command.Parameters.AddWithValue("@year", year);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            // Hiển thị dữ liệu lên DataGridView
            dtgvDTMon.DataSource = table;
            dtgvDTMon.AllowUserToAddRows = false;

            // Thêm dữ liệu vào biểu đồ
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    string tenMon = row["TENMONHD"].ToString();
                    int soLuong = Convert.ToInt32(row["SoLuong"]);
                    chartCot.Series["MonAn"].Points.AddXY(tenMon, soLuong);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }
    }
}
