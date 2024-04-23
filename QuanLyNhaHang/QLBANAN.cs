using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public class QLBANAN
    {
        KetNoi kn= new KetNoi();

        public bool insertBanAn(string Id, string tenban, int soluong, float giaban, int tinhtrang)
        {
            SqlCommand command = new SqlCommand(" INSERT INTO QLBAN (MABAN, TENBAN, SOLUONG, GIABAN, TINHTRANG) " +
                " VALUES (@id, @tenb, @sl, @gia, @tt) ", kn.GetConnection);

            command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            command.Parameters.Add("@tenb", SqlDbType.VarChar).Value = tenban;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = giaban;
            command.Parameters.Add("@tt", SqlDbType.Int).Value = tinhtrang;

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

        // check name
        public bool checkTenBanAn(string tenban, int Id = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM QLBAN WHERE TENBAN = @tenb AND MABAN = @id", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@tenb", SqlDbType.VarChar).Value = tenban;
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

        public bool deleteBanAn(string tenban)
        {
            SqlCommand command = new SqlCommand("DELETE FROM QLBAN WHERE TENBAN=@tenb", kn.GetConnection);
            command.Parameters.Add("tenb", SqlDbType.VarChar).Value = tenban;
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

        public bool updateBanAn(string tenban, int soluong, string giaban, int tinhtrang)
        {
            SqlCommand command = new SqlCommand(" UPDATE QLBAN SET SOLUONG=@sl, GIABAN=@gia, TINHTRANG=@tt WHERE TENBAN= @tenb", kn.GetConnection);

            //command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@tenb", SqlDbType.VarChar).Value = tenban;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = giaban;
            command.Parameters.Add("@tt", SqlDbType.Int).Value = tinhtrang;

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
        public bool updateBanAnTrong(string Id, int tinhtrang)
        {
            SqlCommand command = new SqlCommand("UPDATE QLBAN SET TINHTRANG=@tt WHERE MABAN=@Id", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            command.Parameters.Add("@tt", SqlDbType.Int).Value = tinhtrang;

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
        public DataTable getBanAn(SqlCommand command)
        {

            SqlCommand command1 = new SqlCommand("SELECT * FROM QLBAN", kn.GetConnection);
            command1.Connection = kn.GetConnection;
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            return table1;

        }
        public DataTable getBanTrong()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM QLBAN WHERE TINHTRANG = 1", kn.GetConnection);
            command.Connection = kn.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        /*
        public bool insertDoanhThuBan(string iknan, int giatien, DateTime date)
        {
            SqlCommand command = new SqlCommand(" INSERT INTO DOANHTHUBAN (IDBAN,SOTIEN,THOIGIAN) " +
                " VALUES ( @tenb, @sl,@dt) ", kn.GetConnection);

            command.Parameters.Add("@tenb", SqlDbType.VarChar).Value = iknan;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = giatien;
            command.Parameters.Add("@dt", SqlDbType.DateTime).Value = date;
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
        */
        public bool insertDoanhThuBan(string iknan, int giatien, DateTime date)
        {
            Random x = new Random();
            SqlCommand command = new SqlCommand("INSERT INTO DANHTHUBAN (ID, IDBAN, SOTIEN, THOIGIAN) " +
                                                "VALUES (@ma, @tenb, @sl, @dt)", kn.GetConnection);

            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = x.Next().ToString();
            command.Parameters.Add("@tenb", SqlDbType.VarChar).Value = iknan;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = giatien;
            command.Parameters.Add("@dt", SqlDbType.DateTime).Value = date;
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

    }
}
