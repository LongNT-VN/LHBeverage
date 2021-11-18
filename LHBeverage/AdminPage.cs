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
            PublicParam.dataTableImgPro.Columns.Add("IdPro", typeof(int));
            PublicParam.dataTableImgPro.Columns.Add("IdImage", typeof(int));
            PublicParam.dataTableImgPro.Columns.Add("ImageData", typeof(string));
            instance = this;
        }
        Color activeColor = Color.FromArgb(209, 218, 235);

        //private void addUserControl(UserControl userControl)
        //{
        //    userControl.Dock = DockStyle.Fill;
        //    // delete control.
        //    PublicParam.panelRoot.Controls.Clear();
        //    // create control new
        //    PublicParam.panelRoot.Controls.Add(userControl);
        //    userControl.BringToFront();
        //}

        void setBg_Color_Btn_SideBar()
        {
            foreach(Control item in SideBarPanel.Controls.OfType<Button>().ToList())
            {
                item.BackColor = Color.White;
            }
        }

        private void DashBoardNav_Btn_Click(object sender, EventArgs e)
        {
            // set active button
            AdminDashboard dashboard = new AdminDashboard();
            AddNewPage.addUserControl(dashboard);
            setBg_Color_Btn_SideBar();
            DashBoardNav_Btn.BackColor = activeColor;
        }

        public void ProductsNav_Btn_Click(object sender, EventArgs e)
        {
           
            // set active button
            setBg_Color_Btn_SideBar();
            ProductsNav_Btn.BackColor = activeColor;
            AdminManageProduct manageProduct = new AdminManageProduct(cust);
            AddNewPage.addUserControl(manageProduct);
        }

        private void CategoryNav_Btn_Click(object sender, EventArgs e)
        {
            // set active button
            setBg_Color_Btn_SideBar();
            CategoryNav_Btn.BackColor = activeColor;
            AdminManageCategory manageCategory = new AdminManageCategory();
            AddNewPage.addUserControl(manageCategory);
        }

        private void OrdersNav_Btn_Click(object sender, EventArgs e)
        {
            // set active button
            setBg_Color_Btn_SideBar();
            OrdersNav_Btn.BackColor = activeColor;
            AdminManageOrder adminManageOrder = new AdminManageOrder();
          
            AddNewPage.addUserControl(adminManageOrder);
        }

        private void EmployeesNav_btn_Click(object sender, EventArgs e)
        {
            // set active button
            setBg_Color_Btn_SideBar();
            StatisticalNav_btn.BackColor = activeColor;
            AdminStatistical adminStatistical = new AdminStatistical();
            AddNewPage.addUserControl(adminStatistical);
        }

        private void ToppingsNav_Btn_Click(object sender, EventArgs e)
        {
            AdminManageTopping adminManageTopping = new AdminManageTopping();
         
            AddNewPage.addUserControl(adminManageTopping);
            setBg_Color_Btn_SideBar();
            ToppingsNav_Btn.BackColor = activeColor;
        }
       
    }
}
