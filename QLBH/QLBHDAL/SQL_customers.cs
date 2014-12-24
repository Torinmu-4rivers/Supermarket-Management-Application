using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBHEntity;
using System.Data;


namespace QLBHDAL
{
    public class SQL_customers
    {

        KetNoiDB cn = new KetNoiDB();
        // hàm thêm dữ liệu
        
        public void ThemDuLieu(EC_customers et)
        {
            cn.ThucThiCauLenhSQL("INSERT INTO customers VALUES ('" + et.Cust_id + "','" + et.Cust_name + "','" + et.Cust_gender + "','" + et.Cust_address + "','" + et.Cust_phone_number + "')");

        }
        //hàm sửa dữ liệu
        public void SuaDuLieu(EC_customers et)
        {
            cn.ThucThiCauLenhSQL(" UPDATE customers SET cust_name = '" + et.Cust_name + "' ,cust_gender =  '" + et.Cust_gender + "' ,cust_address = '" + et.Cust_address + "' ,cust_phone_number= '" + et.Cust_phone_number + "' where cust_id = '" + et.Cust_id + "';");

        }
        //hàm xóa dữ liệu

        public void XoaDuLieu(EC_customers et)
        {
            cn.ThucThiCauLenhSQL(" DELETE from customers where cust_id =  '"+ et.Cust_id + "';");

        }
        //hàm hiển thị dữ liệu
        public DataSet TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT cust_id as ID,cust_name as \"Họ và tên\", cust_gender as \"Giới tính\", cust_address as \"Địa chỉ\", cust_phone_number as \"Số điện thoại\" FROM customers " + DieuKien);

        }
    }
}
