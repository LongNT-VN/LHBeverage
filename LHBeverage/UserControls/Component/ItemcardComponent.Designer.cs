
namespace LHBeverage.UserControls.Component
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemcardComponent));
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ImageProductBeverage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProductBeverage)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPriceLabel
            // 
            resources.ApplyResources(this.ProductPriceLabel, "ProductPriceLabel");
            this.ProductPriceLabel.ForeColor = System.Drawing.Color.Green;
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            // 
            // ProductNameLabel
            // 
            resources.ApplyResources(this.ProductNameLabel, "ProductNameLabel");
            this.ProductNameLabel.Name = "ProductNameLabel";
            // 
            // ImageProductBeverage
            // 
            resources.ApplyResources(this.ImageProductBeverage, "ImageProductBeverage");
            this.ImageProductBeverage.BackColor = System.Drawing.Color.Transparent;
            this.ImageProductBeverage.Name = "ImageProductBeverage";
            this.ImageProductBeverage.TabStop = false;
            // 
            // ItemcardComponent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ImageProductBeverage);
            this.Name = "ItemcardComponent";
            ((System.ComponentModel.ISupportInitialize)(this.ImageProductBeverage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.PictureBox ImageProductBeverage;
    }
}
