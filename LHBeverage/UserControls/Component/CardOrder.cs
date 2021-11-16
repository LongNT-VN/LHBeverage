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
            if(order.Status=="Cancelled")
            {
                panel_CardOrder.BackColor = Color.Red;
                Status_lbl.ForeColor = Color.Red;
                btn_CancelOrder.Visible = false;
                ReasonLabel.Text = "Reason: " + order.Reason;
                ReasonLabel.Visible = true;
            }
            else if(order.Status == "Delivered")
            {
                panel_CardOrder.BackColor = Color.Orange;
            }
            else if (order.Status == "Received")
            {
                panel_CardOrder.BackColor = Color.Lime;
            }
            Status_lbl.Text = order.Status;
            NameUser.Text = customer.Name;
            DeliveryMethod_lbl.Text = order.Deliverymethod;
            CodeOrder_lbl.Text = order.IDOrder.ToString();
            TotalPrice.Text = order.Total.ToString();
            PricePayment_lbl.Text = order.Totalpayment.ToString();
            Discount_lbl.Text = order.Discount.ToString();
            LhCoin_lbl.Text = order.LHcoin.ToString();
            DateOrder_lbl.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            DetailOrderBtn.Tag = order.IDOrder;
            btn_CancelOrder.Tag = order.IDOrder;
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
                btn_CancelOrder.Click += value;
            }
            remove
            {
                base.Click -= value;
                DetailOrderBtn.Click -= value;
                btn_CancelOrder.Click -= value;

            }
        }
    }
}
