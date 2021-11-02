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
    public partial class AdminProductCard : UserControl
    {
        Product tmpPro = new Product();
        public AdminProductCard(Bitmap bmp,Product product)
        {
            InitializeComponent();
            Picture_Pro.Image = bmp;
            NameProduct_lbl.Text = product.Name;
            PriceSProduct_lbl.Text = product.PriceS.ToString();
            PriceMProduct_lbl.Text = product.PriceM.ToString();
            PriceLProduct_lbl.Text = product.PriceL.ToString();
            Quantity_lbl.Text = product.Quantity.ToString();
            //CategoryPro_lbl.Text = product.IDCate
            tmpPro = product;
        }

        private void EditPro_btn_Click(object sender, EventArgs e)
        {
            AdminManageProduct.instance.Edit_Product(tmpPro);
        }

        private void DeletePro_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure delete this product?","Notify",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ProductConnect.DeleteProduct(tmpPro.IDPro);
                AdminManageProduct.instance.loadData();
            }
        }
    }
}
