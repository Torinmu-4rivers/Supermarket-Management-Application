using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHangEntity;

namespace QuanLyBanHangDAL
{
    public class SQL_orders
    {
        KetNoiDB cn = new KetNoiDB();
        // hàm thêm dữ liệu
        //hàm kiểm tra, nếu trong table orders chưa có bản ghi
        //thì hig báo  hayx add thêm bản ghi, có rồi thì thôi
     
        public int KiemTraOrders(string order_id)
        {
            return int.Parse(cn.GetValue("select count(*) from orders where order_id = '" + order_id + ""));
        }
        public void ThemDuLieu(EC_orders et )
        {
            cn.ThucThiCauLenhSQL("INSERT INTO orders VALUES (" + et.Order_id + "," + et.Cust_id + "," + et.Order_date + "," + et.Order_payment_date + "," + et.Order_employee_id + "," + et.Order_payment_method + ";");

        }
        //hàm sửa dữ liệu
        public void SuaDuLieu(EC_orders et)
        {
            cn.ThucThiCauLenhSQL(" UPDATE customers SET cust_id ='" + et.Cust_id + "',order_date = '" + et.Order_date + "',order_payment_date='" + et.Order_payment_date + "',order_employee_id ='" + et.Order_employee_id + "',order_payment_method='" + et.Order_payment_method + "' where order_id = '" + et.Order_id + "';");

        }
        //hàm xóa dữ liệu

        public void XoaDuLieu(EC_orders et)
        {
            cn.ThucThiCauLenhSQL(" DELETE from orders where order_id = '" + et.Order_id + "';");

        }
        //hàm hiển thị thông tin orders
        public DataTable getInfoorders(string DieuKien)
        {
            return cn.GetDataTable("select * from orders "+DieuKien); 
        }

        //hàm hiển thị thông tin khách hàng
        public DataTable getInfoKH(string DieuKien)
        {
            return cn.GetDataTable("SELECT cust_id,cust_name FROM customers " + DieuKien);

        }
        // hàm hiển thị thông tin nhân viên
        public DataTable getInfoNV(string DieuKien)
        {
            return cn.GetDataTable("SELECT employ_id,employ_name FROM employees " + DieuKien);

        }
    }
}
