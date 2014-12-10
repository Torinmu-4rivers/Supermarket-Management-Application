using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangEntity
{
    class EC_order_items
    {
        private string _order_id;

        public string Order_id
        {
            get { return _order_id; }
            set { _order_id = value; }
        }
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
        private string _order_prod_quantity;

        public string Order_prod_quantity
        {
            get { return _order_prod_quantity; }
            set { _order_prod_quantity = value; }
        }
        private string _order_address;

        public string Order_address
        {
            get { return _order_address; }
            set { _order_address = value; }
        }
    }
}
