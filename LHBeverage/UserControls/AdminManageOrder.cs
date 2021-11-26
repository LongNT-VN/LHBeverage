using LHBeverage.Model;
using LHBeverage.ModelService;
using LHBeverage.UserControls.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage.UserControls
{
    public partial class AdminManageOrder : UserControl
    {
        public static AdminManageOrder instance;
        List<Order> ListOrders;
        int ParamMonth = 0;
        public AdminManageOrder()
        {
            InitializeComponent();
            initOrders();
            instance = this;
            setMode();
            FilterMonth_Cb.SelectedIndex = 0;
            AllOrderBtn.BackColor = Color.Orange;
        }
        public void setMode()
        {
            FilterMonth_Cb.SelectedIndex = 0;
            AllOrderBtn.PerformClick();
            initOrders();
            if (PublicParam.ligthMode == true)
            {
                this.BackColor = Color.FromArgb(209, 218, 235);
                Order_FlowPanel.BackColor = Color.WhiteSmoke;
                emptyOrder_lbl.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                Order_FlowPanel.BackColor = Color.Black;
                emptyOrder_lbl.ForeColor = Color.Aqua;
            }
            if (AdminDetailOrder.instance != null)
            {
                AdminDetailOrder.instance.SetMode();
            }
        }
        public void initOrders()
        {
            Order_FlowPanel.Controls.Clear();
          
            ListOrders  = OrderConnect.LoadAllOrder();
            foreach (Order order in ListOrders)
            {
                AdminCardOrder adminCardOrder = new AdminCardOrder(order);
                Order_FlowPanel.Controls.Add(adminCardOrder);
            }
        }

        private void FilterMonth_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParamMonth = FilterMonth_Cb.SelectedIndex;
            renderOrderFilter();
        }
        void renderOrderFilter()
        {
            if (AllOrderBtn.BackColor == Color.Orange)
            {
                renderAllOrder();
            }
            if (OrderSuccessBtn.BackColor == Color.MediumSpringGreen)
            {
               renderOrderPlaced();
            }
            if (OrderCancelBtn.BackColor == Color.Red)
            {
               renderOrderCancelled();
            }
        }
        public void renderAllOrder()
        {
            int i = 0;
            int check = 0;
            Order_FlowPanel.Controls.Clear();
            if (ParamMonth == 0)
            {
                if(ListOrders.Count > 0)
                {
                    check = 1;
                }
                foreach (Order order in ListOrders)
                {
                    AdminCardOrder adminCardOrder = new AdminCardOrder(order);
                    Order_FlowPanel.Controls.Add(adminCardOrder);
                    i++;
                }
            }
            else
            {
                foreach (Order order in ListOrders)
                {
                    if (DateTime.Parse(order.DateOrder).Month == ParamMonth)
                    {
                        AdminCardOrder adminCardOrder = new AdminCardOrder(order);
                        Order_FlowPanel.Controls.Add(adminCardOrder);
                        check = 1;
                    }
                }
            }

            if (check == 0)
            {
                orderEmpty_panel.Visible = true;
            }
            else
            {
                orderEmpty_panel.Visible = false;
            }


        }

        public void renderOrderPlaced()
        {
            int i = 0;
            int check = 0;
            Order_FlowPanel.Controls.Clear();
            if (ParamMonth == 0)
            {
                foreach (Order order in ListOrders)
                {
                    if (order.Status == "Received")
                    {
                            AdminCardOrder adminCardOrder = new AdminCardOrder(order);
                            Order_FlowPanel.Controls.Add(adminCardOrder);
                            i++;
                            check = 1;
                    }
                }
            }
            else
            {
                foreach (Order order in ListOrders)
                {
                    if (order.Status == "Received")
                    {
                        if (DateTime.Parse(order.DateOrder).Month == ParamMonth)
                        {
                            AdminCardOrder adminCardOrder = new AdminCardOrder(order);
                            Order_FlowPanel.Controls.Add(adminCardOrder);
                            i++;
                            check = 1;
                        }
                    }
                }
            }

            if (check == 0)
            {
                orderEmpty_panel.Visible = true;
            }
            else
            {
                orderEmpty_panel.Visible = false;
            }
        }
        public void renderOrderCancelled()
        {
            int i = 0;
            int check = 0;
            Order_FlowPanel.Controls.Clear();
            if (ParamMonth == 0)
            {
                foreach (Order order in ListOrders)
                {
                    if (order.Status == "Cancelled")
                    {
                        AdminCardOrder adminCardOrder = new AdminCardOrder(order);
                        Order_FlowPanel.Controls.Add(adminCardOrder);
                        i++;
                        check = 1;
                    }
                }
            }
            else
            {
                foreach (Order order in ListOrders)
                {
                    if (order.Status == "Cancelled")
                    {
                        if (DateTime.Parse(order.DateOrder).Month == ParamMonth)
                        {
                            AdminCardOrder adminCardOrder = new AdminCardOrder(order);
                            Order_FlowPanel.Controls.Add(adminCardOrder);
                            i++;
                            check = 1;
                        }
                    }
                }
            }

            if (check == 0)
            {
                orderEmpty_panel.Visible = true;
            }
            else
            {
                orderEmpty_panel.Visible = false;
            }
        }

        private void TodayFilter_btn_Click(object sender, EventArgs e)
        {
            int check = 0;
            Order_FlowPanel.Controls.Clear();
            if (AllOrderBtn.BackColor == Color.Orange)
            {
                foreach (Order order in ListOrders)
                {
                    if (DateTime.Parse(order.DateOrder).Day == DateTime.Now.Day)
                    {
                        AdminCardOrder adminCardOrder = new AdminCardOrder(order);
                        Order_FlowPanel.Controls.Add(adminCardOrder);
                        check = 1;
                    }

                }
            }
            if (OrderSuccessBtn.BackColor == Color.MediumSpringGreen)
            {
                foreach (Order order in ListOrders)
                {
                    if(order.Status == "Received")
                    {
                        if (DateTime.Parse(order.DateOrder).Day == DateTime.Now.Day)
                        {
                            AdminCardOrder adminCardOrder = new AdminCardOrder(order);
                            Order_FlowPanel.Controls.Add(adminCardOrder);
                            check = 1;
                        }
                    }
                }
            }
            if (OrderCancelBtn.BackColor == Color.Red)
            {
                foreach (Order order in ListOrders)
                {
                    if (order.Status == "Cancelled")
                    {
                        if (DateTime.Parse(order.DateOrder).Day == DateTime.Now.Day)
                        {
                            AdminCardOrder adminCardOrder = new AdminCardOrder(order);
                            Order_FlowPanel.Controls.Add(adminCardOrder);
                            check = 1;
                        }
                    }
                }
            }
        
            if (check == 0)
            {
                orderEmpty_panel.Visible = true;
            }
            else
            {
                orderEmpty_panel.Visible = false;
            }

        }

        private void OrderSuccessBtn_Click(object sender, EventArgs e)
        {
            
            AllOrderBtn.BackColor = Color.White;
            AllOrderBtn.ForeColor = Color.Black;

            OrderSuccessBtn.ForeColor = Color.White;
            OrderSuccessBtn.BackColor = Color.MediumSpringGreen;

            OrderCancelBtn.ForeColor = Color.Black;
            OrderCancelBtn.BackColor = Color.White;
            renderOrderPlaced();
        }

        private void OrderCancelBtn_Click(object sender, EventArgs e)
        {
            AllOrderBtn.BackColor = Color.White;
            AllOrderBtn.ForeColor = Color.Black;

            OrderSuccessBtn.ForeColor = Color.Black;
            OrderSuccessBtn.BackColor = Color.White;

            OrderCancelBtn.ForeColor = Color.White;
            OrderCancelBtn.BackColor = Color.Red;
            renderOrderCancelled();


        }

        private void AllOrderBtn_Click(object sender, EventArgs e)
        {
            AllOrderBtn.BackColor = Color.Orange;
            AllOrderBtn.ForeColor = Color.White;

            OrderSuccessBtn.ForeColor = Color.Black;
            OrderSuccessBtn.BackColor = Color.White;

            OrderCancelBtn.ForeColor = Color.Black;
            OrderCancelBtn.BackColor = Color.White;
            renderAllOrder();

        }
    }
}
