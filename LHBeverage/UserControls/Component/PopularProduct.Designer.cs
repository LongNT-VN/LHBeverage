
namespace LHBeverage.UserControls.Component
{
    partial class PopularProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopularProduct));
            this.NamePro = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.ImgPro = new System.Windows.Forms.PictureBox();
            this.Viewmore_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPro)).BeginInit();
            this.SuspendLayout();
            // 
            // NamePro
            // 
            this.NamePro.BackColor = System.Drawing.Color.Transparent;
            this.NamePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePro.Location = new System.Drawing.Point(-3, 194);
            this.NamePro.Name = "NamePro";
            this.NamePro.Size = new System.Drawing.Size(206, 56);
            this.NamePro.TabIndex = 1;
            this.NamePro.Text = "name Product";
            this.NamePro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.Black;
            this.Price.Location = new System.Drawing.Point(41, 161);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(134, 33);
            this.Price.TabIndex = 2;
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImgPro
            // 
            this.ImgPro.Image = ((System.Drawing.Image)(resources.GetObject("ImgPro.Image")));
            this.ImgPro.Location = new System.Drawing.Point(7, 0);
            this.ImgPro.Name = "ImgPro";
            this.ImgPro.Size = new System.Drawing.Size(196, 178);
            this.ImgPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPro.TabIndex = 0;
            this.ImgPro.TabStop = false;
            // 
            // Viewmore_btn
            // 
            this.Viewmore_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.Viewmore_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Viewmore_btn.FlatAppearance.BorderSize = 0;
            this.Viewmore_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Viewmore_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewmore_btn.ForeColor = System.Drawing.Color.White;
            this.Viewmore_btn.Location = new System.Drawing.Point(0, 269);
            this.Viewmore_btn.Name = "Viewmore_btn";
            this.Viewmore_btn.Size = new System.Drawing.Size(206, 33);
            this.Viewmore_btn.TabIndex = 3;
            this.Viewmore_btn.Text = "View more";
            this.Viewmore_btn.UseVisualStyleBackColor = false;
            this.Viewmore_btn.Click += new System.EventHandler(this.Viewmore_btn_Click);
            // 
            // PopularProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Viewmore_btn);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.NamePro);
            this.Controls.Add(this.ImgPro);
            this.Name = "PopularProduct";
            this.Size = new System.Drawing.Size(209, 306);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgPro;
        private System.Windows.Forms.Label NamePro;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button Viewmore_btn;
    }
}
