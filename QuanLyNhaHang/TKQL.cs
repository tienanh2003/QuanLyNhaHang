using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class TKQL
    {
        KetNoi kn = new KetNoi();
        public bool insertTKQL(int id,string Username, string Password, string name, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TKQL (ID,USERNAME,PASSWORDS,HOTEN,EMAIL)" +
                " VALUES (@id,@user, @pass, @ten, @em)", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@em", SqlDbType.VarChar).Value = email;

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
        public bool updateTKQL(int id, string Username, string Password, string name, string email)
        {
            SqlCommand command = new SqlCommand("UPDATE TKQL SET USERNAME = @user, PASSWORDS = @pass, HOTEN = @ten, EMAIL = @em WHERE ID = @id", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@em", SqlDbType.VarChar).Value = email;

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

        public bool deleteTKQL(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM TKQL WHERE ID = @id", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
