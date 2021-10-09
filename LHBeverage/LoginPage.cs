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
        public LoginPage()
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
        private void Checkinfo()
        {
            if (EmailTextBox.Text == "" || !IsValidEmailAddress(EmailTextBox.Text) || PasswordTextBox.Text == "" || PasswordTextBox.Text.Length <8)
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
            var HomePage = new LHBeverage();
            this.Hide();
            HomePage.ShowDialog();
            this.Close();

        }
        private void EmailText_Leave(object sender, EventArgs e)
        {
            TextBox emailBox = sender as TextBox;
            if(emailBox.Text == "" || !IsValidEmailAddress(emailBox.Text))
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
            if(emailBox.Text== "Please enter your email.")
            {
                emailBox.Text = "";
                emailBox.ForeColor = Color.Black;
            }
        }


    }
}
