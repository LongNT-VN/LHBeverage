using LHBeverage.Helper;
using LHBeverage.Model;
using LHBeverage.ModelService;
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
    public partial class AdminCardOrder : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        Order orderTmp;
        public AdminCardOrder(Order order)
        {
            InitializeComponent();
            initCardOrder(order);
            orderTmp = order;
        }
        void initCardOrder(Order order)
        {
            panelCtn.BackColor = Color.Orange;
            if (order.Status == "Cancelled")
            {
                ProccessingPayment_bar.BackColor = Color.DarkGray;
                ProccessingReceived_bar.BackColor = Color.DarkGray;
                ProccessingOrdered_bar.BackColor = Color.DarkGray;
                panelCtn.BackColor = Color.Red;
            }
            if(order.Status == "Delivered")
            {
                ProccessingPayment_bar.BackColor = Color.Lime;
                panelCtn.BackColor = Color.Orange;
                done_lbl.Visible = false;
            }
            if (order.Status == "Received")
            {
                ProccessingPayment_bar.BackColor = Color.Lime;
                ProccessingReceived_bar.BackColor = Color.Lime;
                panelCtn.BackColor = Color.Lime;
                done_lbl.Visible = true;
            }
            Customer customer = CustomerConnect.CustomerInfo(order.IDCus);
            CodeOrder.Text = order.IDOrder.ToString();
            CustomerName.Text = customer.Name;
            DatePayment.Text = order.DateOrder;
            statusOrder_lbl.Text = order.Status;
            //Address.Text = order.a
            TotalPayment.Text = order.Totalpayment.ToString("#,###", cul.NumberFormat) + " VNĐ";
            List<DetailOrder> detailOrders = DetailOrderConnect.SelectItemOrderByIDOrder(order.IDOrder);
            AmountItem.Text = detailOrders.Count().ToString();

        }

        private void ViewDetailOrder_btn_Click(object sender, EventArgs e)
        {
            AdminDetailOrder adminDetailOrder = new AdminDetailOrder(orderTmp);
        
            AddNewPage.addUserControl(adminDetailOrder);
        }
    }
}
