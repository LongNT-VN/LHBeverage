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

namespace LHBeverage.UserControls
{
    public partial class AdminDashboard : UserControl
    {
        public AdminDashboard()
        {
            InitializeComponent();
            renderInfor();
        }
        void renderInfor()
        {
            List<Product> products = ProductConnect.LoadProduct();
            QuantityProduct_lbl.Text = products.Count.ToString();
        }
    }
}
