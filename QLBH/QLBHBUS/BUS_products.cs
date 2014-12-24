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
    public class BUS_products
    {
        SQL_products sql = new SQL_products();
        public void ThemDuLieu(EC_products et)
        {
            sql.ThemDuLieu(et);
        }
        public void XoaDuLieu(EC_products et)
        {
            sql.XoaDuLieu(et);
        }
        public void SuaDuLieu(EC_products et)
        {
            sql.SuaDuLieu(et);
        }
        public DataSet getInfoSP(string DieuKien)
        {
            return sql.getInfoSP(DieuKien);
        }
    }
}
