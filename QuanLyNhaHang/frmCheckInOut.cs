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
    public partial class frmCheckInOut : Form
    {
        public frmCheckInOut()
        {
            InitializeComponent();
        }
        string user;
        private frmTienLuong tienLuongForm;
        public frmCheckInOut(string user, frmTienLuong tienLuongForm)
        {
            InitializeComponent();
            this.user = user;
            this.tienLuongForm = tienLuongForm;
        }
        KetNoi kn = new KetNoi();
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
        public int CheckThu()       // Check Thứ Now để lấy cột của thứ Now để lấy ca ra và tính Time đúng của ca làm.
        {
            int cot = 0;
            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Month.ToString());
            int kk = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, dd, kk);
            string thu = dt.DayOfWeek.ToString().Trim();
            if (thu == "MonDay")
                cot = 1;
            if (thu == "Tuesday")
                cot = 2;
            if (thu == "Wednesday")
                cot = 3;
            if (thu == "Thursday")
                cot = 4;
            if (thu == "Friday")
                cot = 5;
            if (thu == "Saturday")
                cot = 6;
            if (thu == "Sunday")
                cot = 7;
            return cot;
        }
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            int name = GetMaNhanVienFromUsername(user);
            SqlCommand command = new SqlCommand(" SELECT * FROM CHIACA WHERE MANV = @Id", kn.GetConnection);
            command.Parameters.AddWithValue("@Id", name);
            SqlDataAdapter adapterc = new SqlDataAdapter(command);
            DataTable tablec = new DataTable();
            adapterc.Fill(tablec);
            string test = tablec.Rows[0][CheckThu()].ToString().Trim();   // Get the shift code for the current day
            int HourInt = Convert.ToInt32(DateTime.Now.Hour.ToString());

            if (test == "2" || test == "-2")
            {
                if (radioButtonSang.Checked == true)
                {
                    if (HourInt >= 7 && HourInt <= 11)
                    {
                        idl.updateTimeStartCa1(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Started recording time for the shift", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("This is not the start time for the shift");
                }
                if (radioButtonToi.Checked == true)
                {
                    if (HourInt >= 18 && HourInt < 22)
                    {
                        idl.updateTimeStartCa3(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Started recording time for the shift", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("This is not the start time for the shift");
                }
            }
            if (test == "1" || test == "-1")
            {
                if (radioButtonTrua.Checked == true)
                {
                    if (HourInt >= 11 && HourInt < 15)
                    {
                        idl.updateTimeStartCa2(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Started recording time for the shift", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("This is not the start time for the shift");
                }
                if (radioButtonToi.Checked == true)
                {
                    if (HourInt >= 18 && HourInt < 22)
                    {
                        idl.updateTimeStartCa3(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Started recording time for the shift", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("This is not the start time for the shift");
                }
            }
            if (test == "3" || test == "-3")
            {
                if (radioButtonSang.Checked == true)
                {
                    if (HourInt >= 7 && HourInt <= 11)
                    {
                        idl.updateTimeStartCa1(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Started recording time for the shift", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("This is not the start time for the shift");
                }
                if (radioButtonTrua.Checked == true)
                {
                    if (HourInt >= 11 && HourInt < 15)
                    {
                        idl.updateTimeStartCa2(name, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                        MessageBox.Show("Started recording time for the shift", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("This is not the start time for the shift");
                }
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            int employeeId = GetMaNhanVienFromUsername(user);
            SqlCommand command = new SqlCommand(" SELECT * FROM CHIACA WHERE MANV = @Id", kn.GetConnection);
            command.Parameters.AddWithValue("@Id", employeeId);
            SqlDataAdapter adapterc = new SqlDataAdapter(command);
            DataTable tablec = new DataTable();
            adapterc.Fill(tablec);
            string test = tablec.Rows[0][CheckThu()].ToString().Trim();   // Get the shift code for the current day
            int HourInt = Convert.ToInt32(DateTime.Now.Hour.ToString());

            // Check if the start time was already recorded
            SqlCommand commandcheck = new SqlCommand(" SELECT * FROM TIMELV WHERE MANV = @Id", kn.GetConnection);
            commandcheck.Parameters.AddWithValue("@Id", employeeId);
            SqlDataAdapter adaptercheck = new SqlDataAdapter(commandcheck);
            DataTable tablecheck = new DataTable();
            adaptercheck.Fill(tablecheck);

            if (test == "2" || test == "-2")
            {
                if (radioButtonSang.Checked == true)
                {
                    if (tablecheck.Rows[0]["TIMESTAR1"].ToString().Trim() != "")
                    {
                        if (HourInt >= 7 && HourInt <= 11)
                        {
                            idl.updateTimeEndCa1(employeeId, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stopped recording time for the shift", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tienLuongForm.UpdateLuong(employeeId);
                        }
                        else
                            MessageBox.Show("This is not the end time for the shift");
                    }
                    else
                        MessageBox.Show("Error: You have not started the shift yet", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (radioButtonToi.Checked == true)
                {
                    if (tablecheck.Rows[0]["TIMESTAR3"].ToString().Trim() != "")
                    {
                        if (HourInt >= 18 && HourInt < 22)
                        {
                            idl.updateTimeEndCa3(employeeId, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stopped recording time for the shift", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tienLuongForm.UpdateLuong(employeeId);
                        }
                        else
                            MessageBox.Show("This is not the end time for the shift");
                    }
                    else
                        MessageBox.Show("Error: You have not started the shift yet", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (test == "1" || test == "-1")
            {
                if (radioButtonTrua.Checked == true)
                {
                    if (tablecheck.Rows[0]["TIMESTAR2"].ToString().Trim() != "")
                    {
                        if (HourInt >= 11 && HourInt < 15)
                        {
                            idl.updateTimeEndCa2(employeeId, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stopped recording time for the shift", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tienLuongForm.UpdateLuong(employeeId);
                        }
                        else
                            MessageBox.Show("This is not the end time for the shift");
                    }
                    else
                        MessageBox.Show("Error: You have not started the shift yet", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (radioButtonToi.Checked == true)
                {
                    if (tablecheck.Rows[0]["TIMESTAR3"].ToString().Trim() != "")
                    {
                        if (HourInt >= 18 && HourInt < 22)
                        {
                            idl.updateTimeEndCa3(employeeId, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stopped recording time for the shift", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tienLuongForm.UpdateLuong(employeeId);
                        }
                        else
                            MessageBox.Show("This is not the end time for the shift");
                    }
                    else
                        MessageBox.Show("Error: You have not started the shift yet", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (test == "3" || test == "-3")
            {
                if (radioButtonSang.Checked == true)
                {
                    if (tablecheck.Rows[0]["TIMESTAR1"].ToString().Trim() != "")
                    {
                        if (HourInt >= 7 && HourInt <= 11)
                        {
                            idl.updateTimeEndCa1(employeeId, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stopped recording time for the shift", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tienLuongForm.UpdateLuong(employeeId);
                        }
                        else
                            MessageBox.Show("This is not the end time for the shift");
                    }
                    else
                        MessageBox.Show("Error: You have not started the shift yet", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (radioButtonTrua.Checked == true)
                {
                    if (tablecheck.Rows[0]["TIMESTAR2"].ToString().Trim() != "")
                    {
                        if (HourInt >= 11 && HourInt < 15)
                        {
                            idl.updateTimeEndCa2(employeeId, Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")));
                            MessageBox.Show("Stopped recording time for the shift", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tienLuongForm.UpdateLuong(employeeId);
                        }
                        else
                            MessageBox.Show("This is not the end time for the shift");
                    }
                    else
                        MessageBox.Show("Error: You have not started the shift yet", "Stop Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
