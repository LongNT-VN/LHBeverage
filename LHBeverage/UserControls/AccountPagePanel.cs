using LHBeverage.Helper;
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
        ChangeLanguage changeLanguage = new ChangeLanguage();
        Color globalColorActive;
        Bitmap AvatarTmp;
        Customer customerTmp = new Customer();
        public static AccountPagePanel instance;
        public AccountPagePanel(Customer cust )
        {
            InitializeComponent();
            globalColorActive = Color.DarkGoldenrod;
            initDataAccountPage(cust);
            customerTmp = cust;
            instance = this;
        }
        void initDataAccountPage(Customer customer)
        {
            setmode();
            if (customer.Avatar != null)
            {
                Avatar_Pb.Image = ConvertBase64toImage.ConverImageFromBase64(customer.Avatar);
            }
            AvatarTmp = new Bitmap(Avatar_Pb.Image);
           
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
            List<Coupon> coupons = new List<Coupon>();
            coupons = CouponConnect.GetAllCoupon();
            foreach (Coupon coupon in coupons)
            {
                {
                    ListCopon.Controls.Add(new Couponitem(coupon));
                }
            }
            PhoneNb_tb.Text = customer.PhoneNumber;
            Address_tb.Text = customer.Address;
            Email_tb.Text = customer.Email;
            LHCoinsLabel.Text = customer.LHCoins + " LHCoins";
            LHCoinsUse.Maximum = customer.LHCoins;
            if (LHCoinsUse.Value == 0 || customer.LHCoins == 0)
            {
                BuyLotteryBtn.Enabled = false;
                BuyLotteryBtn.BackColor = Color.DimGray;
            }
            else
            {
                BuyLotteryBtn.Enabled = true;
                BuyLotteryBtn.BackColor = Color.DarkGoldenrod;
            }
            if (LHBeverage.instance.CurrentMode == 1)
            {
                if(changeLanguage.getLanguageMode()=="en")
                {
                    btn_Mode.Text = "Light Mode";
                }
               else
                {
                    btn_Mode.Text = "Chế độ sáng";
                }
            }
            else
            {
                if (changeLanguage.getLanguageMode() == "en")
                {
                    btn_Mode.Text = "Dark Mode";
                }
                else
                {
                    btn_Mode.Text = "Chế độ tối";
                }
                
            }
        }

       
        private void btn_Mydetail_Click(object sender, EventArgs e)
        {
            clearchoosingbtn();
            DetailOrderPanel.Visible = false;
            CouponPanel.Visible = false;
            MyOrder_panel.Visible = false;
            LHCoinsPanel.Visible = false;
            Account_MyDetail_panel.Visible = true;
            Account_MyDetail_panel.BringToFront();
            btn_Mydetail.BackColor = globalColorActive;

        }

        private void btn_MyOrders_Click(object sender, EventArgs e)
        {
            clearchoosingbtn();
            Account_MyDetail_panel.Visible = false;
            DetailOrderPanel.Visible = false;
            CouponPanel.Visible = false;
            LHCoinsPanel.Visible = false;
            MyOrder_panel.Visible = true;
            MyOrder_panel.BringToFront();
            btn_MyOrders.BackColor = globalColorActive;
            ChooseConfirmBtn.PerformClick();
           
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
                LHBeverage.instance.renderCust(customerTmp);
                if (changeLanguage.getLanguageMode() == "en")
                {
                    MessageBox.Show("Update information successfull");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                }
                
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
            renderOrder("Confirm");
        }

        private void ChooseDeliveryBtn_Click(object sender, EventArgs e)
        {
            clearchoosing();
            ChooseDeliveryBtn.BackColor = Color.DarkOrange;
            renderOrder("Delivery");
        }

        private void ChooseSuccessBtn_Click(object sender, EventArgs e)
        {
            clearchoosing();
            ChooseSuccessBtn.BackColor = Color.DarkOrange;
            renderOrder("Received");
        }

        private void ChooseCancelBtn_Click(object sender, EventArgs e)
        {
            clearchoosing();
            ChooseCancelBtn.BackColor = Color.DarkOrange;
            renderOrder("Cancelled");
        }
        private void clearchoosing()
        {
            ChooseConfirmBtn.BackColor = Color.White;
            ChooseCancelBtn.BackColor = Color.White;
            ChooseDeliveryBtn.BackColor = Color.White;
            ChooseSuccessBtn.BackColor = Color.White;
            ChooseConfirmBtn.ForeColor = Color.Black;
            ChooseCancelBtn.ForeColor = Color.Black;
            ChooseDeliveryBtn.ForeColor = Color.Black;
            ChooseSuccessBtn.ForeColor = Color.Black;
        }
        public void DetailOrder(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Name == "DetailOrderBtn")
            {

                ListProductOrder.Controls.Clear();
                MyOrder_panel.Visible = false;
                DetailOrderPanel.Visible = true;
                DetailOrderPanel.BringToFront();
                this.Controls.Add(DetailOrderPanel);
                Order order = OrderConnect.GetOrderByID(Convert.ToInt32(btn.Tag));
                if (order.Status == "Cancelled")
                {
                    Status_lbl.ForeColor = Color.Red;
                    btn_CancelOrder.Visible = false;
                    ReasonLabel.Text = "Reason: " + order.Reason;
                    ReasonLabel.Visible = true;
                }
                DeliveryMethod_lbl.Text = order.Deliverymethod;
                Status_lbl.Text = order.Status;
                CodeOrder_lbl.Text = order.IDOrder.ToString();
                TotalPrice.Text = order.Total.ToString();
                PricePayment_lbl.Text = order.Totalpayment.ToString();
                Discount_lbl.Text = order.Discount.ToString();
                LhCoin_lbl.Text = order.LHcoin.ToString();
                DateOrder.Text = order.DateOrder.ToString();
                List<DetailOrder> detailOrders = DetailOrderConnect.SelectItemOrderByIDOrder(Convert.ToInt32(btn.Tag));
                foreach (DetailOrder detail in detailOrders)
                {
                    CardItemOrder cardItem = new CardItemOrder(detail);
                    ListProductOrder.Controls.Add(cardItem);
                }
            }
            else if(btn !=null && btn.Name== "btn_CancelOrder")
            {
                Order order = OrderConnect.GetOrderByID(Convert.ToInt32(btn.Tag));
                List<DetailOrder> detailOrders = DetailOrderConnect.SelectItemOrderByIDOrder(Convert.ToInt32(btn.Tag));
                var AdminCancelOrder = new AdminCancelOrder(order);
                AdminCancelOrder.ShowDialog();
                foreach (DetailOrder detail in detailOrders)
                {
                    Product product = ProductConnect.SelectProductByIDPro(detail.IDPro);
                    ProductConnect.UpdateProductQuantity(product,detail.Size,-detail.Quantity);
                }
                ChooseCancelBtn.PerformClick();
            }
        }
        
        public void orderclick()
        {
            btn_MyOrders.PerformClick();
        }
        private void clearchoosingbtn()
        {
            if (LHBeverage.instance.CurrentMode == 0)
            {
                btn_Mydetail.BackColor = Color.White;
                btn_MyOrders.BackColor = Color.White;
                btn_LHCoins.BackColor = Color.White;
                btn_Coupon.BackColor = Color.White;
                btn_Mode.BackColor = Color.White;
                Languebtn.BackColor = Color.White;
            }
            else
            {
                btn_Mydetail.BackColor = Color.Black;
                btn_MyOrders.BackColor = Color.Black;
                btn_LHCoins.BackColor = Color.Black;
                btn_Coupon.BackColor = Color.Black;
                btn_Mode.BackColor = Color.Black;
                Languebtn.BackColor = Color.Black;
            }
        }
        private void btn_Coupon_Click(object sender, EventArgs e)
        {
            clearchoosingbtn();
            Account_MyDetail_panel.Visible = false;
            MyOrder_panel.Visible = false;
            DetailOrderPanel.Visible = false;
            LHCoinsPanel.Visible = false;
            CouponPanel.Visible = true;
            CouponPanel.BringToFront();
            btn_Coupon.BackColor = globalColorActive;

        }
        
        private void btn_LHCoins_Click(object sender, EventArgs e)
        {
            clearchoosingbtn();
            Account_MyDetail_panel.Visible = false;
            MyOrder_panel.Visible = false;
            DetailOrderPanel.Visible = false;
            LHCoinsPanel.Visible = true;
            CouponPanel.Visible = false;
            CouponPanel.BringToFront();
            btn_LHCoins.BackColor = globalColorActive;
        }

        private void BuyLotteryBtn_Click(object sender, EventArgs e)
        {
            customerTmp.LHCoins -= Convert.ToInt32(LHCoinsUse.Value);
            CustomerConnect.UpdateCustomerLHCoins(customerTmp);
            LHCoinsLabel.Text = customerTmp.LHCoins.ToString() + " LHCoins";
            Random random = new Random();
            int luckynumber = random.Next(0, 999999);
            int customernumber = Convert.ToInt32(Number1.Text) * 100000 + Convert.ToInt32(Number2.Text) * 10000 + Convert.ToInt32(Number3.Text) * 1000 + Convert.ToInt32(Number4.Text) * 100 + Convert.ToInt32(Number5.Text) * 10 + Convert.ToInt32(Number6.Text);
            LuckyNumberLabel.Text = luckynumber.ToString();
            if (luckynumber > 10000 && luckynumber <= 100000)
            {
                LuckyNumberLabel.Text = "0" + luckynumber.ToString();
            }
            else if (luckynumber > 1000 && luckynumber <= 10000)
            {
                LuckyNumberLabel.Text = "00" + luckynumber.ToString();
            }
            else if (luckynumber > 100 && luckynumber <= 1000)
            {
                LuckyNumberLabel.Text = "000" + luckynumber.ToString();
            }
            else if (luckynumber > 10 && luckynumber <= 100)
            {
                LuckyNumberLabel.Text = "0000" + luckynumber.ToString();
            }
            else if (luckynumber <= 10)
            {
                LuckyNumberLabel.Text = "00000" + luckynumber.ToString();
            }

            if (luckynumber == customernumber)
            {
                if (changeLanguage.getLanguageMode() == "en")
                {
                    ResultLabel.Text = "Binggo!!!! You are win the special prize" + Convert.ToInt32(LHCoinsUse.Value) * 1000 + " LHCoins";
                }
                else
                {
                    ResultLabel.Text = "Binggo!!!! Bạn đã trúng giải đặc biệt" + Convert.ToInt32(LHCoinsUse.Value) * 1000 + " LHCoins";
                }
               
                customerTmp.LHCoins += Convert.ToInt32(LHCoinsUse.Value) * 1000;
                CustomerConnect.UpdateCustomerLHCoins(customerTmp);
                LHCoinsLabel.Text = customerTmp.LHCoins.ToString()+ " LHCoins";
            }
            else if (luckynumber%100== customernumber%100)
            {
                if (changeLanguage.getLanguageMode() == "en")
                {
                    ResultLabel.Text = "Binggo!!!! You are win the consolation prize " + Convert.ToInt32(LHCoinsUse.Value) * 10 + " LHCoins";
                }
                else
                {
                    ResultLabel.Text = "Binggo!!!! Bạn đã trúng giải " + Convert.ToInt32(LHCoinsUse.Value) * 10 + " LHCoins";
                }
               
                customerTmp.LHCoins += Convert.ToInt32(LHCoinsUse.Value) * 10;
                CustomerConnect.UpdateCustomerLHCoins(customerTmp);
                LHCoinsLabel.Text = customerTmp.LHCoins.ToString() + " LHCoins";
            }
            else
            {
                
                if (changeLanguage.getLanguageMode() == "en")
                {
                    ResultLabel.Text = "Wish you luck next time!";
                }
                else
                {
                    ResultLabel.Text = "Chúc bạn may mắn lần sau!";
                }
            }
            LHCoinsUse.Maximum = customerTmp.LHCoins;
            if(LHCoinsUse.Maximum < LHCoinsUse.Value)
            {
                LHCoinsUse.Value = LHCoinsUse.Maximum;
            }
        }

        private void LHCoinsUse_ValueChanged(object sender, EventArgs e)
        {
            if (LHCoinsUse.Value == 0 || customerTmp.LHCoins == 0)
            {
                BuyLotteryBtn.Enabled = false;
                BuyLotteryBtn.BackColor = Color.DimGray;
            }
            else
            {
                BuyLotteryBtn.Enabled = true;
                BuyLotteryBtn.BackColor = Color.DarkGoldenrod;
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LHBeverage.instance.Logout();
        }

        private void btn_Mode_Click(object sender, EventArgs e)
        {
            LHBeverage.instance.UpdateMode();
            LHBeverage.instance.LHBeverageCurrentMode(LHBeverage.instance.CurrentMode);
            setmode();
            if (LHBeverage.instance.CurrentMode == 1)
            {
                if (changeLanguage.getLanguageMode() == "en")
                {
                    btn_Mode.Text = "Light Mode";
                }
                else
                {
                    btn_Mode.Text = "Chế độ sáng";
                }
            }
            else
            {
                if (changeLanguage.getLanguageMode() == "en")
                {
                    btn_Mode.Text = "Dark Mode";
                }
                else
                {
                    btn_Mode.Text = "Chế độ tối";
                }

            }
        }
        private void Number3_Click(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            textbox.Text = "";
        }

        private void Number1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox.Text, "[^0-9]"))
            {
                textbox.Text = "";
            }
        }
        private void setmode()
        {
            if (LHBeverage.instance.CurrentMode == 1)
            {
                SetMode.SetModeFunc(this, null, Color.Black, Color.White, Color.DarkGoldenrod, Color.White, Color.FromArgb(30, 30, 30));
                MenuControlAccountPanel.BackColor = Color.FromArgb(30, 30, 30);
                SwitchControlAccountPanel.BackColor = Color.FromArgb(30, 30, 30);
            }
            else
            {
                SetMode.SetModeFunc(this, null, Color.White, Color.Black, Color.DarkGoldenrod, Color.Black, Color.Gainsboro);
                MenuControlAccountPanel.BackColor = Color.Gainsboro;
                SwitchControlAccountPanel.BackColor = Color.Gainsboro;
            }
            Seperate.BackColor = Color.DimGray;
            Seperate2.BackColor = Color.DimGray;
            Seperate3.BackColor = Color.DimGray;
            Seperate4.BackColor = Color.DimGray;
            btn_Logout.BackColor = Color.Red;
            clearchoosing();
            clearchoosingbtn();
            btn_Mydetail.BackColor = Color.DarkGoldenrod;
            LotteryPanel.BackColor = Color.DarkRed;
        }

        private void Languebtn_Click(object sender, EventArgs e)
        {
           if(changeLanguage.getLanguageMode()=="en")
            {
                changeLanguage.UpdateConfig("language", "vi-VN");
                Application.Restart();
            }
           else
            {
                changeLanguage.UpdateConfig("language", "en");
                Application.Restart();
            }
                
           

        }
    }
}
