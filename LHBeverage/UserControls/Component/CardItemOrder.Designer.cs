
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
            this.ImageProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageProduct.Location = new System.Drawing.Point(5, 1);
            this.ImageProduct.Name = "ImageProduct";
            this.ImageProduct.Size = new System.Drawing.Size(140, 146);
            this.ImageProduct.TabIndex = 0;
            this.ImageProduct.TabStop = false;
            // 
            // amountitemOrder
            // 
            this.amountitemOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountitemOrder.ForeColor = System.Drawing.Color.DimGray;
            this.amountitemOrder.Location = new System.Drawing.Point(228, 90);
            this.amountitemOrder.Name = "amountitemOrder";
            this.amountitemOrder.Size = new System.Drawing.Size(37, 30);
            this.amountitemOrder.TabIndex = 8;
            this.amountitemOrder.Text = "0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(155, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantity";
            // 
            // Price_lbl
            // 
            this.Price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_lbl.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Price_lbl.Location = new System.Drawing.Point(151, 117);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(283, 30);
            this.Price_lbl.TabIndex = 6;
            this.Price_lbl.Text = "TotalPrice";
            // 
            // nameitem_lbl
            // 
            this.nameitem_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameitem_lbl.ForeColor = System.Drawing.Color.Black;
            this.nameitem_lbl.Location = new System.Drawing.Point(154, 10);
            this.nameitem_lbl.Name = "nameitem_lbl";
            this.nameitem_lbl.Size = new System.Drawing.Size(280, 40);
            this.nameitem_lbl.TabIndex = 5;
            this.nameitem_lbl.Text = "Name Item";
            // 
            // sizeitem
            // 
            this.sizeitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeitem.ForeColor = System.Drawing.Color.DimGray;
            this.sizeitem.Location = new System.Drawing.Point(228, 55);
            this.sizeitem.Name = "sizeitem";
            this.sizeitem.Size = new System.Drawing.Size(37, 30);
            this.sizeitem.TabIndex = 10;
            this.sizeitem.Text = "Size";
            // 
            // Topping_lbl
            // 
            this.Topping_lbl.AllowDrop = true;
            this.Topping_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Topping_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.Topping_lbl.Location = new System.Drawing.Point(305, 55);
            this.Topping_lbl.Name = "Topping_lbl";
            this.Topping_lbl.Size = new System.Drawing.Size(129, 65);
            this.Topping_lbl.TabIndex = 7;
            this.Topping_lbl.Text = "Topping";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(155, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Size";
            // 
            // CardItemOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Size = new System.Drawing.Size(438, 150);
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
