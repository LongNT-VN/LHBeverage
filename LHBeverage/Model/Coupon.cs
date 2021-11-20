using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHBeverage.Model
{
    public class Coupon
    {
        public int IDCoupon { get; set; }
        public string Code { get; set; }
        public int Discountpercent { get; set; }
        public string CreateAt { get; set; }
        public string Date { get; set; }
    }
}
