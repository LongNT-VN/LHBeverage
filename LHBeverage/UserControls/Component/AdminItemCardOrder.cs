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
        ChangeLanguage changeLanguage = new ChangeLanguage();
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
            if(product != null)
            {
                nameOrder.Text = product.Name;
            }
            else
            {
                if(changeLanguage.getLanguageMode()=="en")
                {
                    nameOrder.Text = "The product is no longer in business";
                }
                else
                {
                    nameOrder.Text = "Sản phẩm không còn kinh doanh";
                }
               
            }
          
            amount.Text = detailOrder.Quantity.ToString();
            Price.Text = detailOrder.Price.ToString("#,###", cul.NumberFormat) + " VNĐ";
            size.Text = detailOrder.Size;

            if (detailOrder.Topping != "")
            {
                string[] Toppings = detailOrder.Topping.Split(',');
                string toppinginfo = "";
                foreach (string toppingitem in Toppings)
                {
                    if (toppingitem != "")
                    {
                        Topping topping = ToppingConnect.SelectToppingByID(Convert.ToInt32(toppingitem));
                        toppinginfo += topping.ToppingName + "\n";
                    }
                }
                panelTopping.Visible = true;
                toppingLbl.Text = toppinginfo;
            }
        }
    }
}
