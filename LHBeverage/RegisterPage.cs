using LHBeverage.Model;
using LHBeverage.ModelService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }


        public bool IsValidEmailAddress(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);

                return true;
            }
            catch
            {
                return false;
            }
        }
        private void CheckTextBox(TextBox textbox, Label message)
        {
            if (textbox.Text == "")
            {
                message.Visible = true;
            }
            else
            {
                message.Visible = false;
            }
        }
        private bool CheckPhoneNumber(String Numberphone)
        {
            if (Numberphone.Length == 0)
            {
                return false;
            }
            else if (!Int32.TryParse(Numberphone, out int a))
            {
                return false;
            }
            else if (Numberphone[0].ToString() != "0" || Numberphone.Length != 10)
            {
                return false;
            }
            return true;
        }

        private void Checkinfo()
        {
            if (FirstNameTextBox.Text == "" || LastNameTextBox.Text == "" || !CheckPhoneNumber(PhoneNumberTextBox.Text) || EmailTextBox.Text == "" || CustomerConnect.IsCustomerExisted(EmailTextBox.Text) || !IsValidEmailAddress(EmailTextBox.Text) || PasswordTextBox.Text == "" || PasswordTextBox.Text.Length < 8)
            {
                RegisterBtn.Enabled = false;
            }
            else
            {
                RegisterBtn.Enabled = true;
            }
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var LoginPage = new LoginPage();
            this.Hide();
            LoginPage.ShowDialog();
            this.Close();
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //Tạo tài khoản
            Customer customer = new Customer();
            customer.Name= FirstNameTextBox.Text + LastNameTextBox.Text;
            if(AddressTextBox.Text!="")
            {
                customer.Address = AddressTextBox.Text;
            }
            else
            {
                customer.Address = "";
            }
            customer.PhoneNumber = PhoneNumberTextBox.Text;
            customer.Email = EmailTextBox.Text;
            customer.Age = 0;
            customer.Gender = "";
            customer.Password = PasswordTextBox.Text;
            customer.Authorized = "Member";
            customer.LHCoins = 0;
            CustomerConnect.CreateCustomer(customer);
            Customer customer1 = CustomerConnect.GetCustomerByEmail(customer.Email);
            CartConnect.CreateCart(customer1);
            //Chuyển về trang đăng nhập
            var LoginPage = new LoginPage();
            this.Hide();
            LoginPage.ShowDialog();
            this.Close();
        }


        private void FirstNameTextBox_Leave(object sender, EventArgs e)
        {
            TextBox FirstNameBox = sender as TextBox;
            CheckTextBox(FirstNameBox, ErrorFirstNameLabel);
            Checkinfo();
        }

        private void LastNameTextBox_Leave(object sender, EventArgs e)
        {
            TextBox LastNameBox = sender as TextBox;
            CheckTextBox(LastNameBox, ErrorLastNameLabel);
            Checkinfo();
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            TextBox emailBox = sender as TextBox;
            if (emailBox.Text == "" || !IsValidEmailAddress(emailBox.Text))
            {
                ErrorEmailLabel.Visible = true;
            }
            else
            {
                ErrorEmailLabel.Visible = false;
            }
            Checkinfo();
            if (CustomerConnect.IsCustomerExisted(emailBox.Text))
            {
                ErrorEmailLabel.Text = "Existed Account !";
                ErrorEmailLabel.Visible = true;
            }
        }

        private void PhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            TextBox Phonenumber = sender as TextBox;
            if (CheckPhoneNumber(Phonenumber.Text))
            {
                ErrorPhoneLabel.Visible = false;
            }
            else
            {
                ErrorPhoneLabel.Visible = true;
            }
            Checkinfo();
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            TextBox paswwordBox = sender as TextBox;
            if (paswwordBox.Text.Length < 8)
            {
                ErrorPasswordLabel.Visible = true;
            }
            else
            {
                ErrorPasswordLabel.Visible = false;
            }
            Checkinfo();
        }
        private void PaswwordTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox paswwordBox = sender as TextBox;
            if (paswwordBox.Text == "")
            {
                ErrorPasswordLabel.Visible = true;
            }
            else
            {
                ErrorPasswordLabel.Visible = false;
            }
            Checkinfo();
        }
        private void ConfirmPasswordTextBox_Leave(object sender, EventArgs e)
        {
            TextBox confirmpaswwordBox = sender as TextBox;
            if (confirmpaswwordBox.Text != PasswordTextBox.Text)
            {
                ErrorConfirmLabel.Visible = true;
            }
            else
            {
                ErrorConfirmLabel.Visible = false;
            }
            Checkinfo();
        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {
            TextBox emailBox = sender as TextBox;
            if (emailBox.Text == "Please enter your email.")
            {
                emailBox.Text = "";
                emailBox.ForeColor = Color.Black;
            }
        }

        private void PhoneNumberTextBox_Click(object sender, EventArgs e)
        {
            TextBox PhonenumberBox = sender as TextBox;
            if (PhonenumberBox.Text == "Phone Number.")
            {
                PhonenumberBox.Text = "";
                PhonenumberBox.ForeColor = Color.Black;
            }
        }

        private void FirstNameTextBox_Click(object sender, EventArgs e)
        {
            TextBox FisrtNameBox = sender as TextBox;
            if (FisrtNameBox.Text == "First name.")
            {
                FisrtNameBox.Text = "";
                FisrtNameBox.ForeColor = Color.Black;
            }
        }

        private void LastNameTextBox_Click(object sender, EventArgs e)
        {
            TextBox LastNameBox = sender as TextBox;
            if (LastNameBox.Text == "Last name.")
            {
                LastNameBox.Text = "";
                LastNameBox.ForeColor = Color.Black;
            }
        }

        private void AddressTextBox_Click(object sender, EventArgs e)
        {
            TextBox AddressBox = sender as TextBox;
            if (AddressBox.Text == "Your Address.")
            {
                AddressBox.Text = "";
                AddressBox.ForeColor = Color.Black;
            }
        }


        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox LastNameBox = sender as TextBox;
            LastNameBox.ForeColor = Color.Black;
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox FisrtNameBox = sender as TextBox;
            FisrtNameBox.ForeColor = Color.Black;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox AdressBox = sender as TextBox;
            AdressBox.ForeColor = Color.Black;
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox EmailBox = sender as TextBox;
            EmailBox.ForeColor = Color.Black;
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox PhoneNumberBox = sender as TextBox;
            PhoneNumberBox.ForeColor = Color.Black;
        }
    }
}
