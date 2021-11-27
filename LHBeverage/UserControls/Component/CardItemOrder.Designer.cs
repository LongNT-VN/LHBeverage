
namespace LHBeverage.UserControls.Component
{
    partial class CardItemOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardItemOrder));
            this.ImageProduct = new System.Windows.Forms.PictureBox();
            this.amountitemOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.nameitem_lbl = new System.Windows.Forms.Label();
            this.sizeitem = new System.Windows.Forms.Label();
            this.Topping_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageProduct
            // 
            resources.ApplyResources(this.ImageProduct, "ImageProduct");
            this.ImageProduct.Name = "ImageProduct";
            this.ImageProduct.TabStop = false;
            // 
            // amountitemOrder
            // 
            resources.ApplyResources(this.amountitemOrder, "amountitemOrder");
            this.amountitemOrder.ForeColor = System.Drawing.Color.DimGray;
            this.amountitemOrder.Name = "amountitemOrder";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Name = "label1";
            // 
            // Price_lbl
            // 
            resources.ApplyResources(this.Price_lbl, "Price_lbl");
            this.Price_lbl.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Price_lbl.Name = "Price_lbl";
            // 
            // nameitem_lbl
            // 
            resources.ApplyResources(this.nameitem_lbl, "nameitem_lbl");
            this.nameitem_lbl.ForeColor = System.Drawing.Color.Black;
            this.nameitem_lbl.Name = "nameitem_lbl";
            // 
            // sizeitem
            // 
            resources.ApplyResources(this.sizeitem, "sizeitem");
            this.sizeitem.ForeColor = System.Drawing.Color.DimGray;
            this.sizeitem.Name = "sizeitem";
            // 
            // Topping_lbl
            // 
            resources.ApplyResources(this.Topping_lbl, "Topping_lbl");
            this.Topping_lbl.AllowDrop = true;
            this.Topping_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.Topping_lbl.Name = "Topping_lbl";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Name = "label2";
            // 
            // CardItemOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeitem);
            this.Controls.Add(this.amountitemOrder);
            this.Controls.Add(this.Topping_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.nameitem_lbl);
            this.Controls.Add(this.ImageProduct);
            this.Name = "CardItemOrder";
            ((System.ComponentModel.ISupportInitialize)(this.ImageProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageProduct;
        private System.Windows.Forms.Label amountitemOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Label nameitem_lbl;
        private System.Windows.Forms.Label sizeitem;
        private System.Windows.Forms.Label Topping_lbl;
        private System.Windows.Forms.Label label2;
    }
}
