using LHBeverage.Helper;
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
    public partial class LoginPage : Form
    {
        ChangeLanguage changeLanguage = new ChangeLanguage();
        public LoginPage()
        {
            InitializeComponent();
            if (changeLanguage.getLanguageMode() == "en")
            {
                VIBtn.BackColor = Color.White;
                EnBtn.BackColor = Color.DarkGoldenrod;
            }
            else
            {
                EnBtn.BackColor = Color.White;
                VIBtn.BackColor = Color.DarkGoldenrod;
            }
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
        private void Checkinfo()
        {
            if (EmailTextBox.Text == "" || !IsValidEmailAddress(EmailTextBox.Text) || PasswordTextBox.Text == "" || PasswordTextBox.Text.Length < 8)
            {
                LoginBtn.Enabled = false;
            }
            else
            {
                LoginBtn.Enabled = true;
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var RegisterPage = new RegisterPage();
            this.Hide();
            RegisterPage.ShowDialog();
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            int IDCus = CustomerConnect.CheckLogin(EmailTextBox.Text, PasswordTextBox.Text);
            if (IDCus != -1)
            {
                Customer customer = CustomerConnect.CustomerInfo(IDCus);
                if (customer.Authorized == "Admin")
                {
                    var AdminPage = new AdminPage(customer);
                    this.Hide();
                    AdminPage.ShowDialog();
                    this.Close();
                }
                else
                {
                    var HomePage = new LHBeverage(customer);
                    this.Hide();
                    HomePage.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                if (changeLanguage.getLanguageMode() == "en")
                {
                    MessageBox.Show("Wrong account or password!");
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
        }
        private void EmailText_Leave(object sender, EventArgs e)
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
        }
        private void PaswwordText_TextChanged(object sender, EventArgs e)
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
        private void PaswwordText_Leave(object sender, EventArgs e)
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

        private void EmailText_Click(object sender, EventArgs e)
        {
            TextBox emailBox = sender as TextBox;
            if (emailBox.Text == "Please enter your email." || emailBox.Text == "Nhập email.")
            {
                emailBox.Text = "";
                emailBox.ForeColor = Color.Black;
            }
        }

        private void EnBtn_Click(object sender, EventArgs e)
        {
            changeLanguage.UpdateConfig("language", "en");
            Application.Restart();
        }

        private void VIBtn_Click(object sender, EventArgs e)
        {
            changeLanguage.UpdateConfig("language", "vi-VN");
            Application.Restart();
        }
    }
}
