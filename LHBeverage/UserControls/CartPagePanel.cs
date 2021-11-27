using LHBeverage.Helper;
using LHBeverage.Model;
using LHBeverage.ModelService;
using LHBeverage.UserControls.Component;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net.Mail;
using System.Windows.Forms;

namespace LHBeverage.UserControls
{
    public partial class CartPagePanel : UserControl
    {
        Cart cartinfo;
        Customer customerinfo;
        ChangeLanguage changeLanguage = new ChangeLanguage();
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        int ShippingPriceinfo = 0;
        int Discountinfo = 0;
        int LHCoininfo = 0;
        int Total = 0;
        string Deliverymethod = "";
        public static CartPagePanel instance;
        public CartPagePanel(Cart cart, Customer customer, string CouponCode ="")
        {
            InitializeComponent();
            setmode();
            customerinfo = customer;
            CreateLocationData();
            CreateCartItem(cart);
            init(customer, CouponCode);
            instance = this;
            this.Invalidate(true);
            
        }
        private void setmode()
        {
            if (LHBeverage.instance.CurrentMode == 1)
            {
                SetMode.SetModeFunc(this, null, Color.Black, Color.White, Color.DarkGoldenrod, Color.White, Color.FromArgb(30, 30, 30));
                NoneCartPanel.BackColor = Color.FromArgb(30, 30, 30);
                ItemsCart.BackColor = Color.FromArgb(30, 30, 30);

            }
            else
            {
                SetMode.SetModeFunc(this, null, Color.White, Color.Black, Color.DarkGoldenrod, Color.Black, Color.Gainsboro);
                NoneCartPanel.BackColor = Color.Gainsboro;
                ItemsCart.BackColor = Color.Gainsboro;
            }
            ErrorPhoneLabel.ForeColor = Color.Red;
            ErrorDiscountLabel.ForeColor = Color.Red;
            LHCoinshaveLabel.ForeColor = Color.DarkGoldenrod;
            CouponDiscountLabel.ForeColor = Color.DarkGoldenrod;
            NoneCartPic.BackColor = Color.Transparent;

        }
        public void UseCoupon_Click()
        {
            if (NoneCartPanel.Visible)
            {
                if(changeLanguage.getLanguageMode()=="en")
                {
                    MessageBox.Show("You not have product in cart. Please add product to use coupon!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa có sản phẩm nào. Vui lòng thêm sản phẩm để sử dụng mã!");
                }
                
                ChooseBeverageBtn.PerformClick();
            }
            else
            {
                ProceedBtn.PerformClick();
            }
        }
        private void CreateCartItem(Cart cart)
        {
            int Subtotal=0;
            int Total;
            ShippingPriceinfo = 30000;
            cartinfo = cart;
            List<DetailCart> itemcarts = DetailCartConnect.LoadDetailCart(cart);
            if(itemcarts.Count==0)
            {
                NoneCartPanel.Visible = true;
            }
            else
            {
                NoneCartPanel.Visible = false;
                foreach (DetailCart itemcart in itemcarts)
                {
                    string[] idingredients = itemcart.ListIDIngredient.Split(',');
                    ItemCart itemCart = new ItemCart(itemcart);
                    itemCart.Click += Redisplay;
                    ItemsCart.Controls.Add(itemCart);
                    Subtotal += itemcart.Price;
                }
                Total = Subtotal + ShippingPriceinfo;
                SubtotalPriceLabel.Text = Subtotal.ToString("#,###", cul.NumberFormat) + " VNĐ";
                ShippingPriceLabel.Text = ShippingPriceinfo.ToString("#,###", cul.NumberFormat) + " VNĐ";
                TotalPriceLabel.Text = Total.ToString("#,###", cul.NumberFormat) + " VNĐ";
                ItemsCart.AutoScroll = true;
            }
        }
        private void Redisplay(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn!=null)
            {
                ItemsCart.Controls.Clear();
                CreateCartItem(cartinfo);
            }
        }

        private void ProceedBtn_Click(object sender, EventArgs e)
        {
            FormInfoPagePanel.Visible = true;
            MethodBox.SelectedIndex = 0;
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            customerinfo.LHCoins -= LHCoininfo;
            customerinfo.LHCoins += Total/10;
            OrderConnect.CreateOrder(cartinfo,ShippingPriceinfo,Discountinfo,LHCoininfo,Deliverymethod);    
            DetailCartConnect.ClearCart(cartinfo);
            CustomerConnect.UpdateCustomerLHCoins(customerinfo);
            ItemsCart.Controls.Clear();
            CreateCartItem(cartinfo);
            LHBeverage.instance.init();
        }
        private void caltotal(int ShippingPrice,int Discount,int LHCoin)
        {
            int total = 0;
            List<DetailCart> itemcarts = DetailCartConnect.LoadDetailCart(cartinfo);
            foreach (DetailCart itemcart in itemcarts)
            {
                total += itemcart.Price;
            }
            Total = total - LHCoin - (total - LHCoin) * Discount / 100 + ShippingPrice;
            if(Total != 0)
            {
                TotalPaymentPrice.Text = Total.ToString("#,###", cul.NumberFormat) + " VNĐ";
            }
            else
            {
                if (changeLanguage.getLanguageMode() == "en")
                {
                    TotalPaymentPrice.Text = "Free";
                }
                else
                {
                    TotalPaymentPrice.Text = "Miễn phí";
                }
                
            }

            if (Total < customerinfo.LHCoins)
            {
                LHCoins.Maximum = Total;
            }
            else
            {
                LHCoins.Maximum = customerinfo.LHCoins;
            }

        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                ConfirmBtn.Click += value;
                ChooseBeverageBtn.Click += value;
            }
            remove
            {
                base.Click -= value;
                ConfirmBtn.Click -= value;
                ChooseBeverageBtn.Click -= value;
            }
        }
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            initlocation();
            if (AddressTextBox.Text != "")
            {
                FullAddress.Text = AddressTextBox.Text + " - " + WardPicker.Text + ", " + DistrictPicker.Text + ", " + CityPicker.Text;
            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox Numberphone = sender as TextBox;
            if (CheckPhoneNumber(Numberphone.Text))
            {
                ErrorPhoneLabel.Visible = false;
            }
            else
            {
                ErrorPhoneLabel.Visible = true;
            }
            Checkinfo();
        }

        private bool CheckPhoneNumber(String Numberphone)
        {
            if (Numberphone.Length == 0)
            {
                return false;
            }
            else if (!Int32.TryParse(Numberphone, out int a))
            {
                return false;
            }
            else if (Numberphone[0].ToString() != "0" || Numberphone.Length != 10)
            {
                return false;
            }
            return true;
        }
        private void Checkinfo()
        {
            if (!CheckPhoneNumber(PhoneNumberTextBox.Text))
            {
                ConfirmBtn.Enabled = false;
                ConfirmBtn.BackColor = Color.DarkGray;
            }
            else
            {
                ConfirmBtn.Enabled = true;
                ConfirmBtn.BackColor = Color.DarkGoldenrod;
            }
        }

        private void FirstNameTextBox_Click(object sender, EventArgs e)
        {
            TextBox FisrtNameBox = sender as TextBox;
            if (FisrtNameBox.Text == "Your name")
            {
                FisrtNameBox.Text = "";
            }
        }

        private void AddressTextBox_Click(object sender, EventArgs e)
        {
            TextBox AddressBox = sender as TextBox;
            if (AddressBox.Text == "Your address.")
            {
                AddressBox.Text = "";
            }
        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {
            TextBox emailBox = sender as TextBox;
            if (emailBox.Text == "Your email.")
            {
                emailBox.Text = "";
            }
        }

        private void PhoneNumberTextBox_Click(object sender, EventArgs e)
        {
            TextBox PhonenumberBox = sender as TextBox;
            if (PhonenumberBox.Text == "Phone number.")
            {
                PhonenumberBox.Text = "";
            }
        }

        private void CouponBox_Click(object sender, EventArgs e)
        {
            TextBox CouponTextBox = sender as TextBox;
            if (CouponTextBox.Text == "Your coupon.")
            {
                CouponTextBox.Text = "";
            }
        }

        private void CouponBox_Leave(object sender, EventArgs e)
        {
            TextBox CouponTextBox = sender as TextBox;
            Coupon coupon = CouponConnect.GetCouponbyCode(CouponTextBox.Text);
            if(coupon==null)
            {
                Discountinfo = 0;
                ErrorDiscountLabel.Visible = true;
                caltotal(ShippingPriceinfo, Discountinfo, LHCoininfo);
            }
        }

        private void CouponBox_TextChanged(object sender, EventArgs e)
        {
            TextBox CouponTextBox = sender as TextBox;
            ErrorDiscountLabel.Visible = false;
            Coupon coupon = CouponConnect.GetCouponbyCode(CouponTextBox.Text);
            if(coupon!=null)
            {
                Discountinfo = coupon.Discountpercent;
                AddingFee();
                caltotal(ShippingPriceinfo, Discountinfo, LHCoininfo);
                if(changeLanguage.getLanguageMode()=="en")
                {
                    CouponDiscountLabel.Text = "Discount" + coupon.Discountpercent + "%";
                }
                else
                {
                    CouponDiscountLabel.Text = "Giảm giá" + coupon.Discountpercent + "%";
                }
                CouponDiscountLabel.Visible = true;
            }
        }
        private void CreateLocationData()
        {
            List<Province> provinces = LocationConnect.LoadProvice();
            CityPicker.DataSource = provinces;
            CityPicker.DisplayMember = "Name";
            CityPicker.SelectedIndex = 1;
        }

        private void CityPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<District> districts = LocationConnect.LoadDistrict((Province)CityPicker.SelectedItem);
            DistrictPicker.DataSource = districts;
            DistrictPicker.DisplayMember = "Name";
            DistrictPicker.SelectedIndex = 1;
        }

        private void DistrictPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Ward> wards = LocationConnect.LoadWard((District)DistrictPicker.SelectedItem);
            WardPicker.DataSource = wards;
            WardPicker.DisplayMember = "Name";
            WardPicker.SelectedIndex = 1;
        }

        private void WardPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            FullAddress.Text = AddressTextBox.Text + " - " + WardPicker.Text + ", " + DistrictPicker.Text + ", " + CityPicker.Text ;
        }
        private void initlocation()
        {
            string[] address = AddressTextBox.Text.Split(',');
            string provinceinfo = "";
            string districtinfo = "";
            string wardinfo = "";
            if (address.Length > 0)
            {
                provinceinfo = address[address.Length - 1];
                districtinfo = address[address.Length - 1];
                wardinfo = address[address.Length - 1];
                if (address.Length > 1)
                {
                    wardinfo = address[address.Length - 2];
                    districtinfo = address[address.Length - 2];
                    if (address.Length > 3)
                    {
                        wardinfo = address[address.Length - 3];
                    }
                }

            }
            List<Province> provinces = (List<Province>)CityPicker.DataSource;
            foreach (Province province in provinces)
            {
                if (province.Name.ToLower().Contains(provinceinfo.ToLower()))
                {
                    CityPicker.SelectedItem = province;
                    List<District> districts = (List<District>)DistrictPicker.DataSource;
                    foreach (District district in districts)
                    {
                        if (district.Name.ToLower().Contains(districtinfo.ToLower()))
                        {
                            DistrictPicker.SelectedItem = district;
                            List<Ward> wards = (List<Ward>)WardPicker.DataSource;
                            foreach (Ward ward in wards)
                            {
                                if (ward.Name.ToLower().Contains(wardinfo.ToLower()))
                                {
                                    WardPicker.SelectedItem = ward;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }
        private void init(Customer customer, string CouponCode)
        {
            LHCoinshaveLabel.Text = "You have " + customer.LHCoins + " LHCoins";
            AddressTextBox.Text = customer.Address;
            PhoneNumberTextBox.Text = customer.PhoneNumber;
            FirstNameTextBox.Text = customer.Name;
            EmailTextBox.Text = customer.Email;
            if(CouponCode!="")
            {
                CouponBox.Text = CouponCode;
            }
            initlocation();
        }

        private void MethodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddingFee();
            Deliverymethod = MethodBox.SelectedItem.ToString();
            caltotal(ShippingPriceinfo, Discountinfo, LHCoininfo);
        }

        private void LHCoins_ValueChanged(object sender, EventArgs e)
        {
            AddingFee();
            caltotal(ShippingPriceinfo, Discountinfo, LHCoininfo);
        }
        private void AddingFee()
        {
            if (MethodBox.SelectedIndex == 0)
            {
                ShippingPriceinfo = 30000;
            }
            else if (MethodBox.SelectedIndex == 1)
            {
                ShippingPriceinfo = 15000;
            }
            else if (MethodBox.SelectedIndex == 2)
            {
                ShippingPriceinfo = 40000;
            }
            else if (MethodBox.SelectedIndex == 3)
            {
                ShippingPriceinfo = 0;
            }
            PriceShipping.Text = ShippingPriceinfo.ToString("#,###", cul.NumberFormat) + " VNĐ";
            LHCoininfo = Convert.ToInt32(LHCoins.Value);
        }

        private void MapBtn_Click(object sender, EventArgs e)
        {
           
            Map map = new Map(FullAddress.Text);
            map.ShowDialog();
            if(map.returnaddress != "")
            {
                AddressTextBox.Text = map.returnaddress;
            }
        }

        private void BackCartBtn_Click(object sender, EventArgs e)
        {
            FormInfoPagePanel.Visible = false;
            ItemsCart.Visible = true;
        }
    }
}
