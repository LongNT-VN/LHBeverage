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
        public AdminPage(Customer customer)
        { 
            InitializeComponent();
            AdminDashboard dashboard = new AdminDashboard();
            PublicParam.panelRoot.Location = new Point(250, 80);
            PublicParam.panelRoot.Size = new Size(1014, 600);
            PublicParam.panelRoot.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.Controls.Add(PublicParam.panelRoot);

            addUserControl(dashboard);
            cust = customer;
            PublicParam.dataTableImgPro.Columns.Add("IdPro", typeof(int));
            PublicParam.dataTableImgPro.Columns.Add("IdImage", typeof(int));
            PublicParam.dataTableImgPro.Columns.Add("ImageData", typeof(string));
        }
        Color activeColor = Color.FromArgb(209, 218, 235);
        //Gainsboro;
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            // delete control.
            panelRoot.Controls.Clear();
            // create control new
            panelRoot.Controls.Add(userControl);
            userControl.BringToFront();
        }

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
            addUserControl(dashboard);
            setBg_Color_Btn_SideBar();
            DashBoardNav_Btn.BackColor = activeColor;
        }

        private void ProductsNav_Btn_Click(object sender, EventArgs e)
        {
           
            // set active button
            setBg_Color_Btn_SideBar();
            ProductsNav_Btn.BackColor = activeColor;
            AdminManageProduct manageProduct = new AdminManageProduct(cust);
            addUserControl(manageProduct);
        }

        private void CategoryNav_Btn_Click(object sender, EventArgs e)
        {
            // set active button
            setBg_Color_Btn_SideBar();
            CategoryNav_Btn.BackColor = activeColor;
            AdminManageCategory manageCategory = new AdminManageCategory();
            addUserControl(manageCategory);
        }

        private void OrdersNav_Btn_Click(object sender, EventArgs e)
        {
            // set active button
            setBg_Color_Btn_SideBar();
            OrdersNav_Btn.BackColor = activeColor;
        }

        private void EmployeesNav_btn_Click(object sender, EventArgs e)
        {
            // set active button
            setBg_Color_Btn_SideBar();
            EmployeesNav_btn.BackColor = activeColor;
        }

        private void ToppingsNav_Btn_Click(object sender, EventArgs e)
        {
            AdminManageTopping adminManageTopping = new AdminManageTopping();
            addUserControl(adminManageTopping);
            setBg_Color_Btn_SideBar();
            ToppingsNav_Btn.BackColor = activeColor;
        }
       
    }
}
