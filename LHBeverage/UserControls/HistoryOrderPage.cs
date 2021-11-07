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
    public partial class HistoryOrderPage : UserControl
    {
        public HistoryOrderPage(Customer customer)
        {
            InitializeComponent();
            CreateHistoryOrder(customer);
        }
        void CreateHistoryOrder(Customer customer)
        {
            List<Order> orders = OrderConnect.GetOrderByStatus(customer, "Đang vận chuyển");
            foreach(Order order in orders)
            {
                if(order!=null)
                {
                    ItemOrder itemOrder = new ItemOrder(order);
                    IsDelivery.Controls.Add(itemOrder);
                }
            }
        }
    }
}
