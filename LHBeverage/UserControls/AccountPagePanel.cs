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
    public partial class AccountPagePanel : UserControl
    {
        Color globalColorActive;
        Bitmap AvatarTmp;
        Customer customerTmp = new Customer();
        public AccountPagePanel(Customer cust )
        {
            InitializeComponent();
            globalColorActive = Color.Azure;
            initDataAccountPage(cust);
            customerTmp = cust;


        }
        void initDataAccountPage(Customer customer)
        {
            AvatarTmp = new Bitmap(Avatar_Pb.Image);
            if (customer.Avatar != null)
            {
                Avatar_Pb.Image = ConvertBase64toImage.ConverImageFromBase64(customer.Avatar);
            }
            Name_tb.Text = customer.Name;
            Password_tb.Text = customer.Password;
            Age_tb.Text = customer.Age.ToString();
          
            if(customer.Gender == null)
            {
                Gender_cb.SelectedIndex = Gender_cb.Items.IndexOf("Male");
             
            }
            else
            {
                Gender_cb.SelectedIndex = Gender_cb.Items.IndexOf(customer.Gender);

                //Gender_cb.SelectedValue = customer.Gender;
            }

            PhoneNb_tb.Text = customer.PhoneNumber;
            Address_tb.Text = customer.Address;
            Email_tb.Text = customer.Email;
        }

       
        private void btn_Mydetail_Click(object sender, EventArgs e)
        {
            Account_MyDetail_panel.Visible = true;
            Account_MyDetail_panel.BringToFront();
            btn_Mydetail.BackColor = globalColorActive;
            btn_MyOrders.BackColor = Color.White;

        }

        private void btn_MyOrders_Click(object sender, EventArgs e)
        {
            Account_MyDetail_panel.Visible = false;
            MyOrder_panel.Visible = true;
            MyOrder_panel.BringToFront();
            btn_Mydetail.BackColor = Color.White;
            btn_MyOrders.BackColor = globalColorActive;

            renderOrder();
           
        }

        private void UploadAvatar_btn_Click(object sender, EventArgs e)
        {
            
            if(openFileDialog_Avatar.ShowDialog() == DialogResult.OK)
            {
                AvatarTmp = new Bitmap(openFileDialog_Avatar.FileName);
                Avatar_Pb.Image = AvatarTmp;
            }
        }

        private void SaveAccount_btn_Click(object sender, EventArgs e)
        {
            string base64Avatar = "";
            if (AvatarTmp != null)
            {
                 base64Avatar = ConvertImageToBase64.convertBitmapToBase64(AvatarTmp);
            }
           
            try
            {

                customerTmp.Name = Name_tb.Text;
                customerTmp.Email = Email_tb.Text;
                customerTmp.Password = Password_tb.Text;
                customerTmp.Age = Convert.ToInt32(Age_tb.Text);
                if(Gender_cb.SelectedItem == null)
                {
                    customerTmp.Gender = "Male";
                }
                else
                {
                    customerTmp.Gender = Gender_cb.SelectedItem.ToString();
                }

                customerTmp.Address = Address_tb.Text;
                customerTmp.PhoneNumber = PhoneNb_tb.Text;
                customerTmp.Avatar = base64Avatar;
                customerTmp.Authorized = "member";
                CustomerConnect.UpdateCustomer(customerTmp);
                MessageBox.Show("Update information successfull");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            Password_tb.PasswordChar = checkBox_showPass.Checked ? '\0' : '*';
        }

        // My Order
         private void renderOrder()
        {
            Order_Flowpanel.Controls.Clear();
            List<Order> orders = new List<Order>();
            orders = OrderConnect.LoadOrder(customerTmp);
            foreach(Order order in orders)
            {
                CardOrder cardOrder = new CardOrder(order, customerTmp);
                Order_Flowpanel.Controls.Add(cardOrder);
            }
        }

    }
}
