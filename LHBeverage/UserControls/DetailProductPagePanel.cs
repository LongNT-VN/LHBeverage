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
    public partial class DetailProductPagePanel : UserControl
    {
        Customer customerinfo = new Customer();
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        Product productinfo = new Product();
        int TempPriceTopping = 0;
        int TempPriceProduct = 0;
        int TempPrice = 0;
        List<string> Toppings = new List<string>();
        public DetailProductPagePanel(Product product, List<Image> images, Customer customer)
        {
            InitializeComponent();
            customerinfo = customer;
            productinfo = product;
            CreateDetail(product,images);
        }
        public string size="S";
        public int id;
        public int quantity;
        private void setmode()
        {
            if (LHBeverage.instance.CurrentMode == 1)
            {
                SetMode.SetModeFunc(this, null, Color.Black, Color.White, Color.DarkGoldenrod, Color.White, Color.FromArgb(30, 30, 30));
                RelationItemPanel.BackColor = Color.FromArgb(30, 30, 30);
                TempPanel.BackColor = Color.FromArgb(30, 30, 30);
            }
            else
            {
                SetMode.SetModeFunc(this, null, Color.White, Color.Black, Color.DarkGoldenrod, Color.Black, Color.Gainsboro);
                RelationItemPanel.BackColor = Color.Gainsboro;
                TempPanel.BackColor = Color.Gainsboro;
            }
            if (QuantityDown.Enabled)
            {
                QuantityDown.BackColor = Color.DarkGoldenrod;
            }
            else
            {
                QuantityDown.BackColor = Color.DimGray;
            }
            if (QuantityUp.Enabled)
            {
                QuantityUp.BackColor = Color.DarkGoldenrod;
            }
            else
            {
                QuantityUp.BackColor = Color.DimGray;
            }
            QuantityDown.BackColor = Color.DimGray;
            SizeMBtn.ForeColor = Color.Black;
            SizeSBtn.ForeColor = Color.Black;
            SizeLBtn.ForeColor = Color.Black;
        }
        public void CreateDetail(Product product, List<Image> images)
        {
            setmode();
            id = product.IDPro;
            quantity = Convert.ToInt32(QuantityItem.Text);
            NameItem.Text = product.Name;
            DescriptionItem.Text = product.Description;
            if(product.QuantitysizeS == 0)
            {
                SizeSBtn.BackColor = Color.DimGray;
                SizeSBtn.Enabled = false;
                size = "M";
            }
            else if(product.QuantitysizeM==0)
            {
                SizeMBtn.BackColor = Color.DimGray;
                SizeMBtn.Enabled = false;
            }
            else if(product.QuantitysizeL==0)
            {
                SizeLBtn.BackColor = Color.DimGray;
                SizeLBtn.Enabled = false;
            }
            if (product.QuantitysizeS == 0 && product.QuantitysizeM==0)
            {
                size = "L";
            }
            if (size=="S")
            {
                SizeSBtn.PerformClick();
            }
            else if(size=="M")
            {
                SizeMBtn.PerformClick();
            }
            else if (size == "L")
            {
                SizeLBtn.PerformClick();
            }
            TempPrice = TempPriceProduct + TempPriceTopping;
            PriceItem.Text = TempPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
            int index = 0;
            foreach(Image image in images)
            {
                if(image!=null)
                {
                    index++;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.BackgroundImage = image;
                    pictureBox.Size = new Size(60, 60);
                    pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBox.Click += PictureBox_Click;
                    ListImagePanel.Controls.Add(pictureBox);
                    if(index==1)
                    {
                        ImgItem.BackgroundImage = image;
                    }
                }
            }
            List<Topping> toppings = new List<Topping>();
            toppings = ToppingConnect.SelectToppingByCate(product.IDCate);
            foreach (Topping topping in toppings)
            {
                CheckBox toppingitem = new CheckBox();
                toppingitem.AutoSize = true;
                toppingitem.Text = topping.ToppingName + " x " + topping.Price.ToString("#,###", cul.NumberFormat) + " VNĐ";
                toppingitem.TextAlign = ContentAlignment.MiddleLeft;
                toppingitem.Name = topping.IDTopping.ToString();
                toppingitem.CheckedChanged += CheckTopping_Click;
                ListToppings.Controls.Add(toppingitem);
            }
            List<Product> products = new List<Product>();
            products = ProductConnect.SelectProductByCategory(product.IDCate);
            string productimagebase64 = "";
            foreach (Product product1 in products)
            {
                if (product1 != null)
                {
                    //truyền vào product để chọn select tất cả các hình có trùng IDPRO
                    List<DetailImage> imagesrelations = DetailImageConnect.LoadImage(product1.IDPro);
                    foreach (DetailImage image in imagesrelations)
                    {
                        if (image != null)
                        {
                            //Lấy hình đầu tiên ra làm hình đại diện sản phẩm
                            productimagebase64 = image.ImageData;
                            break;
                        }
                    }
                    Image productimage = ConvertBase64toImage.ConverImageFromBase64(productimagebase64);
                    ItemcardComponent itemcart = new ItemcardComponent(product1, productimage);
                    itemcart.Click += LHBeverage.instance.ItemClick;
                    RelationItemPanel.Controls.Add(itemcart);
                }
            }
        }
        private void CheckTopping_Click(object sender, EventArgs e)
        {
            CheckBox topping = sender as CheckBox;
            if(topping!=null)
            {
                if(topping.Checked)
                {
                    Topping toppingselected = ToppingConnect.SelectToppingByID(Convert.ToInt32(topping.Name));
                    TempPriceTopping += toppingselected.Price;
                    TempPrice = TempPriceProduct + TempPriceTopping;
                    PriceItem.Text = (TempPrice).ToString("#,###", cul.NumberFormat) + " VNĐ";
                    Toppings.Add(topping.Name);
                    Toppings.Sort();
                }
                else
                {
                    Topping toppingselected = ToppingConnect.SelectToppingByID(Convert.ToInt32(topping.Name));
                    TempPriceTopping -= toppingselected.Price;
                    TempPrice = TempPriceProduct + TempPriceTopping;
                    PriceItem.Text = (TempPrice).ToString("#,###", cul.NumberFormat) + " VNĐ";
                    Toppings.Remove(topping.Name);
                    Toppings.Sort();
                }
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if(ImgItem.BackgroundImage != pictureBox.BackgroundImage)
            {
                ImgItem.BackgroundImage = pictureBox.BackgroundImage;
            }
        }

        private void SizeSBtn_Click(object sender, EventArgs e)
        {
            size = "S";
            SizeSBtn.BackColor = Color.SandyBrown;
            QuantityProduct.ForeColor = Color.LimeGreen;
            if (SizeMBtn.Enabled)
            {
                SizeMBtn.BackColor = Color.AntiqueWhite;
            }
            if (SizeLBtn.Enabled)
            {
                SizeLBtn.BackColor = Color.AntiqueWhite;
            }
            if (productinfo.QuantitysizeS <= 5)
            {
                QuantityProduct.ForeColor = Color.DarkOrange;
            }
            if (productinfo.QuantitysizeS < Convert.ToInt32(QuantityItem.Text))
            {
                QuantityItem.Text = productinfo.QuantitysizeS.ToString();

            }
            else if(productinfo.QuantitysizeS==Convert.ToInt32(QuantityItem.Text))
            {
                QuantityUp.Enabled = false;
                QuantityUp.BackColor = Color.DimGray;
            }
            else
            {
                QuantityUp.Enabled = true;
                QuantityUp.BackColor = Color.LightGoldenrodYellow;
            }
            TempPriceProduct = productinfo.PriceS;
            TempPrice = TempPriceProduct + TempPriceTopping;
            QuantityProduct.Text = "Còn lại " + productinfo.QuantitysizeS.ToString() + " sản phẩm.";
            PriceItem.Text = TempPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
        }

        private void SizeMBtn_Click(object sender, EventArgs e)
        {
            size = "M";
            SizeMBtn.BackColor = Color.SandyBrown;
            QuantityProduct.ForeColor = Color.LimeGreen;
            if (SizeSBtn.Enabled)
            {
                SizeSBtn.BackColor = Color.AntiqueWhite;
            }
            if (SizeLBtn.Enabled)
            {
                SizeLBtn.BackColor = Color.AntiqueWhite;
            }
            if (productinfo.QuantitysizeM <= 5)
            {
                QuantityProduct.ForeColor = Color.DarkOrange;
            }
            if (productinfo.QuantitysizeM < Convert.ToInt32(QuantityItem.Text))
            {
                QuantityItem.Text = productinfo.QuantitysizeM.ToString();
            }
            else if (productinfo.QuantitysizeM == Convert.ToInt32(QuantityItem.Text))
            {
                QuantityUp.Enabled = false;
                QuantityUp.BackColor = Color.DimGray;
            }
            else
            {
                QuantityUp.Enabled = true;
                QuantityUp.BackColor = Color.LightGoldenrodYellow;
            }
            TempPriceProduct = productinfo.PriceM;
            TempPrice = TempPriceProduct + TempPriceTopping;
            QuantityProduct.Text = "Còn lại " + productinfo.QuantitysizeM.ToString() + " sản phẩm.";
            PriceItem.Text = TempPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
        }

        private void SizeLBtn_Click(object sender, EventArgs e)
        {
            size = "L";
            SizeLBtn.BackColor = Color.SandyBrown;
            QuantityProduct.ForeColor = Color.LimeGreen;
            if (SizeSBtn.Enabled)
            {
                SizeSBtn.BackColor = Color.AntiqueWhite;
            }
            if (SizeMBtn.Enabled)
            {
                SizeMBtn.BackColor = Color.AntiqueWhite;
            }
            if (productinfo.QuantitysizeL <= 5)
            {
                QuantityProduct.ForeColor = Color.DarkOrange;
            }
            if (productinfo.QuantitysizeL < Convert.ToInt32(QuantityItem.Text))
            {
                QuantityItem.Text = productinfo.QuantitysizeL.ToString();
            }
            else if (productinfo.QuantitysizeL == Convert.ToInt32(QuantityItem.Text))
            {
                QuantityUp.Enabled = false;
                QuantityUp.BackColor = Color.DimGray;
            }
            else
            {
                QuantityUp.Enabled = true;
                QuantityUp.BackColor = Color.LightGoldenrodYellow;
            }
            TempPriceProduct = productinfo.PriceL;
            TempPrice = TempPriceProduct + TempPriceTopping;
            QuantityProduct.Text = "Còn lại " + productinfo.QuantitysizeL.ToString() + " sản phẩm.";
            PriceItem.Text = TempPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
        }



        private void QuantityDown_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(QuantityItem.Text);
            if(number!=1)
            {
                number--;
                QuantityUp.Enabled = true;
                QuantityUp.BackColor = Color.LightGoldenrodYellow;
            }
            QuantityItem.Text = number.ToString();
        }

        private void QuantityUp_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(QuantityItem.Text);
            number++;
            if (number > 1)
            {
                QuantityDown.Enabled = true;
                QuantityDown.BackColor = Color.LightGoldenrodYellow;
            }
            QuantityItem.Text = number.ToString();
        }

        private void QuantityItem_TextChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(QuantityItem.Text);
            QuantityUp.Enabled = true;
            QuantityUp.BackColor = Color.LightGoldenrodYellow;
            if (Convert.ToInt32(QuantityItem.Text) == 1)
            {
                QuantityDown.Enabled = false;
                QuantityDown.BackColor = Color.DimGray;
            }
            if (size == "S" && quantity == productinfo.QuantitysizeS)
            {
                QuantityUp.Enabled = false;
                QuantityUp.BackColor = Color.DimGray;
            }
            else if (size == "M" && productinfo.QuantitysizeM == quantity)
            {
                QuantityUp.Enabled = false;
                QuantityUp.BackColor = Color.DimGray;
            }
            else if (size == "L" && quantity == productinfo.QuantitysizeL)
            {
                QuantityUp.Enabled = false;
                QuantityUp.BackColor = Color.DimGray;
            }
        }

        private void OrderItemBtn_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if(pictureBox!=null)
            {
                MessageBox.Show("Thêm vào giỏ thành công");
            }
            Cart cart = CartConnect.LoadCart(customerinfo);
            string toppings="";
            foreach (string topping in Toppings)
            {
                toppings += topping+",";
            }
            ProductConnect.UpdateProductQuantity(productinfo, size, quantity);
            DetailCartConnect.CreateDetailCart(cart, id, toppings, size, quantity, TempPrice);
            LHBeverage.instance.init();
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                OrderItemBtn.Click += value;
            }
            remove
            {
                base.Click -= value;
                OrderItemBtn.Click -= value;
            }
        }

    }
}
