
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
            this.Viewmore_btn = new System.Windows.Forms.Button();
            this.ImgPro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPro)).BeginInit();
            this.SuspendLayout();
            // 
            // NamePro
            // 
            resources.ApplyResources(this.NamePro, "NamePro");
            this.NamePro.BackColor = System.Drawing.Color.Transparent;
            this.NamePro.Name = "NamePro";
            // 
            // Price
            // 
            resources.ApplyResources(this.Price, "Price");
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.ForeColor = System.Drawing.Color.Black;
            this.Price.Name = "Price";
            // 
            // Viewmore_btn
            // 
            resources.ApplyResources(this.Viewmore_btn, "Viewmore_btn");
            this.Viewmore_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.Viewmore_btn.FlatAppearance.BorderSize = 0;
            this.Viewmore_btn.ForeColor = System.Drawing.Color.White;
            this.Viewmore_btn.Name = "Viewmore_btn";
            this.Viewmore_btn.UseVisualStyleBackColor = false;
            this.Viewmore_btn.Click += new System.EventHandler(this.Viewmore_btn_Click);
            // 
            // ImgPro
            // 
            resources.ApplyResources(this.ImgPro, "ImgPro");
            this.ImgPro.Name = "ImgPro";
            this.ImgPro.TabStop = false;
            // 
            // PopularProduct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Viewmore_btn);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.NamePro);
            this.Controls.Add(this.ImgPro);
            this.Name = "PopularProduct";
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
