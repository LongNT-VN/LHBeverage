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

namespace LHBeverage.UserControls.LHComponent
{
    public partial class ItemcardComponent : UserControl
    {

        public ItemcardComponent(Product product, Image image)
        {
            InitializeComponent();
            CreateComponent(product, image);
        }
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        private void CreateComponent(Product product, Image image)
        {
            ImageProductBeverage.BackgroundImage = image;
            ProductNameLabel.Text = product.Name;
            ProductPriceLabel.Text = product.Price.ToString("#,###", cul.NumberFormat) + " VNĐ";
        }
    }
}
