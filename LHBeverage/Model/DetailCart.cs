using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHBeverage.Model
{
    public class DetailCart
    {
        public int IDDetail {get;set;}
        public int IDCart { get; set; }
        public int IDPro { get; set; }
        // tạo string để chứa các topping được thêm vào
        public string ListIDIngredient { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
    }
}
