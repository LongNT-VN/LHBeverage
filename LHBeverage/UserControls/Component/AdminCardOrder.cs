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
        ChangeLanguage changeLanguage = new ChangeLanguage();
        public AdminCardOrder(Order order)
        {
            InitializeComponent();
            initCardOrder(order);
            orderTmp = order;
            SetMode();
        }
        void SetMode()
        {
            foreach (Control control in panelCtn.Controls)
            {
                if (control is Panel)
                {
                    if (PublicParam.ligthMode == true)
                    {
                        control.BackColor = Color.White;
                        foreach (Control itemcontrol in control.Controls)
                        {
                            if (itemcontrol is Label)
                            {
                                if (itemcontrol.ForeColor == Color.Aqua)
                                {
                                    itemcontrol.ForeColor = Color.Black;
                                }
                            }

                        }
                    }
                    else
                    {
                        control.BackColor = Color.FromArgb(30, 30, 30);
                        foreach (Control itemcontrol in control.Controls)
                        {
                            if (itemcontrol is Label)
                            {
                                if (itemcontrol.ForeColor == Color.Black)
                                {
                                    itemcontrol.ForeColor = Color.Aqua;
                                }
                            }

                        }
                    }

                }
            }
        }
      
        void initCardOrder(Order order)
        {
            if (changeLanguage.getLanguageMode() == "en")
            {
                statusOrder_lbl.Text = order.Status;
            }
            else
            {
                if (order.Status == "Cancelled")
                {
                    statusOrder_lbl.Text = "Đã hủy";
                }
                if (order.Status == "Delivered")
                {
                    statusOrder_lbl.Text = "Đang vận chuyển";
                }
                if (order.Status == "Received")
                {
                    statusOrder_lbl.Text = "Đã nhận";
                }
            }
            panelCtn.BackColor = Color.Orange;
            if (order.Status == "Cancelled")
            {
                ProccessingPayment_bar.BackColor = Color.DarkGray;
                ProccessingReceived_bar.BackColor = Color.DarkGray;
                ProccessingOrdered_bar.BackColor = Color.DarkGray;
                panelCtn.BackColor = Color.FromArgb(245, 64, 51);
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
                panelCtn.BackColor = Color.SpringGreen;
                done_lbl.Visible = true;
            }
            Customer customer = CustomerConnect.CustomerInfo(order.IDCus);
            CodeOrder.Text = order.IDOrder.ToString();
            CustomerName.Text = customer.Name;
            DatePayment.Text = order.DateOrder;

         
            TotalPayment.Text = order.Totalpayment.ToString("#,###", cul.NumberFormat) + " VNĐ";
            List<DetailOrder> detailOrders = DetailOrderConnect.SelectItemOrderByIDOrder(order.IDOrder);
            AmountItem.Text = detailOrders.Count().ToString();
        }

        private void ViewDetailOrder_btn_Click(object sender, EventArgs e)
        {
            AdminDetailOrder adminDetailOrder = new AdminDetailOrder(orderTmp);
            //AdminDetailOrder.instance.SetMode();
            AddNewPage.addUserControl(adminDetailOrder);
        }
    }
}
