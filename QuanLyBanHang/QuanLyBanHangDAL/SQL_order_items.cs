using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHangEntity;

namespace QuanLyBanHangDAL
{
    class SQL_order_items
    {
        KetNoiDB cn = new KetNoiDB();
        // them du lieu
        public void ThemDuLieu(EC_order_items et)
        {
            cn.ThucThiCauLenhSQL("INSERT INTO store_items VALUES(" + et.Order_id +"," + et.Lo_id +"," + et.Prod_id +"," + et.Order_prod_quantity+"," + et.Order_address+";");
        }
        //update
        public void SuaDuLieu(EC_order_items et)
        {
            cn.ThucThiCauLenhSQL("UPDATE order_items SET lo_id = '" + et.Lo_id + "',prod_id = '" + et.Prod_id + "',order_prod_quantity ='" + et.Order_prod_quantity + "',order_address '" + et.Order_address + " where order_id = '" + et.Order_id + "';");

        }
        //xoa
        public void XoaDuLieu(EC_order_items et)
        {
            cn.ThucThiCauLenhSQL("DELETE from order_items where order_id = '" + et.Order_id + "';");
        }
        //hien thi
        public DataTable getInfooorder_items(string DieuKien)
        {
            return cn.GetDataTable("select * from order_items " + DieuKien);
        }
    }
}