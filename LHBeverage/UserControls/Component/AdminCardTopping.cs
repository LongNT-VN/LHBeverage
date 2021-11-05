using LHBeverage.Model;
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
    public partial class AdminCardTopping : UserControl
    {
        Topping toppingtmp;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public AdminCardTopping(Topping topping)
        {
            InitializeComponent();
            toppingtmp = topping;
            loadData(topping);
        }
        private void loadData(Topping topping)
        {
            nameTopping_lbl.Text = topping.ToppingName;
            PriceTopping_lbl.Text = topping.Price.ToString("#,###", cul.NumberFormat)+ "VNĐ";
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            AdminManageTopping.instance.renderToppingEdit(toppingtmp);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete it?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                AdminManageTopping.instance.Delete_Topping(toppingtmp);
            }
        }
    }
}
