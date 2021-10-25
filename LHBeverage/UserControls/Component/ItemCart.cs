using LHBeverage.Model;
using LHBeverage.ModelService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage.UserControls.Component
{
    public partial class ItemCart : UserControl
    {
        public ItemCart(DetailCart detailcart)
        {
            InitializeComponent();
            CreateDetailCat(detailcart);
        }
        public void CreateDetailCat(DetailCart detailcart)
        {
            List<Product> products = ProductConnect.SelectProductByIDPro(detailcart.IDPro);
            foreach(Product product in products)
            {
                if(product!=null)
                {
                    NameItem.Text = product.Name;
                }
            }
            
        }

    }
}
