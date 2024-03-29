﻿using LHBeverage.Helper;
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
        int PriceTopping = 0;
        int PriceProduct = 0;
        int TotalPrice = 0;
        public ItemCart(DetailCart detailcart)
        {
            InitializeComponent();
            setmode();
            CreateDetailCat(detailcart);
        }

        public void CreateDetailCat(DetailCart detailcart)
        {
            detailcartinfo = detailcart;
            Product product = ProductConnect.SelectProductByIDPro(detailcart.IDPro);
            string[] listtop = detailcart.ListIDIngredient.Split(',');
            foreach (string idtopping in listtop)
            {
                if (idtopping != "")
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
                if (product.QuantitysizeS <= 0)
                {
                    SizeSBtn.BackColor = Color.DimGray;
                    SizeSBtn.Enabled = false;
                }
                if (product.QuantitysizeM <= 0)
                {
                    SizeMBtn.BackColor = Color.DimGray;
                    SizeMBtn.Enabled = false;
                }
                if (product.QuantitysizeL <= 0)
                {
                    SizeLBtn.BackColor = Color.DimGray;
                    SizeLBtn.Enabled = false;
                }
                if (size == "S")
                {
                    if (detailcartinfo.Size == "S")
                    {
                        SizeSBtn.BackColor = Color.SandyBrown;
                        SizeSBtn.Enabled = true;
                    }
                    PriceProduct = product.PriceS;
                }
                else if (size == "M")
                {
                    if (detailcartinfo.Size == "M")
                    {
                        SizeMBtn.BackColor = Color.SandyBrown;
                        SizeMBtn.Enabled = true;
                    }

                    PriceProduct = product.PriceM;
                }
                else if (size == "L")
                {
                    if (detailcartinfo.Size == "L")
                    {
                        SizeLBtn.BackColor = Color.SandyBrown;
                        SizeLBtn.Enabled = true;
                    }

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
        private void setmode()
        {
            if (LHBeverage.instance.CurrentMode == 1)
            {
                SetMode.SetModeFunc(this, null, Color.Black, Color.White, Color.DarkGoldenrod, Color.White, Color.Black);
            }
            else
            {
                SetMode.SetModeFunc(this, null, Color.White, Color.Black, Color.DarkGoldenrod, Color.Black, Color.White);
            }
            if(QuantityDown.Enabled)
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
            RemoveBtn.BackColor = Color.Red;
            SizeMBtn.BackColor = Color.Black;
            SizeSBtn.BackColor = Color.Black;
            SizeLBtn.BackColor = Color.Black;
        }
        private void SizeSBtn_Click(object sender, EventArgs e)
        {
            if(size!="S")
            {
                ProductConnect.UpdateProductQuantity(productinfo, size, -quantity);
                size = "S";
               
                SizeSBtn.BackColor = Color.SandyBrown;
                if (SizeMBtn.Enabled)
                {
                    SizeMBtn.BackColor = Color.AntiqueWhite;
                }
                if (SizeLBtn.Enabled)
                {
                    SizeLBtn.BackColor = Color.AntiqueWhite;
                }
                if (productinfo.QuantitysizeS < Convert.ToInt32(QuantityItem.Text))
                {
                    ProductConnect.UpdateProductQuantity(productinfo, size, (Convert.ToInt32(QuantityItem.Text) - productinfo.QuantitysizeS));
                    QuantityItem.Text = productinfo.QuantitysizeS.ToString();
                    ProductConnect.UpdateProductQuantity(productinfo, size, quantity);
                }
                else if (productinfo.QuantitysizeS == Convert.ToInt32(QuantityItem.Text))
                {
                    ProductConnect.UpdateProductQuantity(productinfo, size, quantity);
                    QuantityUp.Enabled = false;
                    QuantityUp.BackColor = Color.DimGray;
                }
                else
                {
                    ProductConnect.UpdateProductQuantity(productinfo, size, quantity);
                    QuantityUp.Enabled = true;
                    QuantityUp.BackColor = Color.WhiteSmoke;
                }

                PriceProduct = productinfo.PriceS;
                TotalPrice = (PriceProduct + PriceTopping) * Convert.ToInt32(QuantityItem.Text);
                DetailCartConnect.ModifyItemCartSize(size, TotalPrice, detailcartinfo);
                PriceItem.Text = TotalPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";

            }
            
        }

        private void SizeMBtn_Click(object sender, EventArgs e)
        {
            if(size!="M")
            {
                ProductConnect.UpdateProductQuantity(productinfo, size, -quantity);
                size = "M";
                SizeMBtn.BackColor = Color.SandyBrown;
                if (SizeLBtn.Enabled)
                {
                    SizeLBtn.BackColor = Color.AntiqueWhite;
                }
                if (SizeSBtn.Enabled)
                {
                    SizeSBtn.BackColor = Color.AntiqueWhite;
                }

                if (productinfo.QuantitysizeM < Convert.ToInt32(QuantityItem.Text))
                {
                    ProductConnect.UpdateProductQuantity(productinfo, size, (Convert.ToInt32(QuantityItem.Text) - productinfo.QuantitysizeM));
                    QuantityItem.Text = productinfo.QuantitysizeM.ToString();
                    ProductConnect.UpdateProductQuantity(productinfo, size, quantity);
                }
                else if (productinfo.QuantitysizeM == Convert.ToInt32(QuantityItem.Text))
                {
                    ProductConnect.UpdateProductQuantity(productinfo, size, quantity);
                    QuantityUp.Enabled = false;
                    QuantityUp.BackColor = Color.DimGray;
                }
                else
                {
                    ProductConnect.UpdateProductQuantity(productinfo, size, quantity);
                    QuantityUp.Enabled = true;
                    QuantityUp.BackColor = Color.WhiteSmoke;
                }
                PriceProduct = productinfo.PriceM;
                TotalPrice = (PriceProduct + PriceTopping) * detailcartinfo.Quantity;
                PriceItem.Text = TotalPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
                DetailCartConnect.ModifyItemCartSize(size, TotalPrice, detailcartinfo);
            }
        }

        private void SizeLBtn_Click(object sender, EventArgs e)
        {
            if(size!="L")
            {
                ProductConnect.UpdateProductQuantity(productinfo, size, -quantity);
                size = "L";
                
                SizeLBtn.BackColor = Color.SandyBrown;
                if (SizeSBtn.Enabled)
                {
                    SizeSBtn.BackColor = Color.AntiqueWhite;
                }
                if (SizeMBtn.Enabled)
                {
                    SizeMBtn.BackColor = Color.AntiqueWhite;
                }

                if (productinfo.QuantitysizeL < Convert.ToInt32(QuantityItem.Text))
                {
                    ProductConnect.UpdateProductQuantity(productinfo, size, (Convert.ToInt32(QuantityItem.Text) - productinfo.QuantitysizeL));
                    QuantityItem.Text = productinfo.QuantitysizeL.ToString();
                    ProductConnect.UpdateProductQuantity(productinfo, size, quantity);
                }
                else if (productinfo.QuantitysizeL == Convert.ToInt32(QuantityItem.Text))
                {
                    ProductConnect.UpdateProductQuantity(productinfo, size, quantity);
                    QuantityUp.Enabled = false;
                    QuantityUp.BackColor = Color.DimGray;
                }
                else
                {
                    ProductConnect.UpdateProductQuantity(productinfo, size, quantity);
                    QuantityUp.Enabled = true;
                    QuantityUp.BackColor = Color.WhiteSmoke;
                }
                PriceProduct = productinfo.PriceL;
                TotalPrice = (PriceProduct + PriceTopping) * detailcartinfo.Quantity;
                DetailCartConnect.ModifyItemCartSize(size, TotalPrice, detailcartinfo);
                PriceItem.Text = TotalPrice.ToString("#,###", cul.NumberFormat) + " VNĐ";
            }
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
            if (number > 1)
            {
                QuantityDown.Enabled = true;
                QuantityDown.BackColor = Color.WhiteSmoke;
            }
        }

        private void QuantityItem_TextChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(QuantityItem.Text);
            TotalPrice = (PriceProduct + PriceTopping) * quantity;
            int currentquantity = detailcartinfo.Quantity;
            int quantityupdatetoProduct = quantity - currentquantity;
            if(Convert.ToInt32(QuantityItem.Text)==1)
            {
                QuantityDown.Enabled = false;
                QuantityDown.BackColor = Color.DimGray;
            }
            if (size == "S" && 0 >= productinfo.QuantitysizeS)
            {
                QuantityUp.Enabled = false;
                QuantityUp.BackColor = Color.DimGray;
            }
            else if (size == "M" && productinfo.QuantitysizeM <= 0)
            {
                QuantityUp.Enabled = false;
                QuantityUp.BackColor = Color.DimGray;
            }
            else if (size == "L" && 0 >= productinfo.QuantitysizeL)
            {
                QuantityUp.Enabled = false;
                QuantityUp.BackColor = Color.DimGray;
            }
            ProductConnect.UpdateProductQuantity(productinfo, size, quantityupdatetoProduct);
            DetailCartConnect.ModifyItemCartQuantity(quantity, TotalPrice, detailcartinfo);
            detailcartinfo.Price = TotalPrice;
            detailcartinfo.Quantity = quantity;
            LHBeverage.instance.init();
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
            int quantity = -detailcartinfo.Quantity;
            ProductConnect.UpdateProductQuantity(productinfo, size, quantity);
            DetailCartConnect.DeleteDetailCart(detailcartinfo);
            LHBeverage.instance.init();
        }
    }
}
