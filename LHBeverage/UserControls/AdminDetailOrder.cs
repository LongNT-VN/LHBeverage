using LHBeverage.Helper;
using LHBeverage.Model;
using LHBeverage.ModelService;
using LHBeverage.UserControls.Component;
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
    public partial class AdminDetailOrder : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        Order orderTmp;
        public static AdminDetailOrder instance;
        public AdminDetailOrder(Order order )
        {
            InitializeComponent();
            orderTmp = order;
            initDetailOrder(order);
            instance = this;
        }
        public void initDetailOrder(Order order)
        {
           if(order.Status == "Cancelled")
            {
                StatusOrder_cb.Enabled = false;
                Reason.Text = "Reason: " + order.Reason;
                Btn_cancel.Enabled = false;
                StatusOrder_lbl.Visible = true;
                StatusOrder_lbl.Text = "Cancelled";
                panelStatus.BackColor = Color.Red;
                panelStatus2.BackColor = Color.Red;
                Bar_paymented.BackColor = Color.DarkGray;
                BarDelivered.BackColor = Color.DarkGray;
                BarReceived.BackColor = Color.DarkGray;
                Btn_cancel.BackColor = Color.DimGray;
            }
                var t = new[] {"", "Delivered", "Received" };
                StatusOrder_cb.DataSource = t;
           
            {
                if (order.Status == "Delivered")
                {

                    BarDelivered.BackColor = Color.Lime;
                     t = new[] { "", "Received" };
                    StatusOrder_cb.DataSource = t;
                    done_lbl.Visible = false;


                }

                if (order.Status == "Received")
                {
                    BarReceived.BackColor = Color.Lime;
                    BarDelivered.BackColor = Color.Lime;
                    done_lbl.Visible = true;
                    t = new[] { "" };
                    StatusOrder_cb.DataSource = t;
                    Btn_cancel.Enabled = false;
                    Btn_cancel.BackColor = Color.DimGray;
                    StatusOrder_cb.Enabled = false;
                }
                StatusOrder_cb.SelectedText = order.Status;
            }
            //check status
          
            Customer customer = CustomerConnect.CustomerInfo(order.IDCus);
            CodeOrder.Text = order.IDOrder.ToString();
            NameCus.Text = customer.Name;
            EmailCus.Text = customer.Email;
            PhoneCus.Text = customer.PhoneNumber;
            AgeCus.Text = customer.Age.ToString();
            GenderCus.Text = customer.Gender;
            AddressCus.Text = customer.Address;

           
            DatePayment.Text = order.DateOrder;
         
            TotalPayment.Text = order.Totalpayment.ToString("#,###", cul.NumberFormat) + " VNĐ";
            List<DetailOrder> detailOrders = DetailOrderConnect.SelectItemOrderByIDOrder(order.IDOrder);
            FlowPanel_ItemOrder.Controls.Clear();
            foreach (DetailOrder detail in detailOrders)
            {
                AdminItemCardOrder adminItemCardOrder = new AdminItemCardOrder(detail);
                FlowPanel_ItemOrder.Controls.Add(adminItemCardOrder);
            }
            AmountItem.Text = detailOrders.Count().ToString();

        }

        private void BackManageOrder_Click(object sender, EventArgs e)
        {
            AdminManageOrder adminManageOrder = new AdminManageOrder();
            AddNewPage.addUserControl(adminManageOrder);
        }

        private void StatusOrder_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(StatusOrder_cb.SelectedItem.ToString() == "Delivered")
            {
                try
                {
                    BarDelivered.BackColor = Color.Lime;
                    var t = new[] { "", "Received" };
                    //StatusOrder_cb.DataSource = t;
                    OrderConnect.ModifyOrder(orderTmp, "Delivered");
                    //StatusOrder_cb.SelectedText = "Delivered";
                    done_lbl.Visible = false;
                    //MessageBox.Show("Update status success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if(StatusOrder_cb.SelectedItem.ToString() == "Received")
            { 
                try
                {
                    BarDelivered.BackColor = Color.Lime;
                    BarReceived.BackColor = Color.Lime;
                    done_lbl.Visible = true;
                    OrderConnect.ModifyOrder(orderTmp, "Received");
                    Btn_cancel.Enabled = false;
                    Btn_cancel.BackColor = Color.DimGray;
                    StatusOrder_cb.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            var AdminCancelOrder = new AdminCancelOrder(orderTmp);
            AdminCancelOrder.ShowDialog();
        }
    }
}
