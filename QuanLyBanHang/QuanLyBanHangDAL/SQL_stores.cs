using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHangEntity;

namespace QuanLyBanHangDAL
{
    public class SQL_stores
    {
        KetNoiDB cn = new KetNoiDB();
        // hàm thêm dữ liệu
        public void ThemDuLieu(EC_stores et)
        {
            cn.ThucThiCauLenhSQL("INSERT INTO stores VALUES (" + et.Lo_id + "," + et.Prod_id + "," + et.Prod_exp_date + "," + et.Quantity + ";");

        }
        public void SuaDuLieu (EC_stores et)
        {
            cn.ThucThiCauLenhSQL("UPDATE stores SET quantity ='" + et.Quantity + "' where lo_id = '" + et.Lo_id + "' and prod_id = '" + et.Prod_id + "'and prod_exp_date = '" + et.Prod_exp_date + ";");

        }
        public void XoaDuLieu (EC_stores et)
        {
            cn.ThucThiCauLenhSQL("DELETE from stores where lo_id = '" + et.Lo_id + "' and prod_id = '" + et.Prod_id + "'and prod_exp_date = '" + et.Prod_exp_date + ";");
        }
        // hàm hiển thị dữ liệu
        public DataTable getInfoStores(string DieuKien)
        {
            return cn.GetDataTable("select * from stores " + DieuKien);
        }
    }
}
