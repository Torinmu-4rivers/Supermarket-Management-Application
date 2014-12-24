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
    public class BUS_order_items
    {
        SQL_order_items sql = new SQL_order_items();
        public void ThemDuLieu(EC_order_items et)
        {
            sql.ThemDuLieu(et);
        }
        public void XoaDuLieu(EC_order_items et)
        {
            sql.XoaDuLieu(et);
        }
        public void SuaDuLieu(EC_order_items et)
        {
            sql.SuaDuLieu(et);
        }
        public DataSet getInfoorder_items(string DieuKien)
        {
            return sql.getInfooorder_items(DieuKien);
        }
    }
}
