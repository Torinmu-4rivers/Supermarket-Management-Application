using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBHEntity;
using QLBHDAL;

namespace QLBHBUS
{
    public class BUS_customers
    {
        SQL_customers sql = new SQL_customers();
        public void ThemDuLieu(EC_customers et)
        {
            sql.ThemDuLieu(et);
        }
        public void XoaDuLieu(EC_customers et)
        {
            sql.XoaDuLieu(et);
        }
        public void SuaDuLieu(EC_customers et)
        {
            sql.SuaDuLieu(et);
        }
        public DataSet TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
