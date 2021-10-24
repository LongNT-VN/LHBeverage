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
    public partial class AdminImageCard : UserControl
    {
        int idimagetmp;
        int booleantmp;
        public AdminImageCard(Image image, int idImage, int checkEdit)
        {
            InitializeComponent();
            picturePro.Image = image;
            idimagetmp = idImage;
            booleantmp = checkEdit;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DataRow[] dr = PublicParam.dataTableImgPro.Select();
            foreach (DataRow dataRow in dr)
            {
                if (Convert.ToInt32(dataRow["IDImage"]) == idimagetmp)
                {
                    PublicParam.dataTableImgPro.Rows.Remove(dataRow);
                }
            }
            // update idImge;
            int i = 0;
            DataRow[] datarowUpdate = PublicParam.dataTableImgPro.Select();
            foreach (DataRow dataRow in datarowUpdate)
            {
                dataRow["IDImage"] = i;
                i++;
            }
            if(booleantmp == 0)
            {
                AdminManageProduct.instance.renderImgEditProByTable();
            }
            else
            {
                AdminManageProduct.instance.renderImgProByTable();
            }
           
        }

    }
}
