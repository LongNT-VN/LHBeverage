using LHBeverage.Helper;
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
        public static AdminDashboard instance;
        public AdminDashboard()
        {
            InitializeComponent();
            renderInfor();
            instance = this;
        }
        void renderInfor()
        {
            List<Product> products = ProductConnect.LoadProduct();
            QuantityProduct_lbl.Text = products.Count.ToString();
            setMode();
        }
        public void setMode()
        {
            if (PublicParam.ligthMode == true)
            {
                this.BackColor = Color.FromArgb(209, 218, 235);
               // welcome_lbl.ForeColor = Color.Black;
                SetMode.SetModeFunc(this, null, Color.White, Color.Black, Color.DarkGoldenrod, Color.Black, Color.FromArgb(209, 218, 235));

            }
            else
            {
                SetMode.SetModeFunc(this, null, Color.Black, Color.White, Color.DarkGoldenrod, Color.White, Color.FromArgb(30, 30, 30));

                this.BackColor = Color.FromArgb(30, 30, 30);
               // welcome_lbl.ForeColor = Color.White;
            }
        }
    }
}
