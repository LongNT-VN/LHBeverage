
namespace LHBeverage.UserControls
{
    partial class CartPagePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProceedBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PaymentMethodPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ShippingPriceLabel = new System.Windows.Forms.Label();
            this.ShippingLabel = new System.Windows.Forms.Label();
            this.seperate1 = new System.Windows.Forms.Label();
            this.SubtotalPriceLabel = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.TotalPricePanel = new System.Windows.Forms.Panel();
            this.ItemsCart = new System.Windows.Forms.FlowLayoutPanel();
            this.Method4Pic = new System.Windows.Forms.PictureBox();
            this.Method3Pic = new System.Windows.Forms.PictureBox();
            this.Method2Pic = new System.Windows.Forms.PictureBox();
            this.Method1Pic = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.PaymentMethodPanel.SuspendLayout();
            this.TotalPricePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Method4Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Method3Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Method2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Method1Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // ProceedBtn
            // 
            this.ProceedBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.ProceedBtn.FlatAppearance.BorderSize = 0;
            this.ProceedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProceedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedBtn.ForeColor = System.Drawing.Color.Black;
            this.ProceedBtn.Location = new System.Drawing.Point(50, 10);
            this.ProceedBtn.Name = "ProceedBtn";
            this.ProceedBtn.Size = new System.Drawing.Size(200, 60);
            this.ProceedBtn.TabIndex = 1;
            this.ProceedBtn.Text = "Proceed";
            this.ProceedBtn.UseVisualStyleBackColor = false;
            this.ProceedBtn.Click += new System.EventHandler(this.ProceedBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ProceedBtn);
            this.panel2.Location = new System.Drawing.Point(850, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 80);
            this.panel2.TabIndex = 10;
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLabel.ForeColor = System.Drawing.Color.DimGray;
            this.PaymentMethodLabel.Location = new System.Drawing.Point(10, 10);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(168, 30);
            this.PaymentMethodLabel.TabIndex = 3;
            this.PaymentMethodLabel.Text = "Payment method:";
            this.PaymentMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TotalPriceLabel.Location = new System.Drawing.Point(110, 145);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(174, 40);
            this.TotalPriceLabel.TabIndex = 5;
            this.TotalPriceLabel.Text = "1.030.000 VNĐ";
            this.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.Color.DimGray;
            this.TotalLabel.Location = new System.Drawing.Point(10, 145);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(100, 40);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "Total:";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaymentMethodPanel
            // 
            this.PaymentMethodPanel.BackColor = System.Drawing.Color.White;
            this.PaymentMethodPanel.Controls.Add(this.Method4Pic);
            this.PaymentMethodPanel.Controls.Add(this.Method3Pic);
            this.PaymentMethodPanel.Controls.Add(this.Method2Pic);
            this.PaymentMethodPanel.Controls.Add(this.Method1Pic);
            this.PaymentMethodPanel.Controls.Add(this.PaymentMethodLabel);
            this.PaymentMethodPanel.Location = new System.Drawing.Point(850, 320);
            this.PaymentMethodPanel.Name = "PaymentMethodPanel";
            this.PaymentMethodPanel.Size = new System.Drawing.Size(304, 85);
            this.PaymentMethodPanel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(30, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 1);
            this.label2.TabIndex = 4;
            // 
            // ShippingPriceLabel
            // 
            this.ShippingPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingPriceLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ShippingPriceLabel.Location = new System.Drawing.Point(110, 80);
            this.ShippingPriceLabel.Name = "ShippingPriceLabel";
            this.ShippingPriceLabel.Size = new System.Drawing.Size(174, 40);
            this.ShippingPriceLabel.TabIndex = 2;
            this.ShippingPriceLabel.Text = "30.000 VNĐ";
            this.ShippingPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShippingLabel
            // 
            this.ShippingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ShippingLabel.Location = new System.Drawing.Point(10, 80);
            this.ShippingLabel.Name = "ShippingLabel";
            this.ShippingLabel.Size = new System.Drawing.Size(100, 40);
            this.ShippingLabel.TabIndex = 3;
            this.ShippingLabel.Text = "Shipping:";
            this.ShippingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // seperate1
            // 
            this.seperate1.BackColor = System.Drawing.Color.DarkGray;
            this.seperate1.Location = new System.Drawing.Point(30, 65);
            this.seperate1.Name = "seperate1";
            this.seperate1.Size = new System.Drawing.Size(240, 1);
            this.seperate1.TabIndex = 1;
            // 
            // SubtotalPriceLabel
            // 
            this.SubtotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalPriceLabel.ForeColor = System.Drawing.Color.DimGray;
            this.SubtotalPriceLabel.Location = new System.Drawing.Point(110, 20);
            this.SubtotalPriceLabel.Name = "SubtotalPriceLabel";
            this.SubtotalPriceLabel.Size = new System.Drawing.Size(174, 40);
            this.SubtotalPriceLabel.TabIndex = 0;
            this.SubtotalPriceLabel.Text = "1.000.000 VNĐ";
            this.SubtotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLabel.ForeColor = System.Drawing.Color.DimGray;
            this.SubtotalLabel.Location = new System.Drawing.Point(10, 20);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(100, 40);
            this.SubtotalLabel.TabIndex = 0;
            this.SubtotalLabel.Text = "Subtotal:";
            this.SubtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalPricePanel
            // 
            this.TotalPricePanel.BackColor = System.Drawing.Color.White;
            this.TotalPricePanel.Controls.Add(this.TotalPriceLabel);
            this.TotalPricePanel.Controls.Add(this.TotalLabel);
            this.TotalPricePanel.Controls.Add(this.label2);
            this.TotalPricePanel.Controls.Add(this.ShippingPriceLabel);
            this.TotalPricePanel.Controls.Add(this.ShippingLabel);
            this.TotalPricePanel.Controls.Add(this.seperate1);
            this.TotalPricePanel.Controls.Add(this.SubtotalPriceLabel);
            this.TotalPricePanel.Controls.Add(this.SubtotalLabel);
            this.TotalPricePanel.Location = new System.Drawing.Point(850, 100);
            this.TotalPricePanel.Name = "TotalPricePanel";
            this.TotalPricePanel.Size = new System.Drawing.Size(304, 205);
            this.TotalPricePanel.TabIndex = 9;
            // 
            // ItemsCart
            // 
            this.ItemsCart.AutoScroll = true;
            this.ItemsCart.Location = new System.Drawing.Point(30, 100);
            this.ItemsCart.Name = "ItemsCart";
            this.ItemsCart.Size = new System.Drawing.Size(800, 400);
            this.ItemsCart.TabIndex = 7;
            // 
            // Method4Pic
            // 
            this.Method4Pic.BackColor = System.Drawing.Color.OrangeRed;
            this.Method4Pic.Location = new System.Drawing.Point(210, 45);
            this.Method4Pic.Name = "Method4Pic";
            this.Method4Pic.Size = new System.Drawing.Size(50, 30);
            this.Method4Pic.TabIndex = 5;
            this.Method4Pic.TabStop = false;
            // 
            // Method3Pic
            // 
            this.Method3Pic.BackColor = System.Drawing.Color.OrangeRed;
            this.Method3Pic.Location = new System.Drawing.Point(145, 45);
            this.Method3Pic.Name = "Method3Pic";
            this.Method3Pic.Size = new System.Drawing.Size(50, 30);
            this.Method3Pic.TabIndex = 5;
            this.Method3Pic.TabStop = false;
            // 
            // Method2Pic
            // 
            this.Method2Pic.BackColor = System.Drawing.Color.OrangeRed;
            this.Method2Pic.Location = new System.Drawing.Point(80, 45);
            this.Method2Pic.Name = "Method2Pic";
            this.Method2Pic.Size = new System.Drawing.Size(50, 30);
            this.Method2Pic.TabIndex = 5;
            this.Method2Pic.TabStop = false;
            // 
            // Method1Pic
            // 
            this.Method1Pic.BackColor = System.Drawing.Color.OrangeRed;
            this.Method1Pic.Location = new System.Drawing.Point(15, 45);
            this.Method1Pic.Name = "Method1Pic";
            this.Method1Pic.Size = new System.Drawing.Size(50, 30);
            this.Method1Pic.TabIndex = 4;
            this.Method1Pic.TabStop = false;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(24, 26);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 40);
            this.Title.TabIndex = 11;
            this.Title.Text = "Giỏ hàng";
            // 
            // CartPagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PaymentMethodPanel);
            this.Controls.Add(this.TotalPricePanel);
            this.Controls.Add(this.ItemsCart);
            this.Name = "CartPagePanel";
            this.Size = new System.Drawing.Size(1184, 600);
            this.panel2.ResumeLayout(false);
            this.PaymentMethodPanel.ResumeLayout(false);
            this.TotalPricePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Method4Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Method3Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Method2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Method1Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProceedBtn;
        private System.Windows.Forms.PictureBox Method4Pic;
        private System.Windows.Forms.PictureBox Method3Pic;
        private System.Windows.Forms.PictureBox Method2Pic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PaymentMethodLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Panel PaymentMethodPanel;
        private System.Windows.Forms.PictureBox Method1Pic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ShippingPriceLabel;
        private System.Windows.Forms.Label ShippingLabel;
        private System.Windows.Forms.Label seperate1;
        private System.Windows.Forms.Label SubtotalPriceLabel;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.Panel TotalPricePanel;
        private System.Windows.Forms.FlowLayoutPanel ItemsCart;
        private System.Windows.Forms.Label Title;
    }
}
