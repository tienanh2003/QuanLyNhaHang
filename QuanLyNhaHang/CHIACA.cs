using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class CHIACA
    {
        KetNoi kn = new KetNoi();
        public bool updateCaLam(int Id, int Thu2, int Thu3, int Thu4, int Thu5, int Thu6, int Thu7, int CN)
        {
            SqlCommand command = new SqlCommand("UPDATE CHIACA SET THU2=@t2, THU3=@t3, THU4=@t4, THU5=@t5, THU6=@t6, THU7=@t7, CN=@cn WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Thu2;
            command.Parameters.Add("@t3", SqlDbType.Int).Value = Thu3;
            command.Parameters.Add("@t4", SqlDbType.Int).Value = Thu4;
            command.Parameters.Add("@t5", SqlDbType.Int).Value = Thu5;
            command.Parameters.Add("@t6", SqlDbType.Int).Value = Thu6;
            command.Parameters.Add("@t7", SqlDbType.Int).Value = Thu7;
            command.Parameters.Add("@cn", SqlDbType.Int).Value = CN;
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
        public bool updateLamHo2(int Id, int THU2)
        {
            SqlCommand command = new SqlCommand("UPDATE CHIACA SET THU2=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = THU2;
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
        public bool updateLamHo3(int Id, int THU2)
        {
            SqlCommand command = new SqlCommand("UPDATE CHIACA SET THU3=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = THU2;
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
        public bool updateLamHo4(int Id, int THU2)
        {
            SqlCommand command = new SqlCommand("UPDATE CHIACA SET THU4=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = THU2;
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
        public bool updateLamHo5(int Id, int THU2)
        {
            SqlCommand command = new SqlCommand("UPDATE CHIACA SET THU5=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = THU2;
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
        public bool updateLamHo6(int Id, int THU2)
        {
            SqlCommand command = new SqlCommand("UPDATE CHIACA SET THU6=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = THU2;
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
        public bool updateLamHo7(int Id, int THU2)
        {
            SqlCommand command = new SqlCommand("UPDATE CHIACA SET THU7=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = THU2;
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
        public bool updateLamHoCN(int Id, int THU2)
        {
            SqlCommand command = new SqlCommand("UPDATE CHIACA SET CN=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = THU2;
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
