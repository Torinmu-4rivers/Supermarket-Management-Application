using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHangEntity;
using System.Data;


namespace QuanLyBanHangDAL
{
    public class SQL_customers
    {
        
        KetNoiDB cn = new KetNoiDB();
        // hàm thêm dữ liệu
        public void ThemDuLieu(EC_customers et)
        {
            cn.ThucThiCauLenhSQL("INSERT INTO customers VALUES (" + et.Cust_id + "," + et.Cust_name + "," + et.Cust_gender + "," + et.Cust_dob + "," + et.Cust_phone_number + "," + et.Cust_address + ";");

        }
        //hàm sửa dữ liệu
        public void SuaDuLieu(EC_customers et)
        {
            cn.ThucThiCauLenhSQL(" UPDATE customers SET cust_id = + et.Cust_name + ,cust_gender =  + et.Cust_gender + ,cust_dob= + et.Cust_dob + ,cust_phone_number = + et.Cust_phone_number + ,cust_address= + et.Cust_address +  where cust_id = +et.Cust_id+;");

        }
        //hàm xóa dữ liệu

        public void XoaDuLieu(EC_customers et)
        {
            cn.ThucThiCauLenhSQL(" DELETE from customers where cust_id =  + et.Cust_id + ;");

        }
        //hàm hiển thị dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM customers " + DieuKien);

        }
    }
}
