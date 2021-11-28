using LHBeverage.Helper;
using LHBeverage.Model;
using LHBeverage.ModelService;
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
    public partial class AdminAccountPage : UserControl
    {
        ChangeLanguage changeLanguage = new ChangeLanguage();
        Bitmap AvatarTmp;
        Customer customerTmp = new Customer();
        public static AdminAccountPage instance;
        public AdminAccountPage(Customer customer)
        {
            InitializeComponent();
            initDataAccountPage(customer);
            customerTmp = customer;
            instance = this;
            SetMode();
         
        }
        public void SetMode()
        {
            if(PublicParam.ligthMode == true)
            {
                Account_MyDetail_panel.BackColor = Color.White;
            }
            else
            {
                Account_MyDetail_panel.BackColor = Color.FromArgb(30,30,30);
            }
            foreach (Control control in Account_MyDetail_panel.Controls)
            {
                    if (PublicParam.ligthMode == true)
                    {
                        //control.BackColor = Color.WhiteSmoke;
                       
                            if (control is Label)
                            {
                                if (control.ForeColor == Color.Aqua)
                                {
                                control.ForeColor = Color.Black;
                                }
                            }

                        
                    }
                    else
                    {
                       // control.BackColor = Color.FromArgb(30, 30, 30);
                     
                            if (control is Label)
                            {
                                if (control.ForeColor == Color.Black)
                                {
                                    control.ForeColor = Color.Aqua;
                                }
                            }

                    }

                
            }
        }
        void initDataAccountPage(Customer customer)
        {
            if (customer.Avatar != null)
            {
                Avatar_Pb.Image = ConvertBase64toImage.ConverImageFromBase64(customer.Avatar);
            }
            //setmode();
            AvatarTmp = new Bitmap(Avatar_Pb.Image);
           
            Name_tb.Text = customer.Name;
            Password_tb.Text = customer.Password;
            Age_tb.Text = customer.Age.ToString();
       
            if (customer.Gender == null)
            {
                if (changeLanguage.getLanguageMode() == "en")
                {
                    Gender_cb.SelectedIndex = Gender_cb.Items.IndexOf("Male");
                }
                else
                {

                    Gender_cb.SelectedIndex = Gender_cb.Items.IndexOf("Nam");
                }
            }
            else
            {
               
                Gender_cb.SelectedIndex = Gender_cb.Items.IndexOf(customer.Gender);
            }
            
            PhoneNb_tb.Text = customer.PhoneNumber;
            Address_tb.Text = customer.Address;
            Email_tb.Text = customer.Email;
          
        }

        private void UploadAvatar_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Avatar.ShowDialog() == DialogResult.OK)
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
                if (Gender_cb.SelectedItem == null)
                {
                    if (changeLanguage.getLanguageMode() == "en")
                    {
                        customerTmp.Gender = "Male";
                      
                    }
                    else
                    {
                        customerTmp.Gender = "Nam";
                    }
                }
                else
                {
                    customerTmp.Gender = Gender_cb.SelectedItem.ToString();
                }

                customerTmp.Address = Address_tb.Text;
                customerTmp.PhoneNumber = PhoneNb_tb.Text;
                customerTmp.Avatar = base64Avatar;
                customerTmp.Authorized = "Admin";
                CustomerConnect.UpdateCustomer(customerTmp);
                AdminPage.instance.renderCust(customerTmp);
                if(changeLanguage.getLanguageMode()=="en")
                {
                    MessageBox.Show("Update information successfull");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            Password_tb.PasswordChar = checkBox_showPass.Checked ? '\0' : '*';
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            AdminPage.instance.Logout();
        }

        private void changeLanguage_btn_Click(object sender, EventArgs e)
        {
            if (changeLanguage.getLanguageMode() == "en")
            {
                changeLanguage.UpdateConfig("language", "vi-VN");
                Application.Restart();
            }
            else
            {
                changeLanguage.UpdateConfig("language", "en");
                Application.Restart();
            }


        }
    }
}
