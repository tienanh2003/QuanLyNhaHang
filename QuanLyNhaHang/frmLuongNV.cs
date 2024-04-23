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
    public partial class frmLuongNV : Form
    {
        public frmLuongNV()
        {
            InitializeComponent();
        }
        KetNoi kn=new KetNoi();
        private void frmLuongNV_Load(object sender, EventArgs e)
        {
            //int ID = login.IDKey;
            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
            int kk = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, dd, kk);
            string thu = dt.DayOfWeek.ToString().Trim();
            if (thu == "Monday")
            {
                SqlCommand command = new SqlCommand(" SELECT MANV AS N'Mã Nhân Viên',LUONGT2 AS N'Luong Today' FROM LUONGNV", kn.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgvHienThi.DataSource = table;
                dtgvHienThi.AllowUserToAddRows = false;
            }
            if (thu == "Tuesday")
            {
                SqlCommand command = new SqlCommand(" SELECT MANV AS N'Mã Nhân Viên',LUONGT3 AS N'Luong Today' FROM LUONGNV", kn.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgvHienThi.DataSource = table;
                dtgvHienThi.AllowUserToAddRows = false;
            }
            if (thu == "Wednesday")
            {
                SqlCommand command = new SqlCommand(" SELECT MANV AS N'Mã Nhân Viên',LUONGT4 AS N'Luong Today' FROM LUONGNV", kn.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgvHienThi.DataSource = table;
                dtgvHienThi.AllowUserToAddRows = false;
            }
            if (thu == "Thursday")
            {
                SqlCommand command = new SqlCommand(" SELECT MANV AS N'Mã Nhân Viên',LUONGT5 AS N'Luong Today' FROM LUONGNV", kn.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgvHienThi.DataSource = table;
                dtgvHienThi.AllowUserToAddRows = false;
            }
            if (thu == "Friday")
            {
                SqlCommand command = new SqlCommand(" SELECT MANV AS N'Mã Nhân Viên',LUONGT6 AS N'Luong Today' FROM LUONGNV", kn.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgvHienThi.DataSource = table;
                dtgvHienThi.AllowUserToAddRows = false;
            }
            if (thu == "Saturday")
            {
                SqlCommand command = new SqlCommand(" SELECT MANV AS N'Mã Nhân Viên',LUONGT7 AS N'Luong Today' FROM LUONGNV", kn.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgvHienThi.DataSource = table;
                dtgvHienThi.AllowUserToAddRows = false;
            }
            if (thu == "Sunday")
            {
                SqlCommand command = new SqlCommand(" SELECT MANV AS N'Mã Nhân Viên',LUONGCN AS N'Luong Today' FROM LUONGNV", kn.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgvHienThi.DataSource = table;
                dtgvHienThi.AllowUserToAddRows = false;
            }
        }
    }   
}
