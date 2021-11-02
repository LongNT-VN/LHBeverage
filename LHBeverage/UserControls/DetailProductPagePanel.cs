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
        public DetailProductPagePanel(Product product, List<Image> images, Customer customer)
        {
            InitializeComponent();
            customerinfo = customer;
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
           // PriceItem.Text = product.Price.ToString("#,###", cul.NumberFormat) + " VNĐ";
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
        }

        private void SizeMBtn_Click(object sender, EventArgs e)
        {
            size = "M";
            SizeMBtn.BackColor = Color.SandyBrown;
            SizeSBtn.BackColor = Color.AntiqueWhite;
            SizeLBtn.BackColor = Color.AntiqueWhite;
        }

        private void SizeLBtn_Click(object sender, EventArgs e)
        {
            size = "L";
            SizeLBtn.BackColor = Color.SandyBrown;
            SizeSBtn.BackColor = Color.AntiqueWhite;
            SizeMBtn.BackColor = Color.AntiqueWhite;
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
            Cart cart = CartConnect.LoadCart(customerinfo);
            DetailCartConnect.CreateDetailCart(cart, id, "", size, quantity);
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

        //Thêm hàm kiểm tra thay đổi check để thêm topping
    }
}
