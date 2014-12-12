using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHangEntity;

namespace QuanLyBanHangDAL
{
    class SQL_products
    {
        KetNoiDB cn = new KetNoiDB();
        // hàm thêm dữ liệu
        public void ThemDuLieu(EC_products et)
        {
            cn.ThucThiCauLenhSQL("INSERT INTO products VALUES (" + et.Prod_id + "," + et.Prod_name + "," + et.Prod_color + "," + et.Prod_size + "," + et.Prod_size + "," + et.Prod_description + ";");

        }
        // sửa dữ liệu
        public void SuaDuLieu (EC_products et)
        {
            cn.ThucThiCauLenhSQL(" UPDATE products SET prod_name ='" + et.Prod_name + "',prod_color = '" + et.Prod_color + "',prod_size='" + et.Prod_size + "',prod_description ='" + et.Prod_description + "' where prod_id = '" + et.Prod_id + "';");
        }
        // xóa dữ liệu
        public void XoaDuLieu (EC_products et)
        {
            cn.ThucThiCauLenhSQL("DELETE  from products where prod_id = '" + et.Prod_id + "';");
        }
        //hàm hiển thị dữ liệu

        public DataTable getInfoSP(string DieuKien)
        {
            return cn.GetDataTable("Select * from products " + DieuKien);
        }
    }
}
