
namespace LHBeverage.UserControls.Component
{
    partial class ItemCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCart));
            this.NameItem = new System.Windows.Forms.Label();
            this.PriceItem = new System.Windows.Forms.Label();
            this.SizeSBtn = new System.Windows.Forms.Button();
            this.SizeMBtn = new System.Windows.Forms.Button();
            this.SizeLBtn = new System.Windows.Forms.Button();
            this.QuantityItem = new System.Windows.Forms.Label();
            this.QuantityDown = new System.Windows.Forms.Button();
            this.QuantityUp = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.Topping = new System.Windows.Forms.FlowLayoutPanel();
            this.ImageItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageItem)).BeginInit();
            this.SuspendLayout();
            // 
            // NameItem
            // 
            resources.ApplyResources(this.NameItem, "NameItem");
            this.NameItem.BackColor = System.Drawing.Color.Transparent;
            this.NameItem.ForeColor = System.Drawing.Color.DimGray;
            this.NameItem.Name = "NameItem";
            // 
            // PriceItem
            // 
            resources.ApplyResources(this.PriceItem, "PriceItem");
            this.PriceItem.BackColor = System.Drawing.Color.Transparent;
            this.PriceItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PriceItem.Name = "PriceItem";
            // 
            // SizeSBtn
            // 
            resources.ApplyResources(this.SizeSBtn, "SizeSBtn");
            this.SizeSBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.SizeSBtn.FlatAppearance.BorderSize = 0;
            this.SizeSBtn.Name = "SizeSBtn";
            this.SizeSBtn.UseVisualStyleBackColor = false;
            this.SizeSBtn.Click += new System.EventHandler(this.SizeSBtn_Click);
            // 
            // SizeMBtn
            // 
            resources.ApplyResources(this.SizeMBtn, "SizeMBtn");
            this.SizeMBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SizeMBtn.FlatAppearance.BorderSize = 0;
            this.SizeMBtn.Name = "SizeMBtn";
            this.SizeMBtn.UseVisualStyleBackColor = false;
            this.SizeMBtn.Click += new System.EventHandler(this.SizeMBtn_Click);
            // 
            // SizeLBtn
            // 
            resources.ApplyResources(this.SizeLBtn, "SizeLBtn");
            this.SizeLBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SizeLBtn.FlatAppearance.BorderSize = 0;
            this.SizeLBtn.Name = "SizeLBtn";
            this.SizeLBtn.UseVisualStyleBackColor = false;
            this.SizeLBtn.Click += new System.EventHandler(this.SizeLBtn_Click);
            // 
            // QuantityItem
            // 
            resources.ApplyResources(this.QuantityItem, "QuantityItem");
            this.QuantityItem.BackColor = System.Drawing.Color.Transparent;
            this.QuantityItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityItem.Name = "QuantityItem";
            this.QuantityItem.TextChanged += new System.EventHandler(this.QuantityItem_TextChanged);
            // 
            // QuantityDown
            // 
            resources.ApplyResources(this.QuantityDown, "QuantityDown");
            this.QuantityDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QuantityDown.FlatAppearance.BorderSize = 0;
            this.QuantityDown.Name = "QuantityDown";
            this.QuantityDown.UseVisualStyleBackColor = false;
            this.QuantityDown.Click += new System.EventHandler(this.QuantityDown_Click);
            // 
            // QuantityUp
            // 
            resources.ApplyResources(this.QuantityUp, "QuantityUp");
            this.QuantityUp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QuantityUp.FlatAppearance.BorderSize = 0;
            this.QuantityUp.Name = "QuantityUp";
            this.QuantityUp.UseVisualStyleBackColor = false;
            this.QuantityUp.Click += new System.EventHandler(this.QuantityUp_Click);
            // 
            // RemoveBtn
            // 
            resources.ApplyResources(this.RemoveBtn, "RemoveBtn");
            this.RemoveBtn.BackColor = System.Drawing.Color.Red;
            this.RemoveBtn.FlatAppearance.BorderSize = 0;
            this.RemoveBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // Topping
            // 
            resources.ApplyResources(this.Topping, "Topping");
            this.Topping.BackColor = System.Drawing.Color.Transparent;
            this.Topping.Name = "Topping";
            // 
            // ImageItem
            // 
            resources.ApplyResources(this.ImageItem, "ImageItem");
            this.ImageItem.BackColor = System.Drawing.Color.White;
            this.ImageItem.BackgroundImage = global::LHBeverage.Properties.Resources.Banner;
            this.ImageItem.Name = "ImageItem";
            this.ImageItem.TabStop = false;
            // 
            // ItemCart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Topping);
            this.Controls.Add(this.QuantityItem);
            this.Controls.Add(this.SizeLBtn);
            this.Controls.Add(this.SizeMBtn);
            this.Controls.Add(this.QuantityUp);
            this.Controls.Add(this.QuantityDown);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.SizeSBtn);
            this.Controls.Add(this.PriceItem);
            this.Controls.Add(this.NameItem);
            this.Controls.Add(this.ImageItem);
            this.Name = "ItemCart";
            ((System.ComponentModel.ISupportInitialize)(this.ImageItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageItem;
        private System.Windows.Forms.Label NameItem;
        private System.Windows.Forms.Label PriceItem;
        private System.Windows.Forms.Button SizeSBtn;
        private System.Windows.Forms.Button SizeMBtn;
        private System.Windows.Forms.Button SizeLBtn;
        private System.Windows.Forms.Label QuantityItem;
        private System.Windows.Forms.Button QuantityDown;
        private System.Windows.Forms.Button QuantityUp;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.FlowLayoutPanel Topping;
    }
}
