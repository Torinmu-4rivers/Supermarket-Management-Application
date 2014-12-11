using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace QuanLyBanHangDAL
{
    public class KetNoiDB
    {
        public static NpgsqlConnection connect;
        public static void MoKetNoi()
        {
            if (KetNoiDB.connect == null)
                KetNoiDB.connect = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=QLBH;Password=123456;Database=QLBH;");
            if (KetNoiDB.connect.State != System.Data.ConnectionState.Open)
                KetNoiDB.connect.Open();
        }
        public static void DongKetNoi()
        {
            if (KetNoiDB.connect != null)
                if (KetNoiDB.connect.State == System.Data.ConnectionState.Open)
                    KetNoiDB.connect.Close();
        }

        public void ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                NpgsqlCommand sqlCommand = new NpgsqlCommand(strSQL, connect);
                sqlCommand.ExecuteNonQuery();
                DongKetNoi();

            }
            catch (Exception ex)
            {
            }
        }
        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                DataTable dt = new DataTable();
                MoKetNoi();
                NpgsqlDataAdapter sqlda = new NpgsqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
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
            NpgsqlCommand sqlcmd = new NpgsqlCommand(strSQL, connect);
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

