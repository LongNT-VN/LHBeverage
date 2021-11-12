using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHBeverage.Model
{
    public class DetailOrder
    {
        public int IDDetailOrder { get; set; }
        public int IDOrder { get; set; }
        public int IDPro { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public string Topping { get; set; }
        public int Price { get; set; }
    }
}
