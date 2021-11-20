using LHBeverage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage.UserControls.Component
{
    public partial class Couponitem : UserControl
    {
        public Couponitem(Coupon coupon)
        {
            InitializeComponent();
            init(coupon);
        }
        void init(Coupon coupon)
        {
            UseBtn.Name = coupon.Code;
            CouponCode.Text = coupon.Code;
            Discriptionlabel.Text = "Out of date at " + coupon.Date;
            DiscountLabel.Text ="Discount "+ coupon.Discountpercent + " %";
        }

        private void UseBtn_Click(object sender, EventArgs e)
        {
            LHBeverage.instance.useCoupon(CouponCode.Text);
        }
    }
}
