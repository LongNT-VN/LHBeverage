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
    public partial class BigCard : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public BigCard(Product product, Image image)
        {
            InitializeComponent();
            nameDrinkBC_lbl.Text = product.Name;
            DesShortBC_lbl.Text = product.Description;
            //priceDrinksBC_lbl.Text = product.Price.ToString("#,###", cul.NumberFormat) + " VNĐ";
            BigCard_picture.Image = image;
        }

        private void DesShortBC_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
