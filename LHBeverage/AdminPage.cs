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
       
        public AdminPage(Customer customer)
        {
            
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            addUserControl(dashboard);

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
            Dashboard dashboard = new Dashboard();
            addUserControl(dashboard);
            setBg_Color_Btn_SideBar();
            DashBoardNav_Btn.BackColor = activeColor;
        }

        private void ProductsNav_Btn_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            addUserControl(manageProducts);
            // set active button
            setBg_Color_Btn_SideBar();
            ProductsNav_Btn.BackColor = activeColor;
        }

        private void CategoryNav_Btn_Click(object sender, EventArgs e)
        {
            // set active button
            setBg_Color_Btn_SideBar();
            CategoryNav_Btn.BackColor = activeColor;
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
    }
}
