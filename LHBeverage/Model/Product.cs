using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHBeverage.Model
{
    public class Product
    {
        public int IDPro { get; set; }
        public int IDCate { get; set; }
        public int IDCust { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
