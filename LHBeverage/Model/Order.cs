using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHBeverage.Model
{
    class Order
    {
        public int IDOrder { get; set; }
        public int IDCus { get; set; }
        public DateTime DateOrder { get; set; }
        public string Status { get; set; }
        public int Total { get; set; }
        public int Discount { get; set; }
        public string LHcoin { get; set; }
        public int Totalpayment { get; set; }
    }
}
