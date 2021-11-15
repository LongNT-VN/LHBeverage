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

namespace LHBeverage.UserControls
{
    public partial class AdminDetailProduct : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public AdminDetailProduct(Product product)
        {
            InitializeComponent();
            CreateDetail(product);
        }
        public void CreateDetail(Product product)
        {
            List<DetailImage> detailImages= DetailImageConnect.LoadImage(product.IDPro);
            NameProduct_lbl.Text = product.Name;
            PriceS.Text = product.PriceS.ToString("#,###", cul.NumberFormat) + " VNĐ";
            PriceM.Text = product.PriceM.ToString("#,###", cul.NumberFormat) + " VNĐ";
            PriceL.Text = product.PriceL.ToString("#,###", cul.NumberFormat) + " VNĐ";

            if(product.QuantitysizeS <= 0)
            {
                QuantitysizeM.Text = "Sold out";
                QuantitysizeM.ForeColor = Color.Gray;
            }
            else
            {
                QuantitysizeM.Text = product.QuantitysizeS.ToString();
            }
            if (product.QuantitysizeM <= 0)
            {
                QuantitysizeS.Text = "Sold out";
                QuantitysizeS.ForeColor = Color.Gray;
            }
            else
            {
                QuantitysizeS.Text = product.QuantitysizeM.ToString();
            }
            if (product.QuantitysizeL <= 0)
            {
                QuantitysizeL.Text = "Sold out";
                QuantitysizeL.ForeColor = Color.Gray;
            }
            else
            {
                QuantitysizeL.Text = product.QuantitysizeL.ToString();
            }

            Description.Text = product.Description;


            int index = 0;
            foreach (DetailImage img in detailImages)
            {
                Image image = ConvertBase64toImage.ConverImageFromBase64(img.ImageData);
                if (image != null)
                {
                    index++;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.BackgroundImage = image;
                    pictureBox.Size = new Size(60, 60);
                    pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBox.Click += PictureBox_Click;
                    ListImagePanel.Controls.Add(pictureBox);
                    if (index == 1)
                    {
                        ImgItem.BackgroundImage = image;
                    }
                }
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (ImgItem.BackgroundImage != pictureBox.BackgroundImage)
            {
                ImgItem.BackgroundImage = pictureBox.BackgroundImage;
            }
        }

        private void Btn_backPageProduct_Click(object sender, EventArgs e)
        {
            AdminPage.instance.ProductsNav_Btn_Click( sender,  e);
        }
    }
}
