using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHBeverage.Model
{
    public class Topping
    {
        public int IDTopping { get; set; }
        public int IDCate { get; set; }
        public string ToppingName { get; set; }
        public int Price { get; set; }
    }
}
