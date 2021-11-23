using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHBeverage.Model
{
    public class Order
    {
        public int IDOrder { get; set; }
        public int IDCus { get; set; }
        public string DateOrder { get; set; }
        public string Status { get; set; }
        public int Total { get; set; }
        public int Discount { get; set; }
        public int LHcoin { get; set; }
        public int Totalpayment { get; set; }
        public string Reason { get; set; }
        public string Deliverymethod { get; set;}
    }
}
