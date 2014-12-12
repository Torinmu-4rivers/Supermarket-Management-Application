using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHangEntity;
using QuanLyBanHangDAL;

namespace QuanLyBanHangBUS
{
    public class BUS_orders
    {
        SQL_orders sql = new SQL_orders();
        public void ThemDuLieu(EC_orders et)
        {
            sql.ThemDuLieu(et);
        }
        public void XoaDuLieu(EC_orders et)
        {
            sql.XoaDuLieu(et);
        }
        public void SuaDuLieu(EC_orders et)
        {
            sql.SuaDuLieu(et);
        }
        public DataTable getInfoorders(string DieuKien)
        {
            return sql.getInfoorders(DieuKien);
        }
        public DataTable getInfoKH(string DieuKien)
        {
            return sql.getInfoKH(DieuKien);

        }
        public DataTable getInfoNV(string DieuKien)
        {
            return sql.getInfoNV(DieuKien);
        }     

        public int KiemTraOrders(string order_id)
        {
            return sql.KiemTraOrders(order_id);
        }
    }
}
