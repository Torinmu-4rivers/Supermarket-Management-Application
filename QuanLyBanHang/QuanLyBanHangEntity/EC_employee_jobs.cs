using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangEntity
{
    class EC_employee_jobs
    {
        private string _ew_id;

        public string Ew_id
        {
            get { return _ew_id; }
            set { _ew_id = value; }
        }
        private string _ew_name;

        public string Ew_name
        {
            get { return _ew_name; }
            set { _ew_name = value; }
        }
        private string ew_description;

        public string Ew_description
        {
            get { return ew_description; }
            set { ew_description = value; }
        }
    }
}
