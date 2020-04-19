using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class clsInvoice
    {
        private string _name ;
        private Int32 _qty ;
        private Int32 _price;
        private Int16 _discount;
        private Int32 _total;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Int32 Qty
        {
            get
            {
                return _qty;
            }
            set
            {
                _qty = value;
            }
        }
        public Int32 Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public Int16 Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
            }
        }
        public Int32 Total
        {
            get
            {
                return _total = Price*Qty;
            }
            set
            {
                _total = value;
            }
        }
       
    }
}
