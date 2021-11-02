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
    public partial class PopularProduct : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        Product protmp;
        public PopularProduct(Product product)
        {
            InitializeComponent();
            initialPro(product);
            protmp = product;

        }
        void initialPro(Product product)
        {
            DetailImage detailimage = DetailImageConnect.LoadOneImage(product.IDPro);
            ImgPro.Image = ConvertBase64toImage.ConverImageFromBase64(detailimage.ImageData);
            NamePro.Text = product.Name;
            Price.Text = product.PriceS.ToString("#,###", cul.NumberFormat) + " VNĐ";
        }

        private void Viewmore_btn_Click(object sender, EventArgs e)
        {
            LHBeverage.instance.NavProductFromHomeToDetail(protmp);
        }
    }
}
