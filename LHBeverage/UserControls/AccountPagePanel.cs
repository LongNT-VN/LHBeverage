﻿using LHBeverage.Helper;
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
    public partial class AccountPagePanel : UserControl
    {
        Color globalColorActive;
        Bitmap AvatarTmp;
        Customer customerTmp = new Customer();
        public static AccountPagePanel instance;
        public AccountPagePanel(Customer cust )
        {
            InitializeComponent();
            globalColorActive = Color.Azure;
            initDataAccountPage(cust);
            customerTmp = cust;
            instance = this;

        }
        void initDataAccountPage(Customer customer)
        {
            AvatarTmp = new Bitmap(Avatar_Pb.Image);
            if (customer.Avatar != null)
            {
                Avatar_Pb.Image = ConvertBase64toImage.ConverImageFromBase64(customer.Avatar);
            }
            Name_tb.Text = customer.Name;
            Password_tb.Text = customer.Password;
            Age_tb.Text = customer.Age.ToString();
          
            if(customer.Gender == null)
            {
                Gender_cb.SelectedIndex = Gender_cb.Items.IndexOf("Male");
             
            }
            else
            {
                Gender_cb.SelectedIndex = Gender_cb.Items.IndexOf(customer.Gender);

                //Gender_cb.SelectedValue = customer.Gender;
            }

            PhoneNb_tb.Text = customer.PhoneNumber;
            Address_tb.Text = customer.Address;
            Email_tb.Text = customer.Email;
        }

       
        private void btn_Mydetail_Click(object sender, EventArgs e)
        {
            Account_MyDetail_panel.Visible = true;
            Account_MyDetail_panel.BringToFront();
            btn_Mydetail.BackColor = globalColorActive;
            btn_MyOrders.BackColor = Color.White;
            DetailOrderPanel.Visible = false;
        }

        private void btn_MyOrders_Click(object sender, EventArgs e)
        {
            Account_MyDetail_panel.Visible = false;
            MyOrder_panel.Visible = true;
            MyOrder_panel.BringToFront();
            btn_Mydetail.BackColor = Color.White;
            btn_MyOrders.BackColor = globalColorActive;
            DetailOrderPanel.Visible = false;
            ChooseDeliveryBtn.PerformClick();
            renderOrder("Đang vận chuyển");
           
        }

        private void UploadAvatar_btn_Click(object sender, EventArgs e)
        {
            
            if(openFileDialog_Avatar.ShowDialog() == DialogResult.OK)
            {
                AvatarTmp = new Bitmap(openFileDialog_Avatar.FileName);
                Avatar_Pb.Image = AvatarTmp;
            }
        }

        private void SaveAccount_btn_Click(object sender, EventArgs e)
        {
            string base64Avatar = "";
            if (AvatarTmp != null)
            {
                 base64Avatar = ConvertImageToBase64.convertBitmapToBase64(AvatarTmp);
            }
           
            try
            {

                customerTmp.Name = Name_tb.Text;
                customerTmp.Email = Email_tb.Text;
                customerTmp.Password = Password_tb.Text;
                customerTmp.Age = Convert.ToInt32(Age_tb.Text);
                if(Gender_cb.SelectedItem == null)
                {
                    customerTmp.Gender = "Male";
                }
                else
                {
                    customerTmp.Gender = Gender_cb.SelectedItem.ToString();
                }

                customerTmp.Address = Address_tb.Text;
                customerTmp.PhoneNumber = PhoneNb_tb.Text;
                customerTmp.Avatar = base64Avatar;
                customerTmp.Authorized = "member";
                CustomerConnect.UpdateCustomer(customerTmp);
                MessageBox.Show("Update information successfull");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            Password_tb.PasswordChar = checkBox_showPass.Checked ? '\0' : '*';
        }

        // My Order
         private void renderOrder(string choosing)
        {
            Order_Flowpanel.Controls.Clear();
            List<Order> orders = OrderConnect.GetOrderByStatus(customerTmp, choosing);
            //List<Order> orders = new List<Order>();
            //orders = OrderConnect.LoadOrder(customerTmp);
            if(orders.Count() == 0)
            {
                Order_Flowpanel.Controls.Add(NonePanel);
            }
            else
            {
                foreach (Order order in orders)
                {
                    CardOrder cardOrder = new CardOrder(order, customerTmp);
                    cardOrder.Click += DetailOrder;
                    Order_Flowpanel.Controls.Add(cardOrder);
                }
            }
        }

        private void ChooseConfirmBtn_Click(object sender, EventArgs e)
        {
            clearchoosing();
            ChooseConfirmBtn.BackColor = Color.DarkOrange;
            renderOrder("Đã xác nhận");
        }

        private void ChooseDeliveryBtn_Click(object sender, EventArgs e)
        {
            clearchoosing();
            ChooseDeliveryBtn.BackColor = Color.DarkOrange;
            renderOrder("Đang vận chuyển");
        }

        private void ChooseSuccessBtn_Click(object sender, EventArgs e)
        {
            clearchoosing();
            ChooseSuccessBtn.BackColor = Color.DarkOrange;
            renderOrder("Hoàn tất");
        }

        private void ChooseCancelBtn_Click(object sender, EventArgs e)
        {
            clearchoosing();
            ChooseCancelBtn.BackColor = Color.DarkOrange;
            renderOrder("Đã hủy");
        }
        private void clearchoosing()
        {
            ChooseConfirmBtn.BackColor = Color.White;
            ChooseCancelBtn.BackColor = Color.White;
            ChooseDeliveryBtn.BackColor = Color.White;
            ChooseSuccessBtn.BackColor = Color.White;
        }
        public void DetailOrder(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn!=null)
            {
                ListProductOrder.Controls.Clear();
                MyOrder_panel.Visible = false;
                DetailOrderPanel.Visible = true;
                DetailOrderPanel.BringToFront();
                this.Controls.Add(DetailOrderPanel);
                Order order = OrderConnect.GetOrderByID(Convert.ToInt32(btn.Tag));
                List<DetailOrder> detailOrders = DetailOrderConnect.SelectItemOrderByIDOrder(Convert.ToInt32(btn.Tag));
                CodeOrder_lbl.Text = order.IDOrder.ToString();
                TotalPrice.Text = order.Total.ToString();
                PricePayment_lbl.Text = order.Totalpayment.ToString();
                Discount_lbl.Text = order.Discount.ToString();
                LhCoin_lbl.Text = order.LHcoin.ToString();
                foreach (DetailOrder detail in detailOrders)
                {
                    CardItemOrder cardItem = new CardItemOrder(detail);
                    ListProductOrder.Controls.Add(cardItem);
                }
            }
        }
        public void orderclick()
        {
            btn_MyOrders.PerformClick();
        }

    }
}
