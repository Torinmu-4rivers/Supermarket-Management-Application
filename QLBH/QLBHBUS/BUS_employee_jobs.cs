using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBHEntity;
using QLBHDAL;

namespace QLBHBUS
{
    public class BUS_employee_jobs
    {
        SQL_employee_jobs sql = new SQL_employee_jobs();
        public void ThemDuLieu(EC_employee_jobs et)
        {
            sql.ThemDuLieu(et);
        }
        public void XoaDuLieu(EC_employee_jobs et)
        {
            sql.XoaDuLieu(et);
        }
        public void SuaDuLieu(EC_employee_jobs et)
        {
            sql.SuaDuLieu(et);
        }
        public DataSet getInfoSEW(string DieuKien)
        {
            return sql.getInfoEW(DieuKien);
        }
    }
}

