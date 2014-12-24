using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHEntity
{
    public class EC_orders
    {
        private string _order_id;

        public string Order_id
        {
            get { return _order_id; }
            set { _order_id = value; }
        }
        private string _cust_id;

        public string Cust_id
        {
            get { return _cust_id; }
            set { _cust_id = value; }
        }
        private string _order_date;

        public string Order_date
        {
            get { return _order_date; }
            set { _order_date = value; }
        }
        private string _order_payment_date;

        public string Order_payment_date
        {
            get { return _order_payment_date; }
            set { _order_payment_date = value; }
        }
        private string _order_employee_id;

        public string Order_employee_id
        {
            get { return _order_employee_id; }
            set { _order_employee_id = value; }
        }
        private string _order_payment_method;

        public string Order_payment_method
        {
            get { return _order_payment_method; }
            set { _order_payment_method = value; }
        }
    }
}
