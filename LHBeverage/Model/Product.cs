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
        public int PriceS { get; set; }
        public int PriceM { get; set; }
        public int PriceL { get; set; }
        public int QuantitysizeS { get; set; }
        public int QuantitysizeM { get; set; }
        public int QuantitysizeL { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
