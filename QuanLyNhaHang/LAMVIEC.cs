using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class LAMVIEC
    {
        KetNoi kn = new KetNoi();
        public bool insertIDLamViec(int Id)
        {
            SqlCommand command = new SqlCommand("INSERT INTO CHIACA (MANV)" +
                " VALUES (@id)", kn.GetConnection);
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

        public bool insertCa(int Id, string t2, string t3, string t4, string t5, string t6, string t7, string cn)
        {
            SqlCommand command = new SqlCommand("INSERT INTO CHIACA (MANV, THU2, THU3, THU4, THU5, THU6, THU7, CN)" +
                " VALUES (@id, @t2, @t3, @t4, @t5, @t6, @t7, @cn)", kn.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.NVarChar).Value = t2;
            command.Parameters.Add("@t3", SqlDbType.NVarChar).Value = t3;
            command.Parameters.Add("@t4", SqlDbType.NVarChar).Value = t4;
            command.Parameters.Add("@t5", SqlDbType.NVarChar).Value = t5;
            command.Parameters.Add("@t6", SqlDbType.NVarChar).Value = t6;
            command.Parameters.Add("@t7", SqlDbType.NVarChar).Value = t7;
            command.Parameters.Add("@cn", SqlDbType.NVarChar).Value = cn;

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

        public bool insertTime(int Id)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TIMELV (MANV)" +
                " VALUES (@id)", kn.GetConnection);
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
        public bool updateTimeStartCa1(int Id, DateTime Ts)
        {
            SqlCommand command = new SqlCommand("UPDATE TIMELV SET TIMESTAR1=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.DateTime).Value = Ts;
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
        public bool updateTimeStartCa2(int Id, DateTime Ts)
        {
            SqlCommand command = new SqlCommand("UPDATE TIMELV SET TIMESTAR2=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.DateTime).Value = Ts;
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
        public bool updateTimeStartCa3(int Id, DateTime Ts)
        {
            SqlCommand command = new SqlCommand("UPDATE TIMELV SET TIMESTAR3=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.DateTime).Value = Ts;
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
        public bool updateTimeEndCa1(int Id, DateTime Te)
        {
            SqlCommand command = new SqlCommand("UPDATE TIMELV SET TIMEEND1=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.DateTime).Value = Te;
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
        public bool updateTimeEndCa2(int Id, DateTime Te)
        {
            SqlCommand command = new SqlCommand("UPDATE TIMELV SET TIMEEND2=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.DateTime).Value = Te;
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
        public bool updateTimeEndCa3(int Id, DateTime Te)
        {
            SqlCommand command = new SqlCommand("UPDATE TIMELV SET TIMEEND3=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.DateTime).Value = Te;
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
        public bool insertLuong(int Id)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LUONGNV (MANV)" +
                " VALUES (@ID)", kn.GetConnection);
            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = Id;

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

        public bool updateLuongThu2(int Id, int luong)
        {
            SqlCommand command = new SqlCommand("UPDATE LUONGNV SET LUONGT2 = @luong WHERE MANV = @Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@luong", SqlDbType.Int).Value = luong;

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
        public bool updateLuongThu3(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LUONGNV SET LUONGT3=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
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
        public bool updateLuongThu4(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LUONGNV SET LUONGT4=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
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
        public bool updateLuongThu5(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LUONGNV SET LUONGT5=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
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
        public bool updateLuongThu6(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LUONGNV SET LUONGT6=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
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
        public bool updateLuongThu7(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LUONGNV SET LUONGT7=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
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
        public bool updateLuongCN(int Id, int Te)
        {
            SqlCommand command = new SqlCommand("UPDATE LUONGNV SET LUONGTCN=@t2 WHERE MANV=@Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Te;
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
        public bool updateTimeDayNew(int Id)
        {
            SqlCommand command = new SqlCommand("UPDATE TIMELV SET TIMESTAR1 = NULL, TIMEEND1 = NULL, TIMESTAR2 = NULL, TIMEEND2 = NULL, TIMESTAR3 = NULL, TIMEEND3 = NULL WHERE MANV = @Id", kn.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.NVarChar).Value = Id;

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
