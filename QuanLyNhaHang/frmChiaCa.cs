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
    public partial class frmChiaCa : Form
    {
        public frmChiaCa()
        {
            InitializeComponent();
        }
        KetNoi kn=new KetNoi();
        CHIACA chiaca=new CHIACA();
        private void btnChiaCa_Click(object sender, EventArgs e)
        {
            SqlCommand commandCa = new SqlCommand("SELECT NHANVIEN.MANV, THU2, THU3, THU4, THU5, THU6, THU7, CN FROM CHIACA RIGHT JOIN NHANVIEN ON CHIACA.MANV = NHANVIEN.MANV", kn.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandCa);
            DataTable tableCa = new DataTable();
            adapter.Fill(tableCa);

            List<int> shiftOptions = new List<int>() { 1, 2, 3 }; // List of available shifts

            Random rd = new Random();

            for (int j = 1; j < tableCa.Columns.Count; j++)
            {
                List<int> usedShifts = new List<int>(); // List to keep track of used shifts for each day

                for (int i = 0; i < tableCa.Rows.Count; i++)
                {
                    int randomIndex = rd.Next(shiftOptions.Count); // Get a random index from available shift options
                    int selectedShift = shiftOptions[randomIndex]; // Get the selected shift
                    shiftOptions.RemoveAt(randomIndex); // Remove the selected shift from available options

                    tableCa.Rows[i][j] = selectedShift; // Assign the selected shift to the cell

                    usedShifts.Add(selectedShift); // Add the selected shift to used shifts list
                }

                shiftOptions.AddRange(usedShifts); // Add used shifts back to available options for the next day
            }

            foreach (DataRow row in tableCa.Rows)
            {
                    chiaca.updateCaLam(Convert.ToInt32(row["MANV"]),
                    Convert.ToInt32(row["THU2"]),
                    Convert.ToInt32(row["THU3"]),
                    Convert.ToInt32(row["THU4"]),
                    Convert.ToInt32(row["THU5"]),
                    Convert.ToInt32(row["THU6"]),
                    Convert.ToInt32(row["THU7"]),
                    Convert.ToInt32(row["CN"]));
            }

            dtgvChiaCa.DataSource = tableCa;

            for (int i = 0; i < tableCa.Rows.Count; i++)
            {
                for (int j = 1; j < tableCa.Columns.Count; j++)
                {
                    if (Convert.ToInt32(tableCa.Rows[i][j]) == 3)
                    {
                        dtgvChiaCa.Rows[i].Cells[j].Value = "3";
                    }
                    else if (Convert.ToInt32(tableCa.Rows[i][j]) == 2)
                    {
                        dtgvChiaCa.Rows[i].Cells[j].Value = "2";
                    }
                    else
                    {
                        dtgvChiaCa.Rows[i].Cells[j].Value = "1";
                    }
                }
            }

            dtgvChiaCa.AllowUserToAddRows = false;
            MessageBox.Show("CHIA CA THÀNH CÔNG CHO NHÂN VIÊN!!!");
        }
    }
}
