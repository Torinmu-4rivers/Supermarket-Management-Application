﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBHEntity;

namespace QLBHDAL
{
    public class SQL_employees
    {
        KetNoiDB cn = new KetNoiDB();

        public void ThemDuLieu(EC_employees et)
        {
            cn.ThucThiCauLenhSQL("INSERT INTO employees VALUES ('" + et.Employ_id + "','" + et.Employ_name + "," + et.Employ_gender + "','" + et.Employ_age + "','" + et.Employ_phone_number + "','" + et.Employ_address + "','" + et.Employ_workstart_date + "','" + et.Employ_id_number + "')");
        }
        public void SuaDulieu(EC_employees et)
        {
            cn.ThucThiCauLenhSQL("UPDATE employees SET employ_name ='" + et.Employ_name + "',employ_gender = '" + et.Employ_gender + "',employ_age='" + et.Employ_age + "',employ_address = '" + et.Employ_address + "',employ_work_start_date = '" + et.Employ_workstart_date + "',user_id = '"+et.User_id+"' where employ_id = '" + et.Employ_id + "';");
            /*,employ_phone_number ='" + et.Employ_phone_number + "'*/
        }
        public void XoaDuLieu(EC_employees et)
        {
            cn.ThucThiCauLenhSQL("DELETE from employees where employ_id ='" + et.Employ_id + "'");
        }
        public DataSet getInfoNV(string DieuKien)
        {
            return cn.GetDataTable("select * from employees " + DieuKien);
        }

    }
}
