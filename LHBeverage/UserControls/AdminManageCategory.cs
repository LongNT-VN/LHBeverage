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
    public partial class AdminManageCategory : UserControl
    {
        public static AdminManageCategory instance;
        Category categoryUpdate = new Category();
        public AdminManageCategory()
        {
            InitializeComponent();
            instance = this;
            initialListCate();
        }
        private void initialListCate()
        {
            ListCate_flowpanel.Controls.Clear();
            List<Category> categories =  CategoryConnect.LoadCategory();

            foreach(Category category in categories)
            {
                AdminCardCategory adminCardCategory = new AdminCardCategory(category);
                ListCate_flowpanel.Controls.Add(adminCardCategory);
            }
        }
        private void AddCate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.Name = AddCate_tb.Text;
                CategoryConnect.CreateCategory(category);
                MessageBox.Show("Add categorty successfull");
                initialListCate();
                AddCate_tb.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void setCategory(Category category)
        {
            AddCate_tb.Text = category.Name;
            categoryUpdate = category;
        }
        public void deleteCategory(Category category)
        {
            try
            {
                List<Product> products = ProductConnect.SelectProductByCategory(category.IDCate);
                if (products.Count > 0)
                {
                    MessageBox.Show("Exist product of category. Cannot delete it");
                }
                else
                {
                    CategoryConnect.DeleteCategory(category);
                    initialListCate();
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void UpdateCate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                categoryUpdate.Name = AddCate_tb.Text;
                CategoryConnect.UpdateCategory(categoryUpdate);
                initialListCate();
                MessageBox.Show("Update successfull");
                AddCate_tb.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
