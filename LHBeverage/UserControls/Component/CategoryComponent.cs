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
    public partial class CategoryComponent : UserControl
    {
        
        public CategoryComponent(Category catagory)
        {
            InitializeComponent();
            createCatagory(catagory);
        }
        private void createCatagory(Category catagory)
        {
            Categorybtn.Text = catagory.Name;
            Categorybtn.Name = catagory.IDCate.ToString();
            Categorybtn.BackColor = Color.DarkGoldenrod;
            Categorybtn.ForeColor = Color.Black;
            if(catagory.CateImage!=null)
            {
                Image CateImg = ConvertBase64toImage.ConverImageFromBase64(catagory.CateImage);
                Categorybtn.Image = CateImg;
            }
        }
        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                Categorybtn.Click += value;
            }
            remove
            {
                base.Click -= value;
                Categorybtn.Click -= value;
            }
        }
    }
}
