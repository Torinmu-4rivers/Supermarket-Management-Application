using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHEntity
{
    public class EC_products
    {
        private string _prod_id;

        public string Prod_id
        {
            get { return _prod_id; }
            set { _prod_id = value; }
        }
        private string _prod_name;

        public string Prod_name
        {
            get { return _prod_name; }
            set { _prod_name = value; }
        }
        private string _prod_color;

        public string Prod_color
        {
            get { return _prod_color; }
            set { _prod_color = value; }
        }
        private string _prod_price;

        public string Prod_price
        {
            get { return _prod_price; }
            set { _prod_price = value; }
        }
        private string _prod_size;

        public string Prod_size
        {
            get { return _prod_size; }
            set { _prod_size = value; }
        }
        private string _prod_description;

        public string Prod_description
        {
            get { return _prod_description; }
            set { _prod_description = value; }
        }
    }
}
