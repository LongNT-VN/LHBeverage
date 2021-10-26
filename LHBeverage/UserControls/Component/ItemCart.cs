using LHBeverage.Helper;
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

namespace LHBeverage.UserControls.Component
{
    public partial class ItemCart : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        string size;
        DetailCart detailcartinfo;
        int quantity;
        public ItemCart(DetailCart detailcart)
        {
            InitializeComponent();
            CreateDetailCat(detailcart);
        }
        
        public void CreateDetailCat(DetailCart detailcart)
        {
            detailcartinfo = detailcart;
            List<Product> products = ProductConnect.SelectProductByIDPro(detailcart.IDPro);
            foreach(Product product in products)
            {
                if(product!=null)
                {
                    NameItem.Text = product.Name;
                    //Chưa cộng thêm giá topping
                    PriceItem.Text = (product.Price * detailcart.Quantity).ToString("#,###", cul.NumberFormat) + " VNĐ";
                    DetailImage image = DetailImageConnect.LoadOneImage(product.IDPro);
                    Image img = ConvertBase64toImage.ConverImageFromBase64(image.ImageData);
                    ImageItem.BackgroundImage = img;
                }
            }
            QuantityItem.Text = detailcart.Quantity.ToString();
            size = detailcart.Size;
            if(size=="S")
            {
                SizeSBtn.BackColor = Color.SandyBrown;
                SizeMBtn.BackColor = Color.AntiqueWhite;
                SizeLBtn.BackColor = Color.AntiqueWhite;
            }
            else if (size == "M")
            {
                SizeMBtn.BackColor = Color.SandyBrown;
                SizeSBtn.BackColor = Color.AntiqueWhite;
                SizeLBtn.BackColor = Color.AntiqueWhite;
            }
            else if (size == "L")
            {
                SizeLBtn.BackColor = Color.SandyBrown;
                SizeSBtn.BackColor = Color.AntiqueWhite;
                SizeMBtn.BackColor = Color.AntiqueWhite;
            }

        }

        private void SizeSBtn_Click(object sender, EventArgs e)
        {
            size = "S";
            DetailCartConnect.ModifyItemCartSize(size, detailcartinfo);
            SizeSBtn.BackColor = Color.SandyBrown;
            SizeMBtn.BackColor = Color.AntiqueWhite;
            SizeLBtn.BackColor = Color.AntiqueWhite;
        }

        private void SizeMBtn_Click(object sender, EventArgs e)
        {
            size = "M";
            DetailCartConnect.ModifyItemCartSize(size, detailcartinfo);
            SizeMBtn.BackColor = Color.SandyBrown;
            SizeSBtn.BackColor = Color.AntiqueWhite;
            SizeLBtn.BackColor = Color.AntiqueWhite;
        }

        private void SizeLBtn_Click(object sender, EventArgs e)
        {
            size = "L";
            DetailCartConnect.ModifyItemCartSize(size, detailcartinfo);
            SizeLBtn.BackColor = Color.SandyBrown;
            SizeSBtn.BackColor = Color.AntiqueWhite;
            SizeMBtn.BackColor = Color.AntiqueWhite;
        }

        private void QuantityDown_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(QuantityItem.Text);
            if (number != 1)
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
            DetailCartConnect.ModifyItemCartQuantity(quantity, detailcartinfo);
        }
        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                QuantityUp.Click += value;
                QuantityDown.Click += value;
                SizeSBtn.Click += value;
                SizeMBtn.Click += value;
                SizeLBtn.Click += value;
                RemoveBtn.Click += value;
            }
            remove
            {
                QuantityUp.Click -= value;
                QuantityDown.Click -= value;
                SizeSBtn.Click -= value;
                SizeMBtn.Click -= value;
                SizeLBtn.Click -= value;
                RemoveBtn.Click -= value;
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            //Thêm form Are you sure about that ?
            DetailCartConnect.DeleteDetailCart(detailcartinfo);
        }
    }
}
