using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangEntity
{
    class EC_stores
    {
        private string _lo_id;

        public string Lo_id
        {
            get { return _lo_id; }
            set { _lo_id = value; }
        }
        private string _prod_id;

        public string Prod_id
        {
            get { return _prod_id; }
            set { _prod_id = value; }
        }
        private string _prod_exp_date;

        public string Prod_exp_date
        {
            get { return _prod_exp_date; }
            set { _prod_exp_date = value; }
        }
        private string _quantity;

        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
    }
}
