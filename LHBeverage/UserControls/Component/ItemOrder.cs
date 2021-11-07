using LHBeverage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage.UserControls.Component
{
    public partial class ItemOrder : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public ItemOrder(Order order)
        {
            InitializeComponent();
            CreateItemOrder(order);
        }
        private void CreateItemOrder(Order order)
        {
            NameItem.Text = order.DateOrder;
            PriceItem.Text = order.Totalpayment.ToString("#,###", cul.NumberFormat) + " VNĐ";
        }
    }
}
