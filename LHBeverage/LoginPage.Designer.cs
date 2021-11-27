
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.LoginForm = new System.Windows.Forms.Panel();
            this.ErrorPasswordLabel = new System.Windows.Forms.Label();
            this.ErrorEmailLabel = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PaswwordLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.WelcomLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.BannerPic = new System.Windows.Forms.PictureBox();
            this.EnBtn = new System.Windows.Forms.Button();
            this.VIBtn = new System.Windows.Forms.Button();
            this.LoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginForm
            // 
            this.LoginForm.Controls.Add(this.VIBtn);
            this.LoginForm.Controls.Add(this.EnBtn);
            this.LoginForm.Controls.Add(this.ErrorPasswordLabel);
            this.LoginForm.Controls.Add(this.ErrorEmailLabel);
            this.LoginForm.Controls.Add(this.RegisterBtn);
            this.LoginForm.Controls.Add(this.PasswordTextBox);
            this.LoginForm.Controls.Add(this.PaswwordLabel);
            this.LoginForm.Controls.Add(this.EmailTextBox);
            this.LoginForm.Controls.Add(this.LoginBtn);
            this.LoginForm.Controls.Add(this.EmailLabel);
            this.LoginForm.Controls.Add(this.WelcomLabel);
            this.LoginForm.Controls.Add(this.LoginLabel);
            resources.ApplyResources(this.LoginForm, "LoginForm");
            this.LoginForm.Name = "LoginForm";
            // 
            // ErrorPasswordLabel
            // 
            resources.ApplyResources(this.ErrorPasswordLabel, "ErrorPasswordLabel");
            this.ErrorPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorPasswordLabel.Name = "ErrorPasswordLabel";
            // 
            // ErrorEmailLabel
            // 
            resources.ApplyResources(this.ErrorEmailLabel, "ErrorEmailLabel");
            this.ErrorEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorEmailLabel.Name = "ErrorEmailLabel";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.RegisterBtn.FlatAppearance.BorderSize = 2;
            this.RegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.RegisterBtn, "RegisterBtn");
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PasswordTextBox, "PasswordTextBox");
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PaswwordText_TextChanged);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PaswwordText_Leave);
            // 
            // PaswwordLabel
            // 
            resources.ApplyResources(this.PaswwordLabel, "PaswwordLabel");
            this.PaswwordLabel.Name = "PaswwordLabel";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.EmailTextBox, "EmailTextBox");
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Click += new System.EventHandler(this.EmailText_Click);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailText_Leave);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            resources.ApplyResources(this.LoginBtn, "LoginBtn");
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.LoginBtn.FlatAppearance.BorderSize = 2;
            this.LoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // EmailLabel
            // 
            resources.ApplyResources(this.EmailLabel, "EmailLabel");
            this.EmailLabel.Name = "EmailLabel";
            // 
            // WelcomLabel
            // 
            resources.ApplyResources(this.WelcomLabel, "WelcomLabel");
            this.WelcomLabel.Name = "WelcomLabel";
            // 
            // LoginLabel
            // 
            resources.ApplyResources(this.LoginLabel, "LoginLabel");
            this.LoginLabel.Name = "LoginLabel";
            // 
            // BannerPic
            // 
            this.BannerPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BannerPic.BackgroundImage = global::LHBeverage.Properties.Resources.Banner;
            resources.ApplyResources(this.BannerPic, "BannerPic");
            this.BannerPic.Name = "BannerPic";
            this.BannerPic.TabStop = false;
            // 
            // EnBtn
            // 
            this.EnBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.EnBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.EnBtn, "EnBtn");
            this.EnBtn.Name = "EnBtn";
            this.EnBtn.UseVisualStyleBackColor = false;
            this.EnBtn.Click += new System.EventHandler(this.EnBtn_Click);
            // 
            // VIBtn
            // 
            this.VIBtn.BackColor = System.Drawing.Color.White;
            this.VIBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.VIBtn, "VIBtn");
            this.VIBtn.Name = "VIBtn";
            this.VIBtn.UseVisualStyleBackColor = false;
            this.VIBtn.Click += new System.EventHandler(this.VIBtn_Click);
            // 
            // LoginPage
            // 
            this.AcceptButton = this.LoginBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoginForm);
            this.Controls.Add(this.BannerPic);
            this.Name = "LoginPage";
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
        private System.Windows.Forms.Label ErrorEmailLabel;
        private System.Windows.Forms.Label ErrorPasswordLabel;
        private System.Windows.Forms.Button VIBtn;
        private System.Windows.Forms.Button EnBtn;
    }
}