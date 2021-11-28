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
        ChangeLanguage changeLanguage = new ChangeLanguage();
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        Order orderTmp;
        public static AdminDetailOrder instance;
        public AdminDetailOrder(Order order )
        {
            InitializeComponent();
            orderTmp = order;
            initDetailOrder(order);
            SetMode();
            instance = this;
        }
        public void SetMode()
        {
            if(PublicParam.ligthMode == true)
            {
                this.BackColor = Color.FromArgb(209, 218, 235);
                panelUserInfo.BackColor = Color.White;
                panelCtnDetail.BackColor = Color.White;
                FlowPanel_ItemOrder.BackColor = Color.WhiteSmoke;
            }
            else
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                panelUserInfo.BackColor = Color.Black;
                panelCtnDetail.BackColor = Color.Black;
                FlowPanel_ItemOrder.BackColor = Color.FromArgb(40, 40, 40);
            }
            setColorInPanel(panelUserInfo,null);
            setColorInPanel(panelCtnDetail,null);
            setColorInPanel(null, this);
        }

        void setColorInPanel(Panel panel, UserControl userControl)
        {
           if(panel != null)
            {
                foreach (Control control in panel.Controls)
                {
                    if (PublicParam.ligthMode == true)
                    {
                        if (control is Label)
                        {
                            if (control.ForeColor == Color.Aqua)
                            {
                                control.ForeColor = Color.Black;
                            }
                        }
                    }
                    else
                    {
                        if (control is Label)
                        {
                            if (control.ForeColor == Color.Black)
                            {
                                control.ForeColor = Color.Aqua;
                            }
                        }
                    }
                }
            }
           
            if(userControl != null)
            {
                foreach (Control control in userControl.Controls)
                {
                    if (PublicParam.ligthMode == true)
                    {
                        if (control is Label)
                        {
                            if (control.ForeColor == Color.Aqua)
                            {
                                control.ForeColor = Color.Black;
                            }
                        }
                    }
                    else
                    {
                        if (control is Label)
                        {
                            if (control.ForeColor == Color.Black)
                            {
                                control.ForeColor = Color.Aqua;
                            }
                        }
                    }
                }
            }
        }
        public void initDetailOrder(Order order)
        {
           if(order.Status == "Cancelled")
            {
                StatusOrder_cb.Enabled = false;
                if(changeLanguage.getLanguageMode()=="en")
                {
                    Reason.Text = "Reason: " + order.Reason;
                }
                else
                {
                    Reason.Text = "Lý do: " + order.Reason;
                }
                Btn_cancel.Enabled = false;
                StatusOrder_lbl.Visible = true;
                if (changeLanguage.getLanguageMode() == "en")
                {
                    StatusOrder_lbl.Text = "Cancelled";
                }
                else
                {
                    StatusOrder_lbl.Text = "Đã hủy";
                }
                panelStatus.BackColor = Color.Red;
                panelStatus2.BackColor = Color.Red;
                Bar_paymented.BackColor = Color.DarkGray;
                BarDelivered.BackColor = Color.DarkGray;
                BarReceived.BackColor = Color.DarkGray;
                Btn_cancel.BackColor = Color.DimGray;
            }
            string[] t = null;
            string[] listdelivered = null;
            if (changeLanguage.getLanguageMode() == "en")
            {
                 t = new[] { "", "Delivered", "Received" };
                 listdelivered = new[] { "", "Received" };
               
            }
            else
            {
                 t = new[] { "", "Đang vận chuyển", "Đã nhận" };
                listdelivered = new[] { "", "Đã nhận" };
              
            }
            StatusOrder_cb.DataSource = t;

            {
                if (order.Status == "Delivered")
                {

                    BarDelivered.BackColor = Color.Lime;
                    // t = new[] { "", "Received" };
                    StatusOrder_cb.DataSource = listdelivered;
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
                if (changeLanguage.getLanguageMode() == "en")
                {
                    StatusOrder_cb.SelectedText = order.Status;
                }
                else
                {
                    if(order.Status== "Cancelled")
                    {
                        StatusOrder_cb.SelectedText ="Đã hủy";
                    }
                    if (order.Status == "Delivered")
                    {
                        StatusOrder_cb.SelectedText = "Đang vận chuyển";
                    }
                    if (order.Status == "Received")
                    {
                        StatusOrder_cb.SelectedText ="Đã nhận";
                    }
                }
               
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
            if(StatusOrder_cb.SelectedItem.ToString() == "Delivered" || StatusOrder_cb.SelectedItem.ToString() == "Đang vận chuyển")
            {
                try
                {
                    BarDelivered.BackColor = Color.Lime;
                    if (changeLanguage.getLanguageMode() == "en")
                    {
                        var t = new[] { "", "Received" };
                    }
                    else
                    {
                        var t = new[] { "", "Đã nhận" };
                    }
                   
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
            if(StatusOrder_cb.SelectedItem.ToString() == "Received" || StatusOrder_cb.SelectedItem.ToString() == "Đã nhận")
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
            var AdminCancelOrder = new AdminCancelOrder(orderTmp,true);
            AdminCancelOrder.ShowDialog();
        }
    }
}
