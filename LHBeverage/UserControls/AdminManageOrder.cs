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
        public AdminManageOrder()
        {
            InitializeComponent();
            initOrders();
            instance = this;
        }
        public void initOrders()
        {
            Order_FlowPanel.Controls.Clear();
          
            List<Order> ListOrders  = OrderConnect.LoadAllOrder();
            foreach (Order order in ListOrders)
            {
                AdminCardOrder adminCardOrder = new AdminCardOrder(order);
                Order_FlowPanel.Controls.Add(adminCardOrder);
            }
        }
    }
}
