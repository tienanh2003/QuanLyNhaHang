using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class HOADON
    {
        KetNoi kn = new KetNoi();

        // create a function to insert BanAn
        public bool insertHoaDon(string maHoaDon,string maban, string tenmon,int soluong, int giathanh, DateTime ngayLap)
        {
            SqlCommand command = new SqlCommand("INSERT INTO HOADON (MAHOADON,MABAN,TENMON,SOLUONG, GIATHANH,NGAYLAP) " +
                                                "VALUES (@maHoaDon,@maban, @tenmon,@soluong ,@giathanh,@ngayLap)", kn.GetConnection);

            command.Parameters.Add("@maHoaDon", SqlDbType.NVarChar).Value = maHoaDon;
            command.Parameters.Add("@maban", SqlDbType.NVarChar).Value = maban;
            command.Parameters.Add("@tenmon", SqlDbType.NVarChar).Value = tenmon;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@giathanh", SqlDbType.Money).Value = giathanh;
            command.Parameters.Add("@ngayLap", SqlDbType.Date).Value = ngayLap;
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
            SqlCommand command = new SqlCommand("SELECT * FROM HoaDon WHERE Id <> @idhd", kn.GetConnection);
            //command.Parameters.Add("@ikn", SqlknType.VarChar).Value = Iknan;
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
            SqlCommand command = new SqlCommand("SELECT * FROM HoaDon WHERE iknan<>@ikn", kn.GetConnection);
            command.Parameters.Add("@ikn", SqlDbType.VarChar).Value = Iknan;
            //command.Parameters.Add("@idhd", SqlknType.VarChar).Value = idhd;
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
            SqlCommand command = new SqlCommand("DELETE FROM HOADON WHERE TENMON=@tenm", kn.GetConnection);
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
        
        public bool deleteHoaDon(string maHoaDon)
        {
            SqlCommand command = new SqlCommand("DELETE FROM HOADON WHERE MAHOADON = @maHoaDon", kn.GetConnection);
            command.Parameters.Add("@maHoaDon", SqlDbType.NVarChar).Value = maHoaDon;
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
        public bool updateHoaDon(string maHoaDon, string maban, string tenmon, int soluong, int giathanh, DateTime ngayLap)
        {
            SqlCommand command = new SqlCommand("UPDATE HOADON SET MABAN = @maban, TENMON = @tenmon, SOLUONG = @soluong, GIATHANH = @giathanh, NGAYLAP = @ngayLap WHERE MAHOADON = @maHoaDon", kn.GetConnection);
            command.Parameters.Add("@maHoaDon", SqlDbType.NVarChar).Value = maHoaDon;
            command.Parameters.Add("@maban", SqlDbType.NVarChar).Value = maban;
            command.Parameters.Add("@tenmon", SqlDbType.NVarChar).Value = tenmon;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@giathanh", SqlDbType.Money).Value = giathanh;
            command.Parameters.Add("@ngayLap", SqlDbType.Date).Value = ngayLap;
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
        public DataTable getHoaDon(SqlCommand command)
        {
            command.Connection = kn.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
