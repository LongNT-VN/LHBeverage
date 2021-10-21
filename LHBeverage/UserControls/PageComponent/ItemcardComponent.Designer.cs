
namespace LHBeverage.UserControls.LHComponent
{
    partial class ItemcardComponent
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
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ImageProductBeverage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProductBeverage)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPriceLabel.ForeColor = System.Drawing.Color.Green;
            this.ProductPriceLabel.Location = new System.Drawing.Point(0, 218);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ProductPriceLabel.Size = new System.Drawing.Size(200, 40);
            this.ProductPriceLabel.TabIndex = 5;
            this.ProductPriceLabel.Text = "Product Price";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Enabled = false;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(0, 178);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ProductNameLabel.Size = new System.Drawing.Size(200, 40);
            this.ProductNameLabel.TabIndex = 4;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ImageProductBeverage
            // 
            this.ImageProductBeverage.BackColor = System.Drawing.Color.White;
            this.ImageProductBeverage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageProductBeverage.Enabled = false;
            this.ImageProductBeverage.Location = new System.Drawing.Point(15, 3);
            this.ImageProductBeverage.Name = "ImageProductBeverage";
            this.ImageProductBeverage.Size = new System.Drawing.Size(170, 170);
            this.ImageProductBeverage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageProductBeverage.TabIndex = 3;
            this.ImageProductBeverage.TabStop = false;
            // 
            // ItemcardComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ImageProductBeverage);
            this.Name = "ItemcardComponent";
            this.Size = new System.Drawing.Size(200, 260);
            ((System.ComponentModel.ISupportInitialize)(this.ImageProductBeverage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.PictureBox ImageProductBeverage;
    }
}
