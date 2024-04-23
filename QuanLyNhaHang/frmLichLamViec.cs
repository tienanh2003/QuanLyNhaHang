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
    public partial class frmLichLamViec : Form
    {
        public frmLichLamViec()
        {
            InitializeComponent();
        }
        KetNoi kn=new KetNoi();
        string user;
        public frmLichLamViec(string user)
        {
            InitializeComponent();
            this.user = user;
        }
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
        private void frmLichLamViec_Load(object sender, EventArgs e)
        {
            int maNhanVien = GetMaNhanVienFromUsername(user);
            SqlCommand command = new SqlCommand("SELECT * FROM CHIACA WHERE MANV = @MaNhanVien", kn.GetConnection);
            command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dtgvLich.DataSource = table;
            dtgvLich.AllowUserToAddRows = false;
        }

        private void dtgvLich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
