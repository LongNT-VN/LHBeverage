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
    public partial class AdminStatistical : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        List<Order> orders;
        public AdminStatistical()
        {
            InitializeComponent();
            initData();
        }
        void initData()
        {
          
            string date = "";
            orders = OrderConnect.LoadAllOrder();
            int totalProductSold = 0;
            int totalProductReject = 0;
            int totalEarning = 0;
            int totalEarningDay = 0;
            int totalEarningMonth = 0;
            int AmountOrderSold = 0;
            int AmountOderCancelled = 0;
          

            foreach (Order order in orders)
            {
                List<DetailOrder> detailOrders= DetailOrderConnect.SelectItemOrderByIDOrder(order.IDOrder);
              
                int total = 0;
                totalEarning += order.Totalpayment;
                if(DateTime.Parse(order.DateOrder).Day == DateTime.Now.Day && DateTime.Parse(order.DateOrder).Month == DateTime.Now.Month)
                {
                    totalEarningDay += order.Totalpayment;
                }
                if (DateTime.Parse(order.DateOrder).Month == DateTime.Now.Month)
                {
                    totalEarningMonth += order.Totalpayment;
                }
                foreach (DetailOrder detailOrder in detailOrders)
                {
                    total += detailOrder.Quantity;
                }
                if(order.Status == "Cancelled")
                {
                    totalProductReject += total;
                    AmountOderCancelled++;
                }
                else if(order.Status == "Received")
                {
                    totalProductSold += total;
                    AmountOrderSold++;
                }
            }
            TotalProductSold_lbl.Text = totalProductSold.ToString();
            total_earning.Text = totalEarning.ToString("#,###", cul.NumberFormat)+" Vnđ";
            TotalProductReject_lbl.Text = totalProductReject.ToString();
            total_earningDay.Text = totalEarningDay.ToString("#,###", cul.NumberFormat) + " Vnđ";
            total_earningMonth.Text = totalEarningMonth.ToString("#,###", cul.NumberFormat) + " Vnđ";
            total_orderSold.Text = AmountOrderSold.ToString();
            total_orderCancelled.Text = AmountOderCancelled.ToString() ;

            //Order solded - order cancelled
            chartRatioOrder.Series["ratioOrder"].IsValueShownAsLabel = true;
            chartRatioOrder.Series["ratioOrder"].Font = new Font("Arial", 14, FontStyle.Bold);
            chartRatioOrder.Series["ratioOrder"].Points.AddXY("Order solded", AmountOrderSold);
            chartRatioOrder.Series["ratioOrder"].Points.AddXY("Order cancelled", AmountOderCancelled);
            chartRatioOrder.Series["ratioOrder"].Points[0].Color = Color.Lime;
            chartRatioOrder.Series["ratioOrder"].Points[1].Color = Color.Red;

            // Totoal earing by month
            var grouppedResult = orders.GroupBy(x => DateTime.Parse(x.DateOrder).ToString("MMMM")).Select(grp => grp.ToList()).ToList();
            chartRevenue.Series["Revenue"].IsValueShownAsLabel = true;
            chartRevenue.Series["Revenue"].Color = Color.Red;
            chartRevenue.Series["Revenue"].Font = new Font("Arial",9,FontStyle.Bold);
            foreach (var group in grouppedResult)
            {
                int total = 0;
               
                foreach(Order order in group)
                {
                    date = DateTime.Parse(order.DateOrder).ToString("MMMM");
                    
                    total += order.Totalpayment;
                }
             
                chartRevenue.Series["Revenue"].Points.AddXY(date, total.ToString("#,###", cul.NumberFormat) );
            }
        }

        private void AdminStatistical_Load(object sender, EventArgs e)
        {
            int m1 = 0;
            int m2 = 0;
            int m3 = 0; int m4 = 0; int m5 = 0; int m6 = 0; int m7 = 0; int m8 = 0; int m9 = 0;
            int m10 = 0; int m11 = 0; int m12 = 0;
            foreach (Order order in orders)
            {
                switch (DateTime.Parse(order.DateOrder).ToString("MMMM"))
                {
                    case "January":
                        m1 += 1;
                        break;
                    case "February":
                        // code block
                        m2 += 1;
                        break;
                    case "March":
                        // code block
                        m3 += 1;
                        break;
                    case "April":
                        // code block
                        m4 += 1;
                        break;
                    case "May":
                        // code block
                        m5 += 1;
                        break;
                    case "June":
                        // code block
                        m6 += 1;
                        break;
                    case "July":
                        // code block
                        m7 += 1;
                        break;
                    case "August":
                        // code block
                        m8 += 1;
                        break;
                    case "September":
                        // code block
                        m9 += 1;
                        break;
                    case "October":
                        // code block
                        m10 += 1;
                        break;
                    case "November":
                        // code block
                        m11 += 1;
                        break;
                    case "December":
                        // code block
                        m12 += 1;
                        break;
                    default:
                        // code block
                        break;
                }
            }
            chartOrder.Series["Order"]["PixelPointWidth"] = "10";
            chartOrder.Series["Order"].Points.AddXY("Jan", m1);
            chartOrder.Series["Order"].Points.AddXY("Feb", m2);
            chartOrder.Series["Order"].Points.AddXY("Mar", m3);
            chartOrder.Series["Order"].Points.AddXY("Apr", m4);
            chartOrder.Series["Order"].Points.AddXY("May", m5);
            chartOrder.Series["Order"].Points.AddXY("Jun", m6);
            chartOrder.Series["Order"].Points.AddXY("July", m7);
            chartOrder.Series["Order"].Points.AddXY("Aug", m8);
            chartOrder.Series["Order"].Points.AddXY("Sep", m9);
            chartOrder.Series["Order"].Points.AddXY("Oct", m10);
            chartOrder.Series["Order"].Points.AddXY("Nov", m11);
            chartOrder.Series["Order"].Points.AddXY("Dec", m12);

        }

        private void RevenueBtn_Click(object sender, EventArgs e)
        {
            panelRevenue.Visible = true;
            chartOrder.Visible = false;
            panelOrderSold_Cancelled.Visible = false;
            RevenueBtn.BackColor = Color.DeepPink;
            Order_btn.BackColor = Color.Green;
            OrderSold_btn.BackColor = Color.Blue;
            //Order_Cancelled_btn.BackColor = Color.Red;
        }

        private void Order_btn_Click(object sender, EventArgs e)
        {
            chartOrder.Visible = true;
            panelRevenue.Visible = false;
            panelOrderSold_Cancelled.Visible = false;
            RevenueBtn.BackColor = Color.MediumOrchid;
            Order_btn.BackColor = Color.DeepPink;
            OrderSold_btn.BackColor = Color.Blue;
            //Order_Cancelled_btn.BackColor = Color.Red;
        }

        private void OrderSold_btn_Click(object sender, EventArgs e)
        {
            chartOrder.Visible = false;
            panelRevenue.Visible = false;
            panelOrderSold_Cancelled.Visible = true;
            RevenueBtn.BackColor = Color.MediumOrchid;
            Order_btn.BackColor = Color.Green;
            OrderSold_btn.BackColor = Color.DeepPink;
            //Order_Cancelled_btn.BackColor = Color.Red;
        }

        private void Order_Cancelled_btn_Click(object sender, EventArgs e)
        {
            chartOrder.Visible = false;
            panelRevenue.Visible = false;

            RevenueBtn.BackColor = Color.MediumOrchid;
            Order_btn.BackColor = Color.Green;
            OrderSold_btn.BackColor = Color.Blue;
            //Order_Cancelled_btn.BackColor = Color.DeepPink;
        }
    }
}
