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
    public partial class ManageCategory : UserControl
    {
        public ManageCategory()
        {
            InitializeComponent();
           
            initialListCate();
        }
        private void initialListCate()
        {
            List<Category> categories =  CategoryConnect.LoadCategory();
            foreach(Category category in categories)
            {
                Label label = new Label();
                label.Text = category.Name;
                ListCate_flowpanel.Controls.Add(label);
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
