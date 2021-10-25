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
        }
        public int id;
        private void CreateComponent(Product product, Image image)
        {
            id = product.IDPro;
            ImageProductBeverage.BackgroundImage = image;
            ProductNameLabel.Text = product.Name;
            ProductPriceLabel.Text = product.Price.ToString("#,###", cul.NumberFormat) + " VNĐ";
        }
        //public new event EventHandler Click
        //{
        //    add
        //    {
        //        base.Click += value;
        //        foreach (Control control in Controls)
        //        {
        //            control.Click += value;
        //        }
        //    }
        //    remove
        //    {
        //        base.Click -= value;
        //        foreach (Control control in Controls)
        //        {
        //            control.Click -= value;
        //        }
        //    }
        //}
    }
}
