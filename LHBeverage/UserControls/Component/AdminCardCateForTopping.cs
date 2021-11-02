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
    public partial class AdminCardCateForTopping : UserControl
    {
        public AdminCardCateForTopping(string nameCate)
        {
            InitializeComponent();
            categoryname_lbl.Text = nameCate;
        }
    }
}
