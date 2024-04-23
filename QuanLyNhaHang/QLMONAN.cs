using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace QuanLyNhaHang
{
    public class QLMONAN
    {
        KetNoi kn = new KetNoi();


        // create a function to insert BanAn
        public bool insertMonAn(string Id, string tenmon,string giaban, int soluong)
        {
            SqlCommand command = new SqlCommand(" INSERT INTO QLMON (MAMON,TENMON, GIABAN,SOLUONG) " +
                " VALUES (@id, @tenm, @gia, @sl) ", kn.GetConnection);

            command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            command.Parameters.Add("@tenm", SqlDbType.NVarChar).Value = tenmon;
            command.Parameters.Add("@gia", SqlDbType.Money).Value = giaban;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;


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
        public int getSLMon(string tenmon)
        {
            int sl=0;
            string query = "SELECT SOLUONG FROM QLMON WHERE TENMON = @tenm";
            SqlCommand command = new SqlCommand(query, kn.GetConnection);
            command.Parameters.AddWithValue("@tenm", tenmon);
            kn.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                sl = reader.GetInt32(0);
                kn.closeConnection();
                return sl;
            }
            else
            {
                kn.closeConnection();
                return 0;
            }
        }
        // check name
        public bool checkTenMonAn(string tenmon, int Id = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM QLMON WHERE TENMON = @tenm AND MAMON = @id", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@tenm", SqlDbType.NVarChar).Value = tenmon;
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

        public bool deleteMonAn(string tenmon)
        {
            SqlCommand command = new SqlCommand("DELETE FROM QLMON WHERE TENMON=@tenm", kn.GetConnection);
            command.Parameters.Add("tenm", SqlDbType.NVarChar).Value = tenmon;
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

        public bool updateMonAn(string tenmon, string giaban, int soluong)
        {
            SqlCommand command = new SqlCommand(" UPDATE QLMON SET GIABAN=@gia, SOLUONG=@sl  WHERE TENMON= @tenm", kn.GetConnection);

            command.Parameters.Add("@tenm", SqlDbType.NVarChar).Value = tenmon;
            command.Parameters.Add("@gia", SqlDbType.Money).Value = giaban;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;

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
        public bool updateSLMonAn(string tenmon, int soluong)
        {
            SqlCommand command = new SqlCommand(" UPDATE QLMON SET SOLUONG=@sl  WHERE TENMON = @ten", kn.GetConnection);

            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = tenmon;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;

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

        public DataTable getMonAn(SqlCommand command)
        {
            command.Connection = kn.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        /*
        public bool insertMonAnTop(string tenmon, int soluong)
        {
            SqlCommand command = new SqlCommand(" INSERT INTO MonTop (MonTop,SoLuong) " +
               " VALUES (@tenm,@sl) ", kn.GetConnection);


            command.Parameters.Add("@tenm", SqlDbType.VarChar).Value = tenmon;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;


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
    }
}
