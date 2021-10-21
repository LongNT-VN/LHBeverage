using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHBeverage.Model
{
    class ProductIngredient
    {
        public int IDIngredient { get; set; }
        public int IDPro { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int TypeIngredient { get; set; }
        public int Price { get; set; }
    }
}
