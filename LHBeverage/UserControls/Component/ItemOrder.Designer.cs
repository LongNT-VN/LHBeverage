
namespace LHBeverage.UserControls.Component
{
    partial class ItemOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemOrder));
            this.PriceItem = new System.Windows.Forms.Label();
            this.NameItem = new System.Windows.Forms.Label();
            this.ImageItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageItem)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceItem
            // 
            resources.ApplyResources(this.PriceItem, "PriceItem");
            this.PriceItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PriceItem.Name = "PriceItem";
            // 
            // NameItem
            // 
            resources.ApplyResources(this.NameItem, "NameItem");
            this.NameItem.ForeColor = System.Drawing.Color.DimGray;
            this.NameItem.Name = "NameItem";
            // 
            // ImageItem
            // 
            this.ImageItem.BackColor = System.Drawing.Color.White;
            this.ImageItem.BackgroundImage = global::LHBeverage.Properties.Resources.Banner;
            resources.ApplyResources(this.ImageItem, "ImageItem");
            this.ImageItem.Name = "ImageItem";
            this.ImageItem.TabStop = false;
            // 
            // ItemOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriceItem);
            this.Controls.Add(this.NameItem);
            this.Controls.Add(this.ImageItem);
            this.Name = "ItemOrder";
            ((System.ComponentModel.ISupportInitialize)(this.ImageItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PriceItem;
        private System.Windows.Forms.Label NameItem;
        private System.Windows.Forms.PictureBox ImageItem;
    }
}
