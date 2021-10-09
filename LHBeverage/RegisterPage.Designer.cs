
namespace LHBeverage
{
    partial class RegisterPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegisterForm = new System.Windows.Forms.Panel();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.ErrorConfirmLabel = new System.Windows.Forms.Label();
            this.ErrorPasswordLabel = new System.Windows.Forms.Label();
            this.ErrorLastNameLabel = new System.Windows.Forms.Label();
            this.ErrorPhoneLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorFirstNameLabel = new System.Windows.Forms.Label();
            this.ErrorEmailLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.HaveaccountLabel = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.BannerPic = new System.Windows.Forms.PictureBox();
            this.RegisterForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterForm
            // 
            this.RegisterForm.Controls.Add(this.ConfirmPasswordLabel);
            this.RegisterForm.Controls.Add(this.LinkLabel);
            this.RegisterForm.Controls.Add(this.ErrorConfirmLabel);
            this.RegisterForm.Controls.Add(this.ErrorPasswordLabel);
            this.RegisterForm.Controls.Add(this.ErrorLastNameLabel);
            this.RegisterForm.Controls.Add(this.ErrorPhoneLabel);
            this.RegisterForm.Controls.Add(this.label1);
            this.RegisterForm.Controls.Add(this.ErrorFirstNameLabel);
            this.RegisterForm.Controls.Add(this.ErrorEmailLabel);
            this.RegisterForm.Controls.Add(this.AddressLabel);
            this.RegisterForm.Controls.Add(this.PasswordLabel);
            this.RegisterForm.Controls.Add(this.FirstNameTextBox);
            this.RegisterForm.Controls.Add(this.LastNameTextBox);
            this.RegisterForm.Controls.Add(this.AddressTextBox);
            this.RegisterForm.Controls.Add(this.EmailTextBox);
            this.RegisterForm.Controls.Add(this.PhoneNumberTextBox);
            this.RegisterForm.Controls.Add(this.PasswordTextBox);
            this.RegisterForm.Controls.Add(this.ConfirmPasswordTextBox);
            this.RegisterForm.Controls.Add(this.RegisterBtn);
            this.RegisterForm.Controls.Add(this.LastNameLabel);
            this.RegisterForm.Controls.Add(this.FirstNameLabel);
            this.RegisterForm.Controls.Add(this.PhoneNumberLabel);
            this.RegisterForm.Controls.Add(this.EmailLabel);
            this.RegisterForm.Controls.Add(this.HaveaccountLabel);
            this.RegisterForm.Controls.Add(this.RegisterLabel);
            this.RegisterForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterForm.Location = new System.Drawing.Point(550, 0);
            this.RegisterForm.Name = "RegisterForm";
            this.RegisterForm.Size = new System.Drawing.Size(714, 681);
            this.RegisterForm.TabIndex = 3;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(380, 440);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(250, 40);
            this.ConfirmPasswordLabel.TabIndex = 13;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // LinkLabel
            // 
            this.LinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LinkLabel.LinkColor = System.Drawing.Color.DarkGoldenrod;
            this.LinkLabel.Location = new System.Drawing.Point(530, 80);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(120, 40);
            this.LinkLabel.TabIndex = 0;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "Login";
            this.LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // ErrorConfirmLabel
            // 
            this.ErrorConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorConfirmLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorConfirmLabel.Location = new System.Drawing.Point(384, 515);
            this.ErrorConfirmLabel.Name = "ErrorConfirmLabel";
            this.ErrorConfirmLabel.Size = new System.Drawing.Size(250, 30);
            this.ErrorConfirmLabel.TabIndex = 11;
            this.ErrorConfirmLabel.Text = "Confirm password not match !";
            this.ErrorConfirmLabel.Visible = false;
            // 
            // ErrorPasswordLabel
            // 
            this.ErrorPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorPasswordLabel.Location = new System.Drawing.Point(80, 515);
            this.ErrorPasswordLabel.Name = "ErrorPasswordLabel";
            this.ErrorPasswordLabel.Size = new System.Drawing.Size(250, 30);
            this.ErrorPasswordLabel.TabIndex = 11;
            this.ErrorPasswordLabel.Text = "Please enter your password !";
            this.ErrorPasswordLabel.Visible = false;
            // 
            // ErrorLastNameLabel
            // 
            this.ErrorLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLastNameLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLastNameLabel.Location = new System.Drawing.Point(382, 215);
            this.ErrorLastNameLabel.Name = "ErrorLastNameLabel";
            this.ErrorLastNameLabel.Size = new System.Drawing.Size(278, 30);
            this.ErrorLastNameLabel.TabIndex = 10;
            this.ErrorLastNameLabel.Text = "Please enter your last name !";
            this.ErrorLastNameLabel.Visible = false;
            // 
            // ErrorPhoneLabel
            // 
            this.ErrorPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPhoneLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorPhoneLabel.Location = new System.Drawing.Point(380, 415);
            this.ErrorPhoneLabel.Name = "ErrorPhoneLabel";
            this.ErrorPhoneLabel.Size = new System.Drawing.Size(278, 30);
            this.ErrorPhoneLabel.TabIndex = 10;
            this.ErrorPhoneLabel.Text = "Please enter correct  phone number !";
            this.ErrorPhoneLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(82, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 10;
            this.label1.Visible = false;
            // 
            // ErrorFirstNameLabel
            // 
            this.ErrorFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorFirstNameLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorFirstNameLabel.Location = new System.Drawing.Point(82, 215);
            this.ErrorFirstNameLabel.Name = "ErrorFirstNameLabel";
            this.ErrorFirstNameLabel.Size = new System.Drawing.Size(250, 30);
            this.ErrorFirstNameLabel.TabIndex = 10;
            this.ErrorFirstNameLabel.Text = "Please enter your first name !";
            this.ErrorFirstNameLabel.Visible = false;
            // 
            // ErrorEmailLabel
            // 
            this.ErrorEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorEmailLabel.Location = new System.Drawing.Point(80, 415);
            this.ErrorEmailLabel.Name = "ErrorEmailLabel";
            this.ErrorEmailLabel.Size = new System.Drawing.Size(250, 30);
            this.ErrorEmailLabel.TabIndex = 10;
            this.ErrorEmailLabel.Text = "Please enter correct email !";
            this.ErrorEmailLabel.Visible = false;
            // 
            // AddressLabel
            // 
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(80, 240);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(250, 40);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(80, 440);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(250, 40);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FirstNameTextBox.Location = new System.Drawing.Point(84, 180);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(242, 30);
            this.FirstNameTextBox.TabIndex = 1;
            this.FirstNameTextBox.Text = "First name.";
            this.FirstNameTextBox.WordWrap = false;
            this.FirstNameTextBox.Click += new System.EventHandler(this.FirstNameTextBox_Click);
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            this.FirstNameTextBox.Leave += new System.EventHandler(this.FirstNameTextBox_Leave);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LastNameTextBox.Location = new System.Drawing.Point(384, 180);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(246, 30);
            this.LastNameTextBox.TabIndex = 2;
            this.LastNameTextBox.Text = "Last name.";
            this.LastNameTextBox.WordWrap = false;
            this.LastNameTextBox.Click += new System.EventHandler(this.LastNameTextBox_Click);
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            this.LastNameTextBox.Leave += new System.EventHandler(this.LastNameTextBox_Leave);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddressTextBox.Location = new System.Drawing.Point(84, 280);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(550, 30);
            this.AddressTextBox.TabIndex = 3;
            this.AddressTextBox.Text = "Your Address.";
            this.AddressTextBox.Click += new System.EventHandler(this.AddressTextBox_Click);
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.EmailTextBox.Location = new System.Drawing.Point(84, 380);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(246, 30);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.Text = "Please enter your email.";
            this.EmailTextBox.WordWrap = false;
            this.EmailTextBox.Click += new System.EventHandler(this.EmailTextBox_Click);
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(384, 380);
            this.PhoneNumberTextBox.MaxLength = 10;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(246, 30);
            this.PhoneNumberTextBox.TabIndex = 5;
            this.PhoneNumberTextBox.Text = "Phone Number.";
            this.PhoneNumberTextBox.WordWrap = false;
            this.PhoneNumberTextBox.Click += new System.EventHandler(this.PhoneNumberTextBox_Click);
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            this.PhoneNumberTextBox.Leave += new System.EventHandler(this.PhoneNumberTextBox_Leave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(84, 480);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(246, 30);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PaswwordTextBox_TextChanged);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(384, 480);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(246, 30);
            this.ConfirmPasswordTextBox.TabIndex = 7;
            this.ConfirmPasswordTextBox.Leave += new System.EventHandler(this.ConfirmPasswordTextBox_Leave);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.RegisterBtn.Enabled = false;
            this.RegisterBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.RegisterBtn.FlatAppearance.BorderSize = 2;
            this.RegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(257, 560);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(200, 40);
            this.RegisterBtn.TabIndex = 8;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(380, 140);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(250, 40);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(80, 140);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(250, 40);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(380, 340);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(250, 40);
            this.PhoneNumberLabel.TabIndex = 2;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(80, 340);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(250, 40);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email";
            // 
            // HaveaccountLabel
            // 
            this.HaveaccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HaveaccountLabel.Location = new System.Drawing.Point(350, 80);
            this.HaveaccountLabel.Name = "HaveaccountLabel";
            this.HaveaccountLabel.Size = new System.Drawing.Size(180, 40);
            this.HaveaccountLabel.TabIndex = 1;
            this.HaveaccountLabel.Text = "Have a account?";
            this.HaveaccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(80, 80);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(250, 40);
            this.RegisterLabel.TabIndex = 0;
            this.RegisterLabel.Text = "Register";
            this.RegisterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BannerPic
            // 
            this.BannerPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BannerPic.BackgroundImage = global::LHBeverage.Properties.Resources.Banner;
            this.BannerPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BannerPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.BannerPic.Location = new System.Drawing.Point(0, 0);
            this.BannerPic.Name = "BannerPic";
            this.BannerPic.Size = new System.Drawing.Size(550, 681);
            this.BannerPic.TabIndex = 2;
            this.BannerPic.TabStop = false;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.RegisterForm);
            this.Controls.Add(this.BannerPic);
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.RegisterForm.ResumeLayout(false);
            this.RegisterForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegisterForm;
        private System.Windows.Forms.Label ErrorPasswordLabel;
        private System.Windows.Forms.Label ErrorEmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label HaveaccountLabel;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.PictureBox BannerPic;
        private System.Windows.Forms.LinkLabel LinkLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ErrorConfirmLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label ErrorPhoneLabel;
        private System.Windows.Forms.Label ErrorLastNameLabel;
        private System.Windows.Forms.Label ErrorFirstNameLabel;
        private System.Windows.Forms.Label label1;
    }
}