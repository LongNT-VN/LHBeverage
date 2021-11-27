using LHBeverage.Helper;
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
        ChangeLanguage changeLanguage = new ChangeLanguage();
        Bitmap CateImageTmp;
        Image ImageRoot;
        public static AdminManageCategory instance;
        Category categoryUpdate = new Category();
        public AdminManageCategory()
        {
            InitializeComponent();
            instance = this;
            initialListCate();
            ImageRoot = ImageCate_pictureBox.Image;
            setMode();
        }
        public void setMode()
        {
            if(PublicParam.ligthMode == true)
            {
                this.BackColor = Color.FromArgb(209, 218, 235);
                panelAddCate.BackColor = Color.White;
                ListCate_flowpanel.BackColor = Color.WhiteSmoke;
            }
            else
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                panelAddCate.BackColor = Color.Black;
                ListCate_flowpanel.BackColor = Color.Black;
            }
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
                if(AddCate_tb.Text == "")
                {
                    if(changeLanguage.getLanguageMode()=="en")
                    {
                        MessageBox.Show("Please enter category name");
                    }
                   else
                    {
                        MessageBox.Show("Vui lòng nhập tên danh mục");
                    }
                }
                else
                {
                    category.Name = AddCate_tb.Text;
                    if (CateImageTmp != null)
                    {
                        category.CateImage = ConvertImageToBase64.convertBitmapToBase64(CateImageTmp);
                    }

                    CategoryConnect.CreateCategory(category);
                    if (changeLanguage.getLanguageMode() == "en")
                    {
                        MessageBox.Show("Add categorty successfull");
                    }
                    else
                    {
                        MessageBox.Show("Thêm danh mục thành công");
                    }
                    
                    initialListCate();
                    AddCate_tb.Text = "";
                    ImageCate_pictureBox.Image = ImageRoot;
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void setCategory(Category category)
        {
            AddCate_tb.Text = category.Name;
            if(category.CateImage != null)
            {
                ImageCate_pictureBox.Image = ConvertBase64toImage.ConverImageFromBase64(category.CateImage);
            }
            else
            {
                ImageCate_pictureBox.Image = ImageRoot;
            }
            categoryUpdate = category;
        }
        public void deleteCategory(Category category)
        {
            try
            {
                List<Product> products = ProductConnect.SelectProductByCategory(category.IDCate);
                if (products.Count > 0)
                {
                    if (changeLanguage.getLanguageMode() == "en")
                    {
                        MessageBox.Show("Exist product of category. Cannot delete it");
                    }
                    else
                    {
                        MessageBox.Show("Tồn tại sản phẩm thuộc danh mục. Không thể xóa");
                    }
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
                if (AddCate_tb.Text == "")
                {
                    if(changeLanguage.getLanguageMode()=="en")
                    {
                        MessageBox.Show("Please enter category name");
                    }
                   else
                    {
                        MessageBox.Show("Vui lòng nhập tên danh mục");
                    }
                }
                else
                {
                    categoryUpdate.Name = AddCate_tb.Text;
                    if (CateImageTmp != null)
                    {
                        categoryUpdate.CateImage = ConvertImageToBase64.convertBitmapToBase64(CateImageTmp);
                    }
                    CategoryConnect.UpdateCategory(categoryUpdate);
                    initialListCate();
                    if (changeLanguage.getLanguageMode() == "en")
                    {
                        MessageBox.Show("Update successfull");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thành công");
                    }
                    
                    AddCate_tb.Text = "";
                    ImageCate_pictureBox.Image = ImageRoot;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void ImageCate_pictureBox_Click(object sender, EventArgs e)
        {
            if(openImageCate.ShowDialog() == DialogResult.OK)
            {
                CateImageTmp = new Bitmap(openImageCate.FileName);
                ImageCate_pictureBox.Image = CateImageTmp;
            }
        }

      
    }
}
