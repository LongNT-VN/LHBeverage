using LHBeverage.Helper;
using LHBeverage.Model;
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
    public partial class ItemcardComponent : UserControl
    {

        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public ItemcardComponent(Product product, Image image)
        {
            InitializeComponent();
            CreateComponent(product, image);
            setmode();
        }
        public int id;
        private void CreateComponent(Product product, Image image)
        {
            id = product.IDPro;
            ImageProductBeverage.BackgroundImage = image;
            ProductNameLabel.Text = product.Name;
            ProductPriceLabel.Text = product.PriceS.ToString("#,###", cul.NumberFormat) + " VNĐ";
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
            ProductPriceLabel.ForeColor = Color.DarkGoldenrod;
        }
    }
}
