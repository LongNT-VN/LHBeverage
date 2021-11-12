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
        Product productinfo;
        int quantity;
        int PriceTopping=0;
        int PriceProduct = 0;
        int TotalPrice = 0;
        public ItemCart(DetailCart detailcart)
        {
            InitializeComponent();
            CreateDetailCat(detailcart);
        }
        
        public void CreateDetailCat(DetailCart detailcart)
        {
            detailcartinfo = detailcart;
            Product product = ProductConnect.SelectProductByIDPro(detailcart.IDPro);
            string[] listtop = detailcart.ListIDIngredient.Split(',');
            foreach(string idtopping in listtop)
            {
                if(idtopping!="")
                {
                    Topping topping = ToppingConnect.SelectToppingByID(Convert.ToInt32(idtopping));
                    if (topping != null)
                    {
                        PriceTopping += topping.Price;
                        Label toppinglabel = new Label();
                        toppinglabel.AutoSize = true;
                        toppinglabel.Text = topping.ToppingName + " x " + topping.Price.ToString("#,###", cul.NumberFormat) + " VNĐ";
                        Topping.Controls.Add(toppinglabel);
                    }
                }
            }
            if (product != null)
            {
                productinfo = product;
                SizeSBtn.BackColor = Color.AntiqueWhite;
                SizeMBtn.BackColor = Color.AntiqueWhite;
                SizeLBtn.BackColor = Color.AntiqueWhite;
                size = detailcart.Size;
                if (size == "S")
                {
                    SizeSBtn.BackColor = Color.SandyBrown;
                    PriceProduct = product.PriceS;
                }
                else if (size == "M")
                {
                    SizeMBtn.BackColor = Color.SandyBrown;
                    PriceProduct = product.PriceM;
                }
                else if (size == "L")
                {
                    SizeLBtn.BackColor = Color.SandyBrown;
                    PriceProduct = product.PriceL;
                }
                NameItem.Text = product.Name;
                TotalPrice = (PriceProduct + PriceTopping) * detailcart.Quantity;
                PriceItem.Text = TotalPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
                DetailImage image = DetailImageConnect.LoadOneImage(product.IDPro);
                Image img = ConvertBase64toImage.ConverImageFromBase64(image.ImageData);
                ImageItem.BackgroundImage = img;
            }
            QuantityItem.Text = detailcart.Quantity.ToString();
            
            
            
        }

        private void SizeSBtn_Click(object sender, EventArgs e)
        {
            size = "S";
            SizeSBtn.BackColor = Color.SandyBrown;
            SizeMBtn.BackColor = Color.AntiqueWhite;
            SizeLBtn.BackColor = Color.AntiqueWhite;
            PriceProduct = productinfo.PriceS;
            TotalPrice = (PriceProduct + PriceTopping) * detailcartinfo.Quantity;
            PriceItem.Text = TotalPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
            DetailCartConnect.ModifyItemCartSize(size, TotalPrice, detailcartinfo);
        }

        private void SizeMBtn_Click(object sender, EventArgs e)
        {
            size = "M";
            SizeMBtn.BackColor = Color.SandyBrown;
            SizeSBtn.BackColor = Color.AntiqueWhite;
            SizeLBtn.BackColor = Color.AntiqueWhite;
            PriceProduct = productinfo.PriceM;
            TotalPrice = (PriceProduct + PriceTopping) * detailcartinfo.Quantity;
            PriceItem.Text = TotalPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
            DetailCartConnect.ModifyItemCartSize(size, TotalPrice, detailcartinfo);
        }

        private void SizeLBtn_Click(object sender, EventArgs e)
        {
            size = "L";
            SizeLBtn.BackColor = Color.SandyBrown;
            SizeSBtn.BackColor = Color.AntiqueWhite;
            SizeMBtn.BackColor = Color.AntiqueWhite;
            PriceProduct = productinfo.PriceL;
            TotalPrice = (PriceProduct + PriceTopping) * detailcartinfo.Quantity;
            PriceItem.Text = TotalPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
            DetailCartConnect.ModifyItemCartSize(size, TotalPrice, detailcartinfo);
        }

        private void QuantityDown_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(QuantityItem.Text);
            if (number != 1)
            {
                number--;
            }
            else
            {
                QuantityDown.Enabled = false;
            }
            QuantityItem.Text = number.ToString();
        }

        private void QuantityUp_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(QuantityItem.Text);
            number++;
            if(number>1)
            {
                QuantityDown.Enabled = true;
            }
            QuantityItem.Text = number.ToString();
        }

        private void QuantityItem_TextChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(QuantityItem.Text);
            TotalPrice = (PriceProduct + PriceTopping) * quantity;
            DetailCartConnect.ModifyItemCartQuantity(quantity, TotalPrice, detailcartinfo);
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
            LHBeverage.instance.init();
        }
    }
}
