using LHBeverage.Model;
using LHBeverage.ModelService;
using LHBeverage.UserControls.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage.UserControls
{
    public partial class HomePagePanel : UserControl
    {
        public HomePagePanel()
        {
            InitializeComponent();
            //lbl_TitleOfBanner.Parent = pb_Banner;
            //lbl_TitleOfBanner.BackColor = Color.Transparent;
            initialPopularProduct();


        }
        void initialPopularProduct()
        {
            PopularProductFlowPanel.Controls.Clear();
            List<Product> pros = ProductConnect.LoadProduct();
            int i = 0;
            foreach(Product pro in pros)
            {
                if (i == 5)
                {
                    break;
                }
                
                    PopularProduct popularProduct = new PopularProduct(pro);
                    PopularProductFlowPanel.Controls.Add(popularProduct);
                
                i++;
            }
        }

    }
}
