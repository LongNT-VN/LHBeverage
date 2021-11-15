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
    public partial class AdminProductCard : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        Product tmpPro = new Product();
        public AdminProductCard(Bitmap bmp,Product product)
        {
            InitializeComponent();
            Picture_Pro.Image = bmp;
            NameProduct_lbl.Text = product.Name;
            PriceSProduct_lbl.Text = product.PriceS.ToString("#,###", cul.NumberFormat)+"VNĐ";
            PriceMProduct_lbl.Text = product.PriceM.ToString("#,###", cul.NumberFormat)+"VNĐ";
            PriceLProduct_lbl.Text = product.PriceL.ToString("#,###", cul.NumberFormat)+"VNĐ";
            QuantitysizeS_lbl.Text = product.QuantitysizeS.ToString();
            QuantitysizeM_lbl.Text = product.QuantitysizeM.ToString();
            QuantitysizeL_lbl.Text = product.QuantitysizeL.ToString();
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

        private void Picture_Pro_Click(object sender, EventArgs e)
        {
            AdminDetailProduct adminDetailProduct = new AdminDetailProduct(tmpPro);
            AddNewPage.addUserControl(adminDetailProduct);
        }
    }
}
