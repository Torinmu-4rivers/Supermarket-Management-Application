using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHangDAL;
using QuanLyBanHangEntity;

namespace QuanLyBanHangBUS
{
    public class BUS_order_items
    {
        SQL_stores sql = new SQL_stores();
        public void ThemDuLieu(EC_stores et)
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
        public DataTable getInfoorder_items(string DieuKien)
        {
            return sql.getInfooder_items(DieuKien);
        }
    }
}
