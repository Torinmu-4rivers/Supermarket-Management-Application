using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangEntity
{
    class EC_deliveries
    {
        private string _order_id;

        public string Order_id
        {
            get { return _order_id; }
            set { _order_id = value; }
        }
        private string _deli_employ_id;

        public string Deli_employ_id
        {
            get { return _deli_employ_id; }
            set { _deli_employ_id = value; }
        }
        private string _deli_address;

        public string Deli_address
        {
            get { return _deli_address; }
            set { _deli_address = value; }
        }
        private string _deli_date;

        public string Deli_date
        {
            get { return _deli_date; }
            set { _deli_date = value; }
        }
        private string _deli_time;

        public string Deli_time
        {
            get { return _deli_time; }
            set { _deli_time = value; }
        }
        private string _deli_status;

        public string Deli_status
        {
            get { return _deli_status; }
            set { _deli_status = value; }
        }
    }
}
