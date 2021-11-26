using LHBeverage.Helper;
using LHBeverage.Model;
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
    public partial class AdminCardCategory : UserControl
    {
        Category CategoryTmp = new Category();
        public AdminCardCategory(Category category)
        {
            InitializeComponent();
            CategoryTmp = category;
            renderCategory(category);
        }
        private void renderCategory(Category category)
        {
            nameCategory_lbl.Text = category.Name;
            if(category.CateImage != null)
            {
                CateImage.Image = ConvertBase64toImage.ConverImageFromBase64(category.CateImage);
            }     
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            AdminManageCategory.instance.setCategory(CategoryTmp);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you sure delete it?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                AdminManageCategory.instance.deleteCategory(CategoryTmp);
            }

        }
    }
}
