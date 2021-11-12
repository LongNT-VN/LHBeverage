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
        public void CreateDetail(Product product, List<Image> images)
        {
            id = product.IDPro;
            quantity = Convert.ToInt32(QuantityItem.Text);
            NameItem.Text = product.Name;
            DescriptionItem.Text = product.Description;
            if (size=="S")
            {
                TempPriceProduct = product.PriceS;
            }
            else if(size=="M")
            {
                TempPriceProduct = product.PriceM;
            }
            else if (size == "L")
            {
                TempPriceProduct = product.PriceL;
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
            SizeMBtn.BackColor = Color.AntiqueWhite;
            SizeLBtn.BackColor = Color.AntiqueWhite;
            TempPriceProduct = productinfo.PriceS;
            TempPrice = TempPriceProduct + TempPriceTopping;
            PriceItem.Text = TempPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
        }

        private void SizeMBtn_Click(object sender, EventArgs e)
        {
            size = "M";
            SizeMBtn.BackColor = Color.SandyBrown;
            SizeSBtn.BackColor = Color.AntiqueWhite;
            SizeLBtn.BackColor = Color.AntiqueWhite;
            TempPriceProduct = productinfo.PriceM;
            TempPrice = TempPriceProduct + TempPriceTopping;
            PriceItem.Text = TempPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
        }

        private void SizeLBtn_Click(object sender, EventArgs e)
        {
            size = "L";
            SizeLBtn.BackColor = Color.SandyBrown;
            SizeSBtn.BackColor = Color.AntiqueWhite;
            SizeMBtn.BackColor = Color.AntiqueWhite;
            TempPriceProduct = productinfo.PriceL;
            TempPrice = TempPriceProduct + TempPriceTopping;
            PriceItem.Text = TempPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
        }



        private void QuantityDown_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(QuantityItem.Text);
            if(number!=1)
            {
                number--;
            }
            QuantityItem.Text = number.ToString();
        }

        private void QuantityUp_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(QuantityItem.Text);
            number++;
            QuantityItem.Text = number.ToString();
        }

        private void QuantityItem_TextChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(QuantityItem.Text);
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
