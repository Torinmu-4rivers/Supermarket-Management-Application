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
    public class BUS_stores
    {
        SQL_stores sql = new SQL_stores();
        public void ThemDuLieu(EC_stores et)
        {
            sql.ThemDuLieu(et);
        }
        public void XoaDuLieu(EC_stores et)
        {
            sql.XoaDuLieu(et);
        }
        public void SuaDuLieu(EC_stores et)
        {
            sql.SuaDuLieu(et);
        }
        public DataTable getInfoStores(string DieuKien)
        {
            return sql.getInfoStores(DieuKien);
        }
    }
}
