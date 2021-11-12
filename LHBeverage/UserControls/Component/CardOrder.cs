using LHBeverage.Model;
using LHBeverage.ModelService;
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
    public partial class CardOrder : UserControl
    {
        public CardOrder(Order order, Customer customer)
        {
            InitializeComponent();
            initOrder(order, customer);
        }
        void initOrder(Order order, Customer customer)
        {
            NameUser.Text = customer.Name;
            CodeOrder_lbl.Text = order.IDOrder.ToString();
            TotalPrice.Text = order.Total.ToString();
            PricePayment_lbl.Text = order.Totalpayment.ToString();
            Discount_lbl.Text = order.Discount.ToString();
            LhCoin_lbl.Text = order.LHcoin.ToString();
            DateOrder_lbl.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            DetailOrderBtn.Tag = order.IDOrder;
            try
            {
                Flow_ItemOrder.Controls.Clear();
                List<DetailOrder> details = DetailOrderConnect.SelectItemOrderByIDOrder(order.IDOrder);
                foreach(DetailOrder detailOrder in details)
                {

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                DetailOrderBtn.Click += value;
            }
            remove
            {
                base.Click -= value;
                DetailOrderBtn.Click -= value;

            }
        }
    }
}
