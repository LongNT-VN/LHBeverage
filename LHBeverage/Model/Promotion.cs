using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHBeverage.Model
{
    class Promotion
    {
        public int IDCode { get; set; }
        public int Discount { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public int Quantity { get; set; }
    }
}
