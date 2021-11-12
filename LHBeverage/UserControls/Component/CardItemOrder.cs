using LHBeverage.Model;
using LHBeverage.ModelService;
using LHBeverage.Helper;
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
    public partial class CardItemOrder : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public CardItemOrder(DetailOrder detailOrder)
        {
            InitializeComponent();
            CreateCard(detailOrder);
        }
        private void CreateCard(DetailOrder detailOrder)
        {
            Product product = ProductConnect.SelectProductByIDPro(detailOrder.IDPro);
            
            DetailImage detailImage = DetailImageConnect.LoadOneImage(detailOrder.IDPro);
            string productimagebase64= detailImage.ImageData;
            ImageProduct.BackgroundImage = ConvertBase64toImage.ConverImageFromBase64(productimagebase64);
            nameitem_lbl.Text = product.Name;
            amountitemOrder.Text = detailOrder.Quantity.ToString();
            sizeitem.Text = detailOrder.Size;
            Price_lbl.Text = detailOrder.Price.ToString("#,###", cul.NumberFormat) + " VNĐ";
            string[] Toppings = detailOrder.Topping.Split(',');
            string toppinginfo = "";
            foreach (string toppingitem in Toppings)
            {
                if(toppingitem!="")
                {
                    Topping topping = ToppingConnect.SelectToppingByID(Convert.ToInt32(toppingitem));
                    toppinginfo += topping.ToppingName + " ";
                }
            }
            Topping_lbl.Text = toppinginfo;

        }

    }
}
