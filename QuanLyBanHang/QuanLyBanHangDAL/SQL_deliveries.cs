using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHangEntity;

namespace QuanLyBanHangDAL
{
    class SQL_deliveries
    {
        KetNoiDB cn = new KetNoiDB();
        public void ThemDuLieu (EC_deliveries et)
        {
            cn.ThucThiCauLenhSQL("INSERT INTO deliveries VALUES (" + et.Order_id + "," + et.Deli_employ_id + "," + et.Deli_address + "," + et.Deli_date + "," + et.Deli_time + "," + et.Deli_status + ";");

        }
        public void SuaDuLieu (EC_deliveries et)
        {
            cn.ThucThiCauLenhSQL("UPDATE deliveries SET deli_employ_id ='" + et.Deli_employ_id + "',delivery_address = '" + et.Deli_address + "',delivery_date='" + et.Deli_date + "',delivery_time ='" + et.Deli_time + "',delivery_status = '" + et.Deli_status + "' where order_id = '" + et.Order_id + "';");
        }
        public void XoaDuLieu (EC_deliveries et)
        {
            cn.ThucThiCauLenhSQL("DELETE from deliveries where order_id = '" + et.Order_id + "'");

        }
        public DataTable getInfoDeli (string DieuKien)
        {
            return cn.GetDataTable("select * from deliveries" + DieuKien);
        }
        public DataTable getInfoorder (string DieuKien)
        {
            return cn.GetDataTable("select order_id,cust_id from orders" + DieuKien);
        }
    }
}
