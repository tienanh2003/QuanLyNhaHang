using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class DOANHTHU
    {
        KetNoi kn = new KetNoi();

        // create a function to insert BanAn
        public bool insertDoanhThu(string id, string idBan, string tenMonHD, int soLuong, int giaThanh, DateTime thoigian)
        {
            SqlCommand command = new SqlCommand("INSERT INTO DOANHTHU (ID, IDBAN, TENMONHD, SOLUONG, GIATHANH, THOIGIAN) " +
            "VALUES (@id, @idBan, @tenMonHD, @soLuong, @giaThanh, @thoigian)", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@idBan", SqlDbType.NVarChar).Value = idBan;
            command.Parameters.Add("@tenMonHD", SqlDbType.NVarChar).Value = tenMonHD;
            command.Parameters.Add("@soLuong", SqlDbType.Int).Value = soLuong;
            command.Parameters.Add("@giaThanh", SqlDbType.Money).Value = giaThanh;
            command.Parameters.Add("@thoigian", SqlDbType.DateTime).Value = thoigian;

            kn.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
        /*
        // check id hoa don gọi món tiếp tục
        public bool checkTenIDHD(string idhd)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM DoanhThu WHERE Id <> @idhd", kn.GetConnection);
            //command.Parameters.Add("@ikn", SqlDbType.VarChar).Value = Iknan;
            command.Parameters.Add("@idhd", SqlDbType.VarChar).Value = idhd;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                kn.closeConnection();
                return false;
            }
            else
            {
                kn.closeConnection();
                return true;
            }
        }


        // check id ban dat lai
        public bool checkTenIknan(string Iknan)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM DoanhThu WHERE iknan<>@ikn", kn.GetConnection);
            command.Parameters.Add("@ikn", SqlDbType.VarChar).Value = Iknan;
            //command.Parameters.Add("@idhd", SqlDbType.VarChar).Value = idhd;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                kn.closeConnection();
                return false;
            }
            else
            {
                kn.closeConnection();
                return true;
            }
        }
        */

        public bool deleteMonAn(string tenm)
        {
            SqlCommand command = new SqlCommand("DELETE FROM DOANHTHU WHERE TENMONHD=@tenm", kn.GetConnection);
            command.Parameters.Add("tenm", SqlDbType.VarChar).Value = tenm;
            kn.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public bool deleteHoaDon(string idban)
        {
            SqlCommand command = new SqlCommand("DELETE FROM DOANHTHU WHERE IDBAN=@idb", kn.GetConnection);
            command.Parameters.Add("idb", SqlDbType.VarChar).Value = idban;
            kn.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public bool deleteDoanhThu(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM DOANHTHU WHERE ID = @id", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            kn.openConnection();
            if (command.ExecuteNonQuery() == 1)
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

        public bool updateDoanhThu(string id,string tenmon, int soLuong, int giaThanh, DateTime thoigian)
        {
            SqlCommand command = new SqlCommand("UPDATE DOANHTHU SET TENMONHD=@tenmon, SOLUONG = @soLuong, GIATHANH = @giaThanh, THOIGIAN = @thoigian WHERE ID = @id", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@tenmon", SqlDbType.NVarChar).Value = tenmon;
            command.Parameters.Add("@soLuong", SqlDbType.Int).Value = soLuong;
            command.Parameters.Add("@giaThanh", SqlDbType.Money).Value = giaThanh;
            command.Parameters.Add("@thoigian", SqlDbType.DateTime).Value = thoigian;
            kn.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        public DataTable getDoanhThu(SqlCommand command)
        {
            command.Connection = kn.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }
}
