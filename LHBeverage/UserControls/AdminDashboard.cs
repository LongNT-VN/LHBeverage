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

namespace LHBeverage.UserControls
{
    public partial class AdminDashboard : UserControl
    {
        public static AdminDashboard instance;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public AdminDashboard()
        {
            InitializeComponent();
            renderInfor();
            instance = this;
        }
        void renderInfor()
        {
            int totalEarning = 0;
            List<Product> products = ProductConnect.LoadProduct();
            List<Customer> customers = CustomerConnect.LoadCustomer();
            List<Order> orders = OrderConnect.LoadAllOrder();
            QuantityProduct_lbl.Text = products.Count.ToString();
            NumberCustomer_lbl.Text = customers.Count.ToString();
            amountOrder_lbl.Text = orders.Count.ToString();
            foreach (Order order in orders)
            {
                totalEarning += order.Totalpayment;
            }
            revenue_lbl.Text = totalEarning.ToString("#,###", cul.NumberFormat) + " Vnđ"; ;
            setMode();
        }
        public void setMode()
        {
            if (PublicParam.ligthMode == true)
            {
                this.BackColor = Color.FromArgb(209, 218, 235);
               // welcome_lbl.ForeColor = Color.Black;
                SetMode.SetModeFunc(this, null, Color.White, Color.Black, Color.DarkGoldenrod, Color.Black, Color.FromArgb(209, 218, 235));

            }
            else
            {
                SetMode.SetModeFunc(this, null, Color.Black, Color.White, Color.DarkGoldenrod, Color.White, Color.FromArgb(30, 30, 30));

                this.BackColor = Color.FromArgb(30, 30, 30);
               // welcome_lbl.ForeColor = Color.White;
            }
        }
    }
}
