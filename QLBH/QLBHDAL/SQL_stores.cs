using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBHEntity;

namespace QLBHDAL
{
    public class SQL_stores
    {
        KetNoiDB cn = new KetNoiDB();
        // hàm thêm dữ liệu
        public void ThemDuLieu(EC_stores et)
        {
            cn.ThucThiCauLenhSQL("INSERT INTO stores VALUES ('" + et.Lo_id + "','" + et.Prod_id + "','" + et.Prod_exp_date + "','" + et.Quantity + "','"+et.Prod_exp_price+"','"+et.Prod_date+"')");

        }
        public void SuaDuLieu(EC_stores et)
        {
            cn.ThucThiCauLenhSQL("UPDATE stores SET quantity ='" + et.Quantity + "',prod_exp_date='" + et.Prod_exp_date + "',prod_exp_price ='" + et.Prod_exp_price + "' where lo_id = '" + et.Lo_id + "' and prod_id = '" + et.Prod_id + "' and prod_date = '" + et.Prod_date + "';");

        }
        public void XoaDuLieu(EC_stores et)
        {
            cn.ThucThiCauLenhSQL("DELETE from stores where lo_id = '" + et.Lo_id + "';");
        }
        public DataSet getInfoStores(string DieuKien)
        {
            return cn.GetDataTable("select * from stores " + DieuKien);
        }
    }
}
