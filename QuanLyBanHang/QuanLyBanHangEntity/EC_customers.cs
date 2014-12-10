using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangEntity
{
    public class EC_customers
    {
        private string _cust_id;

        public string Cust_id
        {
            get { return _cust_id; }
            set { _cust_id = value; }
        }
        private string _cust_name;

        public string Cust_name
        {
            get { return _cust_name; }
            set { _cust_name = value; }
        }
        private string _cust_gender;

        public string Cust_gender
        {
            get { return _cust_gender; }
            set { _cust_gender = value; }
        }
        private string _cust_dob;

        public string Cust_dob
        {
            get { return _cust_dob; }
            set { _cust_dob = value; }
        }
        private string _cust_phone_number;

        public string Cust_phone_number
        {
            get { return _cust_phone_number; }
            set { _cust_phone_number = value; }
        }
        private string _cust_address;

        public string Cust_address
        {
            get { return _cust_address; }
            set { _cust_address = value; }
        }
    }
}
