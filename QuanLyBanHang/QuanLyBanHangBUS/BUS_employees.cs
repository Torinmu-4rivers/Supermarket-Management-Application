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
    public class BUS_employees
    {
        SQL_employees sql = new SQL_employees();
        public void ThemDuLieu(EC_employees et)
        {
            sql.ThemDuLieu(et);
        }
        public void XoaDuLieu(EC_employees et)
        {
            sql.XoaDuLieu(et);
        }
        public void SuaDuLieu(EC_employees et)
        {
            sql.SuaDuLieu(et);
        }
        public DataTable getInfoNV(string DieuKien)
        {
            return sql.getInfoNV(DieuKien);
        }     
    }
}
