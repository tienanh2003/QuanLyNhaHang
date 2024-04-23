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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyNhaHang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public static int ID;
        NHANVIEN nv=new NHANVIEN();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            KetNoi db = new KetNoi();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (rbtnQuanLy.Checked == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM TKQL WHERE USERNAME = @User and PASSWORDS = @Pass", db.GetConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = txtTK.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtMK.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                string h = DateTime.Now.Hour.ToString();
                int HourInt = Convert.ToInt32(h);
                int manv = 0;
                if (table.Rows.Count > 0)
                {
                    manv = Convert.ToInt32(table.Rows[0]["ID"]);

                    if (HourInt >= 0 && HourInt <= 12 && manv == 1)
                    {
                        frmQuanLy frmQuanLy = new frmQuanLy();
                        frmQuanLy.Show(this);
                    }
                    else if (HourInt > 12 && HourInt <= 24 && manv == 2)
                    {
                        frmQuanLy frmQuanLy = new frmQuanLy();
                        frmQuanLy.Show(this);
                    }
                    else
                    {
                        MessageBox.Show("Không phải thời gian làm ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            if (rbtnNhanVien.Checked == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN WHERE USERNAME = @User and PASSWORDS =@Pass", db.GetConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = txtTK.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtMK.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    
                    frmNhanVien frmNhanVien = new frmNhanVien(txtTK.Text);
                    frmNhanVien.Show(this);
                }
                else
                {
                    MessageBox.Show("No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
