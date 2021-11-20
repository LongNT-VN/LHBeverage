using LHBeverage.Helper;
using LHBeverage.Model;
using LHBeverage.ModelService;
using LHBeverage.UserControls;
using LHBeverage.UserControls.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage
{
    public partial class LHBeverage : Form
    {
        Customer customerinfo = new Customer();
        public static LHBeverage instance;
        int TempIDSelectted=9999;
        string TempCouponCode = "";
        public LHBeverage(Customer customer)
        {
            InitializeComponent();
            customerinfo = customer;
            // HomeBtn.PerformClick();
            instance = this;
            this.Invalidate(true);
            init();
        }

        public void init()
        {
            int quantity=0;
            Cart getCart = CartConnect.LoadCart(customerinfo);
            List<DetailCart> details = DetailCartConnect.LoadDetailCart(getCart);
            foreach(DetailCart detailCart in details)
            {
                quantity+=detailCart.Quantity;
            }
            QuantityLabel.Text = quantity.ToString();
            AccountName_lbl.Text = customerinfo.Email;
            Avatar_picturebox.Image = ConvertBase64toImage.ConverImageFromBase64(customerinfo.Avatar);
        }
        public void useCoupon(string Coupon)
        {
            TempCouponCode = Coupon;
            CartBtn.PerformClick();
            CartPagePanel.instance.UseCoupon_Click();
        }
        //Function
        private void LHBeverage_Shown(object sender, EventArgs e)
        {
            HomeBtn.PerformClick();
        }
        private void GetCartInfo()
        {
            Cart cart = CartConnect.LoadCart(customerinfo);
            CartPanel.Controls.Clear();
            CartPagePanel cartPagePanel = new CartPagePanel(cart,customerinfo,TempCouponCode);
            cartPagePanel.Click += CartComponentBtn;
            //Chổ này chưa nhận anchor
            cartPagePanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            CartPanel.Controls.Add(cartPagePanel);
        }


        //Event
        private void SwitchLabelControl(Button btn, Label Switch)
        {
            int n = btn.Location.Y;
            Switch.Location = new Point(0, n);
        }
        private void SwitchMenu(Button btn)
        {
            HomePanel.Visible = false;
            ProductPanel.Visible = false;
            CartPanel.Visible = false;
            DetailProductPanel.Visible = false;
            AccountPanel.Visible = false;
            TempIDSelectted = 99999;
            if (btn == HomeBtn || btn == HomeLargeBtn)
            {
                HomePanel.Visible = true;
                HomePanel.Controls.Clear();
                HomePagePanel homePagePanel = new HomePagePanel();
                homePagePanel.Dock = DockStyle.Fill;
                //homePagePanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                HomePanel.Controls.Add(homePagePanel);
            }
            else if (btn == CartBtn || btn == CartLargeBtn)
            {
                CartPanel.Visible = true;
                GetCartInfo();
            }
            else if (btn == ProductBtn || btn == ProductLargeBtn)
            {
                search_tb.Text = "Search";
                CreateCategory();
                CreateItemCard();
                CreateBigCard();
                ProductPanel.Visible = true;
            }
            else if (btn == UserBtn || btn == UserLargeBtn)
            {
                AccountPanel.Controls.Clear();
                AccountPanel.Visible = true;
                AccountPagePanel accountPagePanel = new AccountPagePanel(customerinfo);
                accountPagePanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                AccountPanel.Controls.Add(accountPagePanel);
            }
        }
        private void NavigationBtnSwitch(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            SwitchLabelControl(btn, SwitchLabel);
            SwitchLabelControl(btn, SwitchLargeLabel);
            SwitchMenu(btn);
        }

        private void MenuLarge_Click(object sender, EventArgs e)
        {
            NavigationPanel.Visible = false;
            NavigationLargePanel.Visible = true;
            search_tb.Visible = false;
            searchIcon_btn.Visible = false;
            NavigationLargePanel.Location = new Point(0, 0);
            TopBarPanel.Width = TopBarPanel.Width - 220;
            TopBarPanel.Location = new Point(300, 0);
        }



        private void BackToNavigationSmall_Click(object sender, EventArgs e)
        {
            NavigationPanel.Visible = true;
            NavigationLargePanel.Visible = false;
            search_tb.Visible = true;
            searchIcon_btn.Visible = true;
            TopBarPanel.Width = TopBarPanel.Width + 220;
            TopBarPanel.Location = new Point(80, 0);
        }

        private void BtnSpecial_Hover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == ProductLargeBtn)
            {
                ProductMoreOptionBtn.BackColor = Color.FromArgb(64, 64, 64);
            }
            else if (btn == MenuLargeBtn)
            {
                BackToNavigationSmall.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                CartMoreOptionBtn.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void BtnSpecial_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == ProductLargeBtn)
            {
                ProductMoreOptionBtn.BackColor = Color.FromArgb(30, 30, 0);
            }
            else if (btn == MenuLargeBtn)
            {
                BackToNavigationSmall.BackColor = Color.Black;
            }
            else
            {
                CartMoreOptionBtn.BackColor = Color.FromArgb(30, 30, 0);
            }
        }
        //Khởi tạo Category
        private void CreateCategory()
        {
          
            List<Category> categories = CategoryConnect.LoadCategory();
            CategoryPanel.Controls.Clear();
            foreach (Category category in categories)
            {
                if (category != null)
                {
                    CategoryComponent categorycomponent = new CategoryComponent(category);
                    categorycomponent.Click += Filtercategory;
                    CategoryPanel.Controls.Add(categorycomponent);
                }
            }
            Category catagoryall = new Category();
            catagoryall.Name = "All";
            catagoryall.IDCate = 99999;
            CategoryComponent categorycomponentall = new CategoryComponent(catagoryall);
            categorycomponentall.Click += Filtercategory;
            CategoryPanel.Controls.Add(categorycomponentall);
        }
        //Khởi tạo BigCard
        private void CreateBigCard()
        {
            List<Product> products = ProductConnect.LoadProduct();
            BigCardPanel.Controls.Clear();
            string productimagebase64 = "";
            Image productimage;
            foreach (Product product in products)
            {
                if (product != null)
                {
                    //truyền vào product để chọn select tất cả các hình có trùng IDPRO
                    DetailImage image = DetailImageConnect.LoadOneImage(product.IDPro);
                    productimagebase64 = image.ImageData;
                    productimage = ConvertBase64toImage.ConverImageFromBase64(productimagebase64);
                    BigCard bigCard = new BigCard(product, productimage);
                    bigCard.Click += ItemClick;
                    BigCardPanel.Controls.Add(bigCard);
                    if(products.IndexOf(product)==4)
                    {
                        break;
                    }
                }
            }
        }
        //Khởi tạo item card

        private void CreateItemCard()
        {
            ItemcartsPanel.Size = new Size(BigCardPanel.Size.Width+74, 287);         
            ItemcartsPanel.Controls.Clear();
            ItemcartsPanel.Location = new Point(BigCardPanel.Location.X, BigCardPanel.Location.Y + +BigCardPanel.Height + 30);
            List<Product> products = ProductConnect.LoadProduct();
            string productimagebase64="";
            Image productimage;
            foreach(Product product in products)
            {
                if(product!=null)
                {
                    //truyền vào product để chọn select tất cả các hình có trùng IDPRO
                    List<DetailImage> images = DetailImageConnect.LoadImage(product.IDPro);
                    foreach(DetailImage image in images)
                    {
                        if(image!=null)
                        {
                            //Lấy hình đầu tiên ra làm hình đại diện sản phẩm
                            productimagebase64 = image.ImageData;
                            break;
                        }    
                    }
                    productimage = ConvertBase64toImage.ConverImageFromBase64(productimagebase64);
                    ItemcardComponent itemcart = new ItemcardComponent(product, productimage);
                    itemcart.Click += ItemClick;
                    ItemcartsPanel.Controls.Add(itemcart);
                }
            }
        }
        //Filter itemcard
        private void CreateItemCardFilter(List<Product> products)
        {
            string productimagebase64 = "";
            Image productimage;
            foreach (Product product in products)
            {
                if (product != null)
                {
                    //truyền vào product để chọn select tất cả các hình có trùng IDPRO
                    List<DetailImage> images = DetailImageConnect.LoadImage(product.IDPro);
                    foreach (DetailImage image in images)
                    {
                        if (image != null)
                        {
                            //Lấy hình đầu tiên ra làm hình đại diện sản phẩm
                            productimagebase64 = image.ImageData;
                            break;
                        }
                    }
                    productimage = ConvertBase64toImage.ConverImageFromBase64(productimagebase64);
                    ItemcardComponent itemcart = new ItemcardComponent(product, productimage);
                    itemcart.Click += ItemClick;

                    ItemcartsPanel.Controls.Add(itemcart);
                }
            }
            ItemcartsPanel.Size = new Size(ItemcartsPanel.Size.Width, BigCardPanel.Size.Height + ItemcartsPanel.Size.Height);
            ItemcartsPanel.Location = BigCardPanel.Location;
            ItemcartsPanel.AutoScroll = true;
            ItemcartsPanel.BringToFront();

        }
        private void RemoveFilter()
        {
            ProductBtn.PerformClick();
        }

        public void NavProductFromHomeToDetail(Product product)
        {
            ProductBtn.PerformClick();
            HomePanel.Visible = false;
            ProductPanel.Visible = false;
            DetailProductPanel.Visible = true;
            DetailProductPanel.BringToFront();
            List<Image> Listimages = new List<Image>();
            if (product != null)
            {
                List<DetailImage> images = DetailImageConnect.LoadImage(product.IDPro);
                foreach (DetailImage image in images)
                {
                    Image img = ConvertBase64toImage.ConverImageFromBase64(image.ImageData);
                    Listimages.Add(img);
                }
                DetailProductPagePanel detailProductPage = new DetailProductPagePanel(product, Listimages, customerinfo);
                detailProductPage.Location = new Point(0, 0);
                detailProductPage.AutoScroll = true;
                detailProductPage.Click += DetailProductPage_Click;
                DetailProductPanel.Controls.Clear();
                DetailProductPanel.Controls.Add(BackHomeBtn);
                DetailProductPanel.Controls.Add(detailProductPage);
            }

        }
        public void ItemClick(object sender, EventArgs e)
        {
            ItemcardComponent productcard = sender as ItemcardComponent;
            Button productbigcard = sender as Button;
            List<Image> Listimages= new List<Image>();
            if (productcard != null || productbigcard!= null)
            {
                int id;
                if (productcard!=null)
                {
                    id = productcard.id;
                }
                else
                {
                    id = Convert.ToInt32(productbigcard.Name);
                }
                Product product = ProductConnect.SelectProductByIDPro(id);
                ProductPanel.Visible = false;
                DetailProductPanel.Visible = true;

                if (product != null)
                {
                    List<DetailImage> images = DetailImageConnect.LoadImage(product.IDPro);
                    foreach (DetailImage image in images)
                    {
                        Image img = ConvertBase64toImage.ConverImageFromBase64(image.ImageData);
                        Listimages.Add(img);
                    }
                    DetailProductPagePanel detailProductPage = new DetailProductPagePanel(product, Listimages, customerinfo);
                    detailProductPage.Location = new Point(0, 0);
                    detailProductPage.AutoScroll = true;
                    detailProductPage.Click += DetailProductPage_Click;
                    DetailProductPanel.Controls.Clear();
                    DetailProductPanel.Controls.Add(BackHomeBtn);
                    DetailProductPanel.Controls.Add(detailProductPage);
                }
                
            }
        }

        private void DetailProductPage_Click(object sender, EventArgs e)
        {
            Button detail = sender as Button;
            if(detail != null)
            {
                CartBtn.PerformClick();
            }
        }

        private void BackHomeBtn_Click(object sender, EventArgs e)
        {
            ProductPanel.Visible = true;
            DetailProductPanel.Visible = false;
        }

        //Filter Category
        private void Filtercategory(object sender, EventArgs e)
        {
            foreach(CategoryComponent categoryComponent in CategoryPanel.Controls)
            {
                foreach (Button Categorybtn in categoryComponent.Controls)
                {
                    if (Categorybtn != null)
                    {
                        Categorybtn.BackColor = Color.White;
                    }
                }
            }
            Button CategoryBtn = sender as Button;
            CategoryBtn.BackColor = Color.DarkOrange;
            if (CategoryBtn != null)
            {
                BigCardPanel.Controls.Clear();
                ItemcartsPanel.Controls.Clear();
                List<Product> products = ProductConnect.SelectProductByCategory(Convert.ToInt32(CategoryBtn.Name));
                TempIDSelectted = Convert.ToInt32(CategoryBtn.Name);
                CreateItemCardFilter(products);
            }
        }

        //Hàm chuyển sang trang hóa đơn
        private void CartComponentBtn(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name == "ChooseBeverageBtn")
            {
                ProductBtn.PerformClick();
            }
            else if(btn.Name == "ConfirmBtn")
            {
                UserBtn.PerformClick();
                AccountPanel.Controls.Clear();
                AccountPagePanel accountPagePanel = new AccountPagePanel(customerinfo);
                AccountPagePanel.instance.orderclick();
                AccountPanel.Controls.Add(accountPagePanel);
            }
        }


        private void search_tb_Click(object sender, EventArgs e)
        {
            if(search_tb.Text=="Search")
            {
                search_tb.Text = "";
            }
        }

        private void search_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                BigCardPanel.Controls.Clear();
                ItemcartsPanel.Controls.Clear();
                List<Product> products = ProductConnect.SelectProductBySearch(search_tb.Text, TempIDSelectted);
                CreateItemCardFilter(products);
            }
        }

        private void searchIcon_btn_Click(object sender, EventArgs e)
        {
            BigCardPanel.Controls.Clear();
            ItemcartsPanel.Controls.Clear();
            List<Product> products = ProductConnect.SelectProductBySearch(search_tb.Text, TempIDSelectted);
            CreateItemCardFilter(products);
        }

        private void Avatar_picturebox_Click(object sender, EventArgs e)
        {
            UserBtn.PerformClick();
        }
    }
}
