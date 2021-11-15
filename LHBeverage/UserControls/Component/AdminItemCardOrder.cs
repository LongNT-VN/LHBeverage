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
    public partial class AdminItemCardOrder : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public AdminItemCardOrder(DetailOrder detailOrder)
        {
            InitializeComponent();
            init(detailOrder);
           
        }
        void init(DetailOrder detailOrder)
        {
            DetailImage detailImage = DetailImageConnect.LoadOneImage(detailOrder.IDPro);
            ImageItem.Image = ConvertBase64toImage.ConverImageFromBase64(detailImage.ImageData);
            Product product = ProductConnect.SelectProductByIDPro(detailOrder.IDPro);

            nameOrder.Text = product.Name;
            amount.Text = detailOrder.Quantity.ToString();
            Price.Text = detailOrder.Price.ToString("#,###", cul.NumberFormat) + " VNĐ";
            size.Text = detailOrder.Size;
            if(detailOrder.Topping != "")
            {
                panelTopping.Visible = true;
                toppingLbl.Text = detailOrder.Topping;
            }
        }
    }
}
