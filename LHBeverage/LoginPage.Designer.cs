
namespace LHBeverage
{
    partial class LoginPage
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
            this.LoginForm = new System.Windows.Forms.Panel();
            this.ErrorPasswordLabel = new System.Windows.Forms.Label();
            this.ErrorEmailLabel = new System.Windows.Forms.Label();
            this.OtherLabel = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PaswwordLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.WelcomLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.BannerPic = new System.Windows.Forms.PictureBox();
            this.LoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginForm
            // 
            this.LoginForm.Controls.Add(this.ErrorPasswordLabel);
            this.LoginForm.Controls.Add(this.ErrorEmailLabel);
            this.LoginForm.Controls.Add(this.OtherLabel);
            this.LoginForm.Controls.Add(this.RegisterBtn);
            this.LoginForm.Controls.Add(this.PasswordTextBox);
            this.LoginForm.Controls.Add(this.PaswwordLabel);
            this.LoginForm.Controls.Add(this.EmailTextBox);
            this.LoginForm.Controls.Add(this.LoginBtn);
            this.LoginForm.Controls.Add(this.EmailLabel);
            this.LoginForm.Controls.Add(this.WelcomLabel);
            this.LoginForm.Controls.Add(this.LoginLabel);
            this.LoginForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginForm.Location = new System.Drawing.Point(550, 0);
            this.LoginForm.Name = "LoginForm";
            this.LoginForm.Size = new System.Drawing.Size(714, 681);
            this.LoginForm.TabIndex = 1;
            // 
            // ErrorPasswordLabel
            // 
            this.ErrorPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorPasswordLabel.Location = new System.Drawing.Point(100, 435);
            this.ErrorPasswordLabel.Name = "ErrorPasswordLabel";
            this.ErrorPasswordLabel.Size = new System.Drawing.Size(514, 30);
            this.ErrorPasswordLabel.TabIndex = 11;
            this.ErrorPasswordLabel.Text = "Please enter your password !";
            this.ErrorPasswordLabel.Visible = false;
            // 
            // ErrorEmailLabel
            // 
            this.ErrorEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorEmailLabel.Location = new System.Drawing.Point(100, 335);
            this.ErrorEmailLabel.Name = "ErrorEmailLabel";
            this.ErrorEmailLabel.Size = new System.Drawing.Size(514, 30);
            this.ErrorEmailLabel.TabIndex = 10;
            this.ErrorEmailLabel.Text = "Please enter correct email !";
            this.ErrorEmailLabel.Visible = false;
            // 
            // OtherLabel
            // 
            this.OtherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherLabel.Location = new System.Drawing.Point(100, 457);
            this.OtherLabel.Name = "OtherLabel";
            this.OtherLabel.Size = new System.Drawing.Size(514, 40);
            this.OtherLabel.TabIndex = 9;
            this.OtherLabel.Text = "Logo Google, Facebook nếu làm chức năng được";
            this.OtherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.RegisterBtn.FlatAppearance.BorderSize = 2;
            this.RegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(110, 520);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(200, 40);
            this.RegisterBtn.TabIndex = 1;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(104, 400);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(510, 30);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PaswwordText_TextChanged);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PaswwordText_Leave);
            // 
            // PaswwordLabel
            // 
            this.PaswwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaswwordLabel.Location = new System.Drawing.Point(100, 360);
            this.PaswwordLabel.Name = "PaswwordLabel";
            this.PaswwordLabel.Size = new System.Drawing.Size(514, 40);
            this.PaswwordLabel.TabIndex = 5;
            this.PaswwordLabel.Text = "Password";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.EmailTextBox.Location = new System.Drawing.Point(104, 300);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(510, 30);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.Text = "Please enter your email.";
            this.EmailTextBox.WordWrap = false;
            this.EmailTextBox.Click += new System.EventHandler(this.EmailText_Click);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailText_Leave);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.LoginBtn.Enabled = false;
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.LoginBtn.FlatAppearance.BorderSize = 2;
            this.LoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(384, 520);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(200, 40);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(100, 260);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(514, 40);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email";
            // 
            // WelcomLabel
            // 
            this.WelcomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomLabel.Location = new System.Drawing.Point(100, 180);
            this.WelcomLabel.Name = "WelcomLabel";
            this.WelcomLabel.Size = new System.Drawing.Size(514, 40);
            this.WelcomLabel.TabIndex = 1;
            this.WelcomLabel.Text = "Welcome to LH Beverage, please login to your account.";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(100, 120);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(514, 40);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BannerPic.TabIndex = 0;
            this.BannerPic.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.LoginForm);
            this.Controls.Add(this.BannerPic);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.LoginForm.ResumeLayout(false);
            this.LoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BannerPic;
        private System.Windows.Forms.Panel LoginForm;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label WelcomLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PaswwordLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label OtherLabel;
        private System.Windows.Forms.Label ErrorEmailLabel;
        private System.Windows.Forms.Label ErrorPasswordLabel;
    }
}