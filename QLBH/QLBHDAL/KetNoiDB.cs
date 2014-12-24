using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace QLBHDAL
{
    public class KetNoiDB
    {
        public static NpgsqlConnection connect;
        static string connectionString =
           "Server=localhost;" +
           "Database=QLBH;" +
           "User ID=postgres;" +
           "Password=123456;";
        public void MoKetNoi()
        {
            KetNoiDB.connect = new NpgsqlConnection(connectionString);
            KetNoiDB.connect.Open();
        }
        public void DongKetNoi()
        {
            if (KetNoiDB.connect != null)
            {
                if (KetNoiDB.connect.State == ConnectionState.Open)
                    KetNoiDB.connect.Close();
            }
        }

        public void ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                NpgsqlCommand cmd = new NpgsqlCommand(strSQL);
                cmd.Connection = connect;
                cmd.ExecuteNonQuery();
                DongKetNoi();

            }
            catch
            {
                
            }
        }
        public DataSet GetDataTable(string strSQL)
        {
            try
            {
                MoKetNoi();
                NpgsqlCommand cmd = new NpgsqlCommand(strSQL);
                DataSet dt = new DataSet();
                NpgsqlDataAdapter sqlda = new NpgsqlDataAdapter();
                sqlda.SelectCommand = cmd;
                cmd.Connection = connect;
                sqlda.Fill(dt,"table");
                return dt;
            }
            catch
            {
                return null;
            }

        }

        public string GetValue(string strSQL)
        {
            string tmp = null;
            MoKetNoi();
            NpgsqlCommand sqlcmd = new NpgsqlCommand(strSQL);
            NpgsqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
            {
                tmp = sqldr[0].ToString();
            }
            DongKetNoi();

            return tmp;
        }
    }
}
