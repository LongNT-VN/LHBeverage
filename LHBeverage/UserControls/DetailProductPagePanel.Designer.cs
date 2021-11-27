
namespace LHBeverage.UserControls
{
    partial class DetailProductPagePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailProductPagePanel));
            this.RelationItemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DetailItemPanel = new System.Windows.Forms.Panel();
            this.ListToppings = new System.Windows.Forms.FlowLayoutPanel();
            this.QuantityItem = new System.Windows.Forms.Label();
            this.QuantityUp = new System.Windows.Forms.Button();
            this.QuantityDown = new System.Windows.Forms.Button();
            this.ListImagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DescriptionItem = new System.Windows.Forms.TextBox();
            this.SizeLBtn = new System.Windows.Forms.Button();
            this.SizeMBtn = new System.Windows.Forms.Button();
            this.SizeSBtn = new System.Windows.Forms.Button();
            this.QuantityProduct = new System.Windows.Forms.Label();
            this.PriceItem = new System.Windows.Forms.Label();
            this.OrderItemBtn = new System.Windows.Forms.Button();
            this.ToppingLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.NameItem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TempPanel = new System.Windows.Forms.Panel();
            this.AddCartBtn = new System.Windows.Forms.PictureBox();
            this.ImgItem = new System.Windows.Forms.PictureBox();
            this.DetailItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddCartBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // RelationItemPanel
            // 
            resources.ApplyResources(this.RelationItemPanel, "RelationItemPanel");
            this.RelationItemPanel.BackColor = System.Drawing.SystemColors.Control;
            this.RelationItemPanel.Name = "RelationItemPanel";
            // 
            // DetailItemPanel
            // 
            resources.ApplyResources(this.DetailItemPanel, "DetailItemPanel");
            this.DetailItemPanel.BackColor = System.Drawing.Color.White;
            this.DetailItemPanel.Controls.Add(this.ListToppings);
            this.DetailItemPanel.Controls.Add(this.QuantityItem);
            this.DetailItemPanel.Controls.Add(this.QuantityUp);
            this.DetailItemPanel.Controls.Add(this.QuantityDown);
            this.DetailItemPanel.Controls.Add(this.ListImagePanel);
            this.DetailItemPanel.Controls.Add(this.DescriptionItem);
            this.DetailItemPanel.Controls.Add(this.AddCartBtn);
            this.DetailItemPanel.Controls.Add(this.ImgItem);
            this.DetailItemPanel.Controls.Add(this.SizeLBtn);
            this.DetailItemPanel.Controls.Add(this.SizeMBtn);
            this.DetailItemPanel.Controls.Add(this.SizeSBtn);
            this.DetailItemPanel.Controls.Add(this.QuantityProduct);
            this.DetailItemPanel.Controls.Add(this.PriceItem);
            this.DetailItemPanel.Controls.Add(this.OrderItemBtn);
            this.DetailItemPanel.Controls.Add(this.ToppingLabel);
            this.DetailItemPanel.Controls.Add(this.SizeLabel);
            this.DetailItemPanel.Controls.Add(this.pricelabel);
            this.DetailItemPanel.Controls.Add(this.NameItem);
            this.DetailItemPanel.Name = "DetailItemPanel";
            // 
            // ListToppings
            // 
            resources.ApplyResources(this.ListToppings, "ListToppings");
            this.ListToppings.Name = "ListToppings";
            // 
            // QuantityItem
            // 
            resources.ApplyResources(this.QuantityItem, "QuantityItem");
            this.QuantityItem.BackColor = System.Drawing.Color.Transparent;
            this.QuantityItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityItem.Name = "QuantityItem";
            this.QuantityItem.TextChanged += new System.EventHandler(this.QuantityItem_TextChanged);
            // 
            // QuantityUp
            // 
            resources.ApplyResources(this.QuantityUp, "QuantityUp");
            this.QuantityUp.BackColor = System.Drawing.SystemColors.Control;
            this.QuantityUp.FlatAppearance.BorderSize = 0;
            this.QuantityUp.Name = "QuantityUp";
            this.QuantityUp.UseVisualStyleBackColor = false;
            this.QuantityUp.Click += new System.EventHandler(this.QuantityUp_Click);
            // 
            // QuantityDown
            // 
            resources.ApplyResources(this.QuantityDown, "QuantityDown");
            this.QuantityDown.BackColor = System.Drawing.SystemColors.Control;
            this.QuantityDown.FlatAppearance.BorderSize = 0;
            this.QuantityDown.Name = "QuantityDown";
            this.QuantityDown.UseVisualStyleBackColor = false;
            this.QuantityDown.Click += new System.EventHandler(this.QuantityDown_Click);
            // 
            // ListImagePanel
            // 
            resources.ApplyResources(this.ListImagePanel, "ListImagePanel");
            this.ListImagePanel.BackColor = System.Drawing.Color.Transparent;
            this.ListImagePanel.Name = "ListImagePanel";
            // 
            // DescriptionItem
            // 
            resources.ApplyResources(this.DescriptionItem, "DescriptionItem");
            this.DescriptionItem.AllowDrop = true;
            this.DescriptionItem.BackColor = System.Drawing.Color.White;
            this.DescriptionItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionItem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DescriptionItem.Name = "DescriptionItem";
            this.DescriptionItem.ReadOnly = true;
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
            // SizeMBtn
            // 
            resources.ApplyResources(this.SizeMBtn, "SizeMBtn");
            this.SizeMBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SizeMBtn.FlatAppearance.BorderSize = 0;
            this.SizeMBtn.Name = "SizeMBtn";
            this.SizeMBtn.UseVisualStyleBackColor = false;
            this.SizeMBtn.Click += new System.EventHandler(this.SizeMBtn_Click);
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
            // QuantityProduct
            // 
            resources.ApplyResources(this.QuantityProduct, "QuantityProduct");
            this.QuantityProduct.BackColor = System.Drawing.Color.Transparent;
            this.QuantityProduct.ForeColor = System.Drawing.Color.LimeGreen;
            this.QuantityProduct.Name = "QuantityProduct";
            // 
            // PriceItem
            // 
            resources.ApplyResources(this.PriceItem, "PriceItem");
            this.PriceItem.BackColor = System.Drawing.Color.Transparent;
            this.PriceItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceItem.Name = "PriceItem";
            // 
            // OrderItemBtn
            // 
            resources.ApplyResources(this.OrderItemBtn, "OrderItemBtn");
            this.OrderItemBtn.BackColor = System.Drawing.Color.Tan;
            this.OrderItemBtn.ForeColor = System.Drawing.Color.White;
            this.OrderItemBtn.Name = "OrderItemBtn";
            this.OrderItemBtn.UseVisualStyleBackColor = false;
            this.OrderItemBtn.Click += new System.EventHandler(this.OrderItemBtn_Click);
            // 
            // ToppingLabel
            // 
            resources.ApplyResources(this.ToppingLabel, "ToppingLabel");
            this.ToppingLabel.BackColor = System.Drawing.Color.Transparent;
            this.ToppingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToppingLabel.Name = "ToppingLabel";
            // 
            // SizeLabel
            // 
            resources.ApplyResources(this.SizeLabel, "SizeLabel");
            this.SizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SizeLabel.Name = "SizeLabel";
            // 
            // pricelabel
            // 
            resources.ApplyResources(this.pricelabel, "pricelabel");
            this.pricelabel.BackColor = System.Drawing.Color.Transparent;
            this.pricelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pricelabel.Name = "pricelabel";
            // 
            // NameItem
            // 
            resources.ApplyResources(this.NameItem, "NameItem");
            this.NameItem.BackColor = System.Drawing.Color.Transparent;
            this.NameItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameItem.Name = "NameItem";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Name = "label1";
            // 
            // TempPanel
            // 
            resources.ApplyResources(this.TempPanel, "TempPanel");
            this.TempPanel.Name = "TempPanel";
            // 
            // AddCartBtn
            // 
            resources.ApplyResources(this.AddCartBtn, "AddCartBtn");
            this.AddCartBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddCartBtn.BackgroundImage = global::LHBeverage.Properties.Resources.Cart_normal1;
            this.AddCartBtn.Name = "AddCartBtn";
            this.AddCartBtn.TabStop = false;
            this.AddCartBtn.Click += new System.EventHandler(this.OrderItemBtn_Click);
            // 
            // ImgItem
            // 
            resources.ApplyResources(this.ImgItem, "ImgItem");
            this.ImgItem.BackgroundImage = global::LHBeverage.Properties.Resources.Banner;
            this.ImgItem.Name = "ImgItem";
            this.ImgItem.TabStop = false;
            // 
            // DetailProductPagePanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TempPanel);
            this.Controls.Add(this.DetailItemPanel);
            this.Controls.Add(this.RelationItemPanel);
            this.Name = "DetailProductPagePanel";
            this.DetailItemPanel.ResumeLayout(false);
            this.DetailItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddCartBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RelationItemPanel;
        private System.Windows.Forms.Panel DetailItemPanel;
        private System.Windows.Forms.Label NameItem;
        private System.Windows.Forms.Label ToppingLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Button OrderItemBtn;
        private System.Windows.Forms.Label PriceItem;
        private System.Windows.Forms.Button SizeLBtn;
        private System.Windows.Forms.Button SizeMBtn;
        private System.Windows.Forms.Button SizeSBtn;
        private System.Windows.Forms.PictureBox ImgItem;
        private System.Windows.Forms.PictureBox AddCartBtn;
        private System.Windows.Forms.TextBox DescriptionItem;
        private System.Windows.Forms.FlowLayoutPanel ListImagePanel;
        private System.Windows.Forms.Label QuantityItem;
        private System.Windows.Forms.Button QuantityUp;
        private System.Windows.Forms.Button QuantityDown;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.FlowLayoutPanel ListToppings;
        private System.Windows.Forms.Label QuantityProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TempPanel;
    }
}
