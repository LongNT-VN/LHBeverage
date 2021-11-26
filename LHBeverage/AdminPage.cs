using LHBeverage.Helper;
using LHBeverage.Model;
using LHBeverage.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage
{
    public partial class AdminPage : Form
    {
        Customer cust;
        public static AdminPage instance;
        Color activeColor = Color.FromArgb(209, 218, 235);
       
        public AdminPage(Customer customer)
        { 
            InitializeComponent();
         
            PublicParam.panelRoot.Location = new Point(250, 80);
            PublicParam.panelRoot.Size = new Size(1014, 600);
            PublicParam.panelRoot.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.Controls.Add(PublicParam.panelRoot);

            AdminDashboard dashboard = new AdminDashboard();
            AddNewPage.addUserControl(dashboard);   
            cust = customer;
            renderCust(customer);
            PublicParam.dataTableImgPro.Columns.Add("IdPro", typeof(int));
            PublicParam.dataTableImgPro.Columns.Add("IdImage", typeof(int));
            PublicParam.dataTableImgPro.Columns.Add("ImageData", typeof(string));
            PublicParam.indexNav = 1;
            instance = this;
            SetMode();
        }
       
        public void SetMode()
        {
            if (AdminDetailProduct.instance != null)
            {
                AdminDetailProduct.instance.SetMode();
            }
            if (AdminAccountPage.instance != null)
            {
                AdminAccountPage.instance.SetMode();
            }
            if (PublicParam.ligthMode == true)
            {
                Light_Dark_PB.Image = Properties.Resources.brightness;
                SideBarPanel.BackColor = Color.White;
                panelTopBar.BackColor = Color.White;
                AccountName_lbl.ForeColor = Color.Black;
                this.BackColor = Color.FromArgb(209, 218, 235);
                activeColor = Color.FromArgb(209, 218, 235);
                DashBoardNav_Btn.ForeColor = Color.MidnightBlue;
            }
            else
            {
                Light_Dark_PB.Image = Properties.Resources.moon;
                SideBarPanel.BackColor = Color.Black;
                panelTopBar.BackColor = Color.Black;
                AccountName_lbl.ForeColor = Color.White;
                this.BackColor = Color.FromArgb(30, 30, 30);
                activeColor = Color.FromArgb(30, 30, 30);
                DashBoardNav_Btn.ForeColor = Color.White;
            }
            setBg_Color_Btn_SideBar();
            checkIndex();
        }
       
        public void renderCust(Customer customer)
        {
            AccountName_lbl.Text = customer.Name;
            if(customer.Avatar != null)
            {
                Avatar_picturebox.Image = ConvertBase64toImage.ConverImageFromBase64(customer.Avatar);
            }
        }
        void checkIndex()
        {
            if (PublicParam.indexNav == 1)
            {
                DashBoardNav_Btn.BackColor = activeColor;
                AdminDashboard.instance.setMode();
            }
            if (PublicParam.indexNav == 2)
            {
                ProductsNav_Btn.BackColor = activeColor;
                AdminManageProduct.instance.setMode();
            }
            if (PublicParam.indexNav == 3)
            {
                CategoryNav_Btn.BackColor = activeColor;
                AdminManageCategory.instance.setMode();
            }
            if (PublicParam.indexNav == 4)
            {
                ToppingsNav_Btn.BackColor = activeColor;
                AdminManageTopping.instance.setMode();
            }
            if (PublicParam.indexNav == 5)
            {
                OrdersNav_Btn.BackColor = activeColor;
                AdminManageOrder.instance.setMode();
            }
            if (PublicParam.indexNav == 6)
            {
                AdminStatistical.instance.setMode();
                StatisticalNav_btn.BackColor = activeColor;
            }
        }
        void setBg_Color_Btn_SideBar()
        {         
            foreach (Control item in SideBarPanel.Controls.OfType<Button>().ToList())
            {
                if(item.Name != "Logout_btn")
                {
                    if(PublicParam.ligthMode == true)
                    {
                        item.BackColor = Color.White;
                    }
                    else
                    {
                        item.BackColor = Color.Black;
                    }
                }
            }
        }

        private void DashBoardNav_Btn_Click(object sender, EventArgs e)
        {
            // set active button
            AdminDashboard dashboard = new AdminDashboard();
            AddNewPage.addUserControl(dashboard);
            setBg_Color_Btn_SideBar();
            DashBoardNav_Btn.BackColor = activeColor;
            PublicParam.indexNav = 1;
        }

        public void ProductsNav_Btn_Click(object sender, EventArgs e)
        {
            // set active button
            setBg_Color_Btn_SideBar();
            ProductsNav_Btn.BackColor = activeColor;
            AdminManageProduct manageProduct = new AdminManageProduct(cust);
            AddNewPage.addUserControl(manageProduct);
            PublicParam.indexNav = 2;
        }

        private void CategoryNav_Btn_Click(object sender, EventArgs e)
        {
            // set active button
            setBg_Color_Btn_SideBar();
            CategoryNav_Btn.BackColor = activeColor;
            AdminManageCategory manageCategory = new AdminManageCategory();
            AddNewPage.addUserControl(manageCategory);
            PublicParam.indexNav = 3;
        }

        private void ToppingsNav_Btn_Click(object sender, EventArgs e)
        {
            AdminManageTopping adminManageTopping = new AdminManageTopping();
            AddNewPage.addUserControl(adminManageTopping);
            setBg_Color_Btn_SideBar();
            ToppingsNav_Btn.BackColor = activeColor;
            PublicParam.indexNav = 4;
        }
        private void OrdersNav_Btn_Click(object sender, EventArgs e)
        {
            // set active button
            setBg_Color_Btn_SideBar();
            OrdersNav_Btn.BackColor = activeColor;
            AdminManageOrder adminManageOrder = new AdminManageOrder();
            AddNewPage.addUserControl(adminManageOrder);
            PublicParam.indexNav = 5;
        }
        private void StatisticalNav_btn_Click(object sender, EventArgs e)
        {
            setBg_Color_Btn_SideBar();
            StatisticalNav_btn.BackColor = activeColor;
            AdminStatistical adminStatistical = new AdminStatistical();
            AddNewPage.addUserControl(adminStatistical);
            PublicParam.indexNav = 6;
        }

        private void Avatar_picturebox_Click(object sender, EventArgs e)
        {
            AdminAccountPage adminAccountPage = new AdminAccountPage(cust);        
            AddNewPage.addUserControl(adminAccountPage);
           
        }
        public void Logout()
        {
           PublicParam.dataTableImgPro.Reset();
           var Login = new LoginPage();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Light_Dark_PB_Click(object sender, EventArgs e)
        {
            PublicParam.ligthMode = !PublicParam.ligthMode;
            SetMode();
        }

    
    }
}
