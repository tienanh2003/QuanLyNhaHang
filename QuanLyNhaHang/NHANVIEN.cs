using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class NHANVIEN
    {
        //
        KetNoi kn=new KetNoi();
        public bool insertNhanVien(int Id, string uname, string pass,string hoten, DateTime bdate, string gender, string phone, string email, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NHANVIEN(MANV, USERNAME, PASSWORDS, HOTEN, BDAY, GIOITINH, DIENTHOAI, EMAIL,ANH)" +
                "VALUES (@id, @tk, @mk, @name, @bday, @gt, @dt,@email, @pic)", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@tk", SqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@mk", SqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = hoten;
            command.Parameters.Add("@bday", SqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@dt", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            kn.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                kn.closeConnection();
                return true;
            }
            else
            {
                kn.closeConnection();
                return false;
            }
        }
        public bool updateNhanVien(int Id, string uname, string pass, string hoten, DateTime bdate, string gender, string phone, string email, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE NHANVIEN SET USERNAME=@tk, PASSWORDS=@mk, HOTEN=@name, BDAY=@bday, GIOITINH=@gt, DIENTHOAI=@dt, EMAIL=@email, ANH=@pic WHERE MANV=@id",
                kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@tk", SqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@mk", SqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = hoten;
            command.Parameters.Add("@bday", SqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@dt", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            kn.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                kn.closeConnection();
                return true;
            }
            else
            {
                kn.closeConnection();
                return false;
            }
        }

        public bool deleteNhanVien(string Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM NHANVIEN WHERE MANV=@id",
                kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = Id;
            kn.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                kn.closeConnection();
                return true;
            }
            else
            {
                kn.closeConnection();
                return false;
            }
        }
        public bool deleteChiaCa(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM CHIACA WHERE MANV = @id", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            kn.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                kn.closeConnection();
                return true;
            }
            else
            {
                kn.closeConnection();
                return false;
            }
        }

        public bool deleteLuongNV(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM LUONGNV WHERE MANV = @id", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            kn.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                kn.closeConnection();
                return true;
            }
            else
            {
                kn.closeConnection();
                return false;
            }
        }

        public bool deleteTimeLV(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM TIMELV WHERE MANV = @id", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            kn.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                kn.closeConnection();
                return true;
            }
            else
            {
                kn.closeConnection();
                return false;
            }
        }
        public DataTable getNhanVien(SqlCommand command)
        {
            command.Connection = kn.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkid(int Id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool updatePassWord(string user, string pass)
        {
            SqlCommand command = new SqlCommand("UPDATE NhanVien SET PASSWORDS=@pass WHERE USERNAME=@user", kn.GetConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            kn.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                kn.closeConnection();
                return true;
            }
            else
            {
                kn.closeConnection();
                return false;
            }
        }

    }
}
