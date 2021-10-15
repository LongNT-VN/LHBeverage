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
    public partial class AdminProductCard : UserControl
    {
        public AdminProductCard(Bitmap bmp, string name)
        {
            InitializeComponent();
            Picture_Pro.Image = bmp;
            NameProduct_lbl.Text = name;
        }
    }
}
