using LHBeverage.Model;
using LHBeverage.ModelService;
using LHBeverage.UserControls.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage.UserControls
{
    public partial class ManageProduct : UserControl
    {
        List<Category> categories;
        Customer cust;
        Bitmap bmp;
        string base64Img;
        int IdImage = 0;
        public ManageProduct(Customer customer)
        {
            InitializeComponent();
            loadData();
            cust = customer;
        }
        private void loadData()
        {
            categories = CategoryConnect.LoadCategory();
            // create Dictionnary comboSource to 
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
          
            foreach ( Category category in categories)
            {
                comboSource.Add(category.IDCate.ToString(), category.Name);
            }
            category_Cb.DataSource = new BindingSource(comboSource, null);
            category_Cb.DisplayMember = "Value";
            category_Cb.ValueMember = "Key";

            List<DetailImage> detailImages = DetailImageConnect.LoadImage();
            foreach (DetailImage detailImage in detailImages)
            {
                Bitmap bmp = converBase64ToBitmap(detailImage.ImageData);
                AdminProductCard adminProductCard = new AdminProductCard(bmp,"Cafe");
                ListPro_flowpanel.Controls.Add(adminProductCard);

            }
        }

        // Function convert image:
        public static string convertBitmapToBase64(Bitmap bmp)
        {
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Png);
            byte[] byteImage = ms.ToArray();
            string base64ImageString = Convert.ToBase64String(byteImage);
            return base64ImageString;
        }
        public static Bitmap converBase64ToBitmap(string base64)
        {
            Bitmap bmpReturn = null;
            //Convert Base64 string to byte[]
            byte[] byteBuffer = Convert.FromBase64String(base64);
            MemoryStream memoryStream = new MemoryStream(byteBuffer);

            memoryStream.Position = 0;

            bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);

            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;
            return bmpReturn;
        }

        private void AddPro_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int key = Convert.ToInt32(((KeyValuePair<string, string>)category_Cb.SelectedItem).Key);
                // create product:
                Product product = new Product();
                product.IDCate = key;
                product.IDCust = cust.IDCus;
                product.Name = NamePro_tb.Text;
                product.Price = Convert.ToInt32(Price_tb.Text);
                product.Description = Des_Tb.Text;
                product.Quantity = Convert.ToInt32(Quantity_tb.Text);
                product.Type = "Normal";
                product.IDCust = cust.IDCus;
                ProductConnect.CreateProduct(product);
                MessageBox.Show("Add Product successfull");
                NamePro_tb.Text = "";
                Des_Tb.Text = "";
                Quantity_tb.Text = "";
                Price_tb.Text = "";


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void AddImg_btn_Click(object sender, EventArgs e)
        {
            AddImg_panel.Visible = true;
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            List<Product> products = ProductConnect.LoadProduct();
            foreach(Product product in products)
            {
                comboSource.Add(product.IDPro.ToString(), product.Name);
            }
            ProductList_cb.DataSource = new BindingSource(comboSource, null);
            ProductList_cb.DisplayMember = "Value";
            ProductList_cb.ValueMember = "Key";

        }

        private void ImageBack_btn_Click(object sender, EventArgs e)
        {
            AddImg_panel.Visible = false;
        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog_Img.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(openFileDialog_Img.FileName);
                Image_Pb.Image = bmp;
                base64Img = convertBitmapToBase64(bmp);
                //bmp = null;
            }
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            try
            {
                DetailImage detailImage = new DetailImage();
                int IdPro = Convert.ToInt32(((KeyValuePair<string, string>)ProductList_cb.SelectedItem).Key);
                detailImage.IDPro = IdPro;
                detailImage.IDImage = IdImage;
                IdImage++;
                detailImage.ImageData = base64Img;
                base64Img = "";
                DetailImageConnect.CreateDetailImage(detailImage);
                MessageBox.Show("Add Image successfull");
                Image_Pb.Image = bmp;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
