
namespace LHBeverage.UserControls.Component
{
    partial class Couponitem
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
            this.ImageCoupon = new System.Windows.Forms.PictureBox();
            this.CouponCode = new System.Windows.Forms.Label();
            this.Discriptionlabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.UseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCoupon)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageCoupon
            // 
            this.ImageCoupon.Location = new System.Drawing.Point(5, 5);
            this.ImageCoupon.Name = "ImageCoupon";
            this.ImageCoupon.Size = new System.Drawing.Size(80, 90);
            this.ImageCoupon.TabIndex = 0;
            this.ImageCoupon.TabStop = false;
            // 
            // CouponCode
            // 
            this.CouponCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CouponCode.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CouponCode.Location = new System.Drawing.Point(91, 10);
            this.CouponCode.Name = "CouponCode";
            this.CouponCode.Size = new System.Drawing.Size(166, 40);
            this.CouponCode.TabIndex = 4;
            this.CouponCode.Text = "LHBEVERAGE";
            this.CouponCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Discriptionlabel
            // 
            this.Discriptionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discriptionlabel.ForeColor = System.Drawing.Color.DimGray;
            this.Discriptionlabel.Location = new System.Drawing.Point(92, 50);
            this.Discriptionlabel.Name = "Discriptionlabel";
            this.Discriptionlabel.Size = new System.Drawing.Size(235, 40);
            this.Discriptionlabel.TabIndex = 4;
            this.Discriptionlabel.Text = "Mã giảm giá đến ngày 11/11";
            this.Discriptionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.DiscountLabel.Location = new System.Drawing.Point(263, 10);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(165, 40);
            this.DiscountLabel.TabIndex = 4;
            this.DiscountLabel.Text = "Giảm ngay 30%";
            this.DiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UseBtn
            // 
            this.UseBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.UseBtn.FlatAppearance.BorderSize = 0;
            this.UseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseBtn.Location = new System.Drawing.Point(344, 59);
            this.UseBtn.Name = "UseBtn";
            this.UseBtn.Size = new System.Drawing.Size(75, 23);
            this.UseBtn.TabIndex = 5;
            this.UseBtn.Text = "Use";
            this.UseBtn.UseVisualStyleBackColor = false;
            this.UseBtn.Click += new System.EventHandler(this.UseBtn_Click);
            // 
            // Couponitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.UseBtn);
            this.Controls.Add(this.Discriptionlabel);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.CouponCode);
            this.Controls.Add(this.ImageCoupon);
            this.Name = "Couponitem";
            this.Size = new System.Drawing.Size(430, 100);
            ((System.ComponentModel.ISupportInitialize)(this.ImageCoupon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageCoupon;
        private System.Windows.Forms.Label CouponCode;
        private System.Windows.Forms.Label Discriptionlabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Button UseBtn;
    }
}
