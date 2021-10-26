﻿using LHBeverage.Helper;
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
        public LHBeverage(Customer customer)
        {
            InitializeComponent();
            customerinfo = customer;
            AccountName_lbl.Text = customer.Email;
            CreateItemCard();
            CreateBigCard();
            CreateCategory();
        }


        //Function
        private void GetCartInfo()
        {

            Cart cart = CartConnect.LoadCart(customerinfo);
            CartPanel.Controls.Clear();
            CartPagePanel cartPagePanel = new CartPagePanel(cart);
            //Chổ này chưa nhận anchor
            cartPagePanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            CartPanel.Controls.Add(cartPagePanel);

        }
        private void ResizePaneltoSmall(Panel panel)
        {
            panel.Width = panel.Width - 220;
            panel.Location = new Point(300, 80);
        }
        private void ResizePaneltoLarge(Panel panel)
        {
            panel.Width = panel.Width + 220;
            panel.Location = new Point(80, 80);
        }


        //Event
        private void SwitchLabelControl(Button btn, Label Switch)
        {
            int n = Switch.Location.Y;
            while (Switch.Location.Y - 5 != btn.Location.Y)
            {
                if (Switch.Location.Y - 5 < btn.Location.Y)
                {
                    n++;
                    Switch.Location = new Point(0, n);
                }
                else
                {
                    n--;
                    Switch.Location = new Point(0, n);
                }
            }
            ProductPanel.Visible = false;
            CartPanel.Visible = false;
            DetailProductPanel.Visible = false;
            if(btn==CartBtn)
            {
                CartPanel.Visible = true;
                GetCartInfo();
            }
            else if(btn == ProductBtn)
            {
                ProductPanel.Visible = true;
            }

        }

        private void NavigationBtnSwitch(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            SwitchLabelControl(btn, SwitchLabel);
            SwitchLabelControl(btn, SwitchLargeLabel);
        }

        private void MenuLarge_Click(object sender, EventArgs e)
        {
            NavigationPanel.Visible = false;
            NavigationLargePanel.Visible = true;
            search_tb.Visible = false;
            searchIcon_btn.Visible = false;
            NavigationLargePanel.Location = new Point(0, 0);
            ResizePaneltoSmall(ProductPanel);
            TopBarPanel.Width = TopBarPanel.Width - 220;
            TopBarPanel.Location = new Point(300, 0);
            ResizePaneltoSmall(DetailProductPanel);
            ResizePaneltoSmall(CartPanel);
        }



        private void BackToNavigationSmall_Click(object sender, EventArgs e)
        {
            NavigationPanel.Visible = true;
            NavigationLargePanel.Visible = false;
            search_tb.Visible = true;
            searchIcon_btn.Visible = true;
            ResizePaneltoLarge(ProductPanel);
            TopBarPanel.Width = TopBarPanel.Width + 220;
            TopBarPanel.Location = new Point(80, 0);
            ResizePaneltoLarge(DetailProductPanel);
            ResizePaneltoLarge(CartPanel);
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
            foreach (Category category in categories)
            {
                if (category != null)
                {
                    CategoryComponent categorycomponent = new CategoryComponent(category);
                    CategoryPanel.Controls.Add(categorycomponent);
                }
            }
        }
        //Khởi tạo BigCard
        private void CreateBigCard()
        {
            List<Product> products = ProductConnect.LoadProduct();
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
                    BigCard bigCard = new BigCard(product, productimage);
                    BigCardPanel.Controls.Add(bigCard);
                }
            }
        }
        //Khởi tạo item card

        private void CreateItemCard()
        {
            ItemcartsPanel.Controls.Clear();
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
        private void ItemClick(object sender, EventArgs e)
        {
            ItemcardComponent productcard = sender as ItemcardComponent;
            List<Image> Listimages= new List<Image>();
            if (productcard != null)
            {
                int id = productcard.id;
                List<Product> Products = ProductConnect.SelectProductByIDPro(id);
                ProductPanel.Visible = false;
                DetailProductPanel.Visible = true;
                foreach (Product product in Products)
                {
                    if(product!=null)
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
        }

        private void DetailProductPage_Click(object sender, EventArgs e)
        {
            Button detail = sender as Button;
            if(detail != null)
            {
                DetailProductPanel.Visible = false;
                CartPanel.Visible = true;
                GetCartInfo();
            }
        }

        private void BackHomeBtn_Click_1(object sender, EventArgs e)
        {
            ProductPanel.Visible = true;
            DetailProductPanel.Visible = false;
        }
    }
}
