using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBHDAL;
using QLBHEntity;

namespace QLBHBUS
{
    public class BUS_deliveries
    {
        SQL_deliveries sql = new SQL_deliveries();
        public void ThemDuLieu(EC_deliveries et)
        {
            sql.ThemDuLieu(et);
        }
        public void XoaDuLieu(EC_deliveries et)
        {
            sql.XoaDuLieu(et);
        }
        public void SuaDuLieu(EC_deliveries et)
        {
            sql.SuaDuLieu(et);
        }
        public DataSet getInfoDeli(string DieuKien)
        {
            return sql.getInfoDeli(DieuKien);
        }
        public DataSet getInfoorder(string DieuKien)
        {
            return sql.getInfoorder(DieuKien);
        }
    }
}
