using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHangEntity;

namespace QuanLyBanHangDAL
{
    public class SQL_employee_jobs
    {
        KetNoiDB cn = new KetNoiDB();
        public void ThemDuLieu(EC_employee_jobs et)
        {
            cn.ThucThiCauLenhSQL("INSERT INTO employee_jobs VALUES (" + et.Ew_id + "," + et.Ew_name + "," + et.Ew_description + ";");

        }
        public void SuaDuLieu(EC_employee_jobs et)
        {
            cn.ThucThiCauLenhSQL("UPDATE employee_jobs SET ew_name = '" + et.Ew_name + "', ew_description = '" + et.Ew_description + "' where ew_id = '" + et.Ew_id + "'");

        }
        public void XoaDuLieu(EC_employee_jobs et)
        {
            cn.ThucThiCauLenhSQL("DELETE from employee_jobs where ew_id='" + et.Ew_id + "'");

        }
        public DataTable getInfoEW(string DieuKien)
        {
            return cn.GetDataTable("select * from employee_jobs " + DieuKien);
        }
    }
}