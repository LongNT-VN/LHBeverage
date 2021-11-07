
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
            this.RelationItemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DetailItemPanel = new System.Windows.Forms.Panel();
            this.ListToppings = new System.Windows.Forms.FlowLayoutPanel();
            this.QuantityItem = new System.Windows.Forms.Label();
            this.QuantityUp = new System.Windows.Forms.Button();
            this.QuantityDown = new System.Windows.Forms.Button();
            this.ListImagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DescriptionItem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddCartBtn = new System.Windows.Forms.PictureBox();
            this.ImgItem = new System.Windows.Forms.PictureBox();
            this.SizeLBtn = new System.Windows.Forms.Button();
            this.SizeMBtn = new System.Windows.Forms.Button();
            this.SizeSBtn = new System.Windows.Forms.Button();
            this.PriceItem = new System.Windows.Forms.Label();
            this.OrderItemBtn = new System.Windows.Forms.Button();
            this.ToppingLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.NameItem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DetailItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCartBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // RelationItemPanel
            // 
            this.RelationItemPanel.BackColor = System.Drawing.Color.White;
            this.RelationItemPanel.Location = new System.Drawing.Point(60, 550);
            this.RelationItemPanel.Name = "RelationItemPanel";
            this.RelationItemPanel.Size = new System.Drawing.Size(1050, 300);
            this.RelationItemPanel.TabIndex = 0;
            // 
            // DetailItemPanel
            // 
            this.DetailItemPanel.BackColor = System.Drawing.Color.White;
            this.DetailItemPanel.Controls.Add(this.ListToppings);
            this.DetailItemPanel.Controls.Add(this.QuantityItem);
            this.DetailItemPanel.Controls.Add(this.QuantityUp);
            this.DetailItemPanel.Controls.Add(this.QuantityDown);
            this.DetailItemPanel.Controls.Add(this.ListImagePanel);
            this.DetailItemPanel.Controls.Add(this.DescriptionItem);
            this.DetailItemPanel.Controls.Add(this.pictureBox1);
            this.DetailItemPanel.Controls.Add(this.AddCartBtn);
            this.DetailItemPanel.Controls.Add(this.ImgItem);
            this.DetailItemPanel.Controls.Add(this.SizeLBtn);
            this.DetailItemPanel.Controls.Add(this.SizeMBtn);
            this.DetailItemPanel.Controls.Add(this.SizeSBtn);
            this.DetailItemPanel.Controls.Add(this.PriceItem);
            this.DetailItemPanel.Controls.Add(this.OrderItemBtn);
            this.DetailItemPanel.Controls.Add(this.ToppingLabel);
            this.DetailItemPanel.Controls.Add(this.SizeLabel);
            this.DetailItemPanel.Controls.Add(this.pricelabel);
            this.DetailItemPanel.Controls.Add(this.NameItem);
            this.DetailItemPanel.Location = new System.Drawing.Point(60, 20);
            this.DetailItemPanel.Name = "DetailItemPanel";
            this.DetailItemPanel.Size = new System.Drawing.Size(1050, 490);
            this.DetailItemPanel.TabIndex = 1;
            // 
            // ListToppings
            // 
            this.ListToppings.Location = new System.Drawing.Point(372, 270);
            this.ListToppings.Name = "ListToppings";
            this.ListToppings.Size = new System.Drawing.Size(308, 87);
            this.ListToppings.TabIndex = 14;
            // 
            // QuantityItem
            // 
            this.QuantityItem.BackColor = System.Drawing.Color.White;
            this.QuantityItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityItem.Location = new System.Drawing.Point(417, 186);
            this.QuantityItem.Name = "QuantityItem";
            this.QuantityItem.Size = new System.Drawing.Size(40, 30);
            this.QuantityItem.TabIndex = 13;
            this.QuantityItem.Text = "1";
            this.QuantityItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuantityItem.TextChanged += new System.EventHandler(this.QuantityItem_TextChanged);
            // 
            // QuantityUp
            // 
            this.QuantityUp.BackColor = System.Drawing.SystemColors.Control;
            this.QuantityUp.FlatAppearance.BorderSize = 0;
            this.QuantityUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityUp.Location = new System.Drawing.Point(472, 187);
            this.QuantityUp.Name = "QuantityUp";
            this.QuantityUp.Size = new System.Drawing.Size(30, 30);
            this.QuantityUp.TabIndex = 11;
            this.QuantityUp.Text = "+";
            this.QuantityUp.UseVisualStyleBackColor = false;
            this.QuantityUp.Click += new System.EventHandler(this.QuantityUp_Click);
            // 
            // QuantityDown
            // 
            this.QuantityDown.BackColor = System.Drawing.SystemColors.Control;
            this.QuantityDown.FlatAppearance.BorderSize = 0;
            this.QuantityDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityDown.Location = new System.Drawing.Point(372, 186);
            this.QuantityDown.Name = "QuantityDown";
            this.QuantityDown.Size = new System.Drawing.Size(30, 30);
            this.QuantityDown.TabIndex = 12;
            this.QuantityDown.Text = "-";
            this.QuantityDown.UseVisualStyleBackColor = false;
            this.QuantityDown.Click += new System.EventHandler(this.QuantityDown_Click);
            // 
            // ListImagePanel
            // 
            this.ListImagePanel.AutoScroll = true;
            this.ListImagePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ListImagePanel.Location = new System.Drawing.Point(700, 375);
            this.ListImagePanel.Name = "ListImagePanel";
            this.ListImagePanel.Size = new System.Drawing.Size(300, 80);
            this.ListImagePanel.TabIndex = 10;
            // 
            // DescriptionItem
            // 
            this.DescriptionItem.AllowDrop = true;
            this.DescriptionItem.BackColor = System.Drawing.Color.White;
            this.DescriptionItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionItem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DescriptionItem.Enabled = false;
            this.DescriptionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionItem.Location = new System.Drawing.Point(57, 110);
            this.DescriptionItem.Multiline = true;
            this.DescriptionItem.Name = "DescriptionItem";
            this.DescriptionItem.ReadOnly = true;
            this.DescriptionItem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DescriptionItem.Size = new System.Drawing.Size(623, 60);
            this.DescriptionItem.TabIndex = 9;
            this.DescriptionItem.Text = "Công thức siêu cấp từ bà ngoại.\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LHBeverage.Properties.Resources.favourite;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(310, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AddCartBtn
            // 
            this.AddCartBtn.BackgroundImage = global::LHBeverage.Properties.Resources.Cart_normal1;
            this.AddCartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddCartBtn.Location = new System.Drawing.Point(370, 385);
            this.AddCartBtn.Name = "AddCartBtn";
            this.AddCartBtn.Size = new System.Drawing.Size(32, 32);
            this.AddCartBtn.TabIndex = 8;
            this.AddCartBtn.TabStop = false;
            // 
            // ImgItem
            // 
            this.ImgItem.BackgroundImage = global::LHBeverage.Properties.Resources.Banner;
            this.ImgItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgItem.ErrorImage = null;
            this.ImgItem.Location = new System.Drawing.Point(700, 60);
            this.ImgItem.Name = "ImgItem";
            this.ImgItem.Size = new System.Drawing.Size(300, 300);
            this.ImgItem.TabIndex = 7;
            this.ImgItem.TabStop = false;
            // 
            // SizeLBtn
            // 
            this.SizeLBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SizeLBtn.FlatAppearance.BorderSize = 0;
            this.SizeLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SizeLBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLBtn.Location = new System.Drawing.Point(174, 270);
            this.SizeLBtn.Name = "SizeLBtn";
            this.SizeLBtn.Size = new System.Drawing.Size(40, 40);
            this.SizeLBtn.TabIndex = 3;
            this.SizeLBtn.Text = "L";
            this.SizeLBtn.UseVisualStyleBackColor = false;
            this.SizeLBtn.Click += new System.EventHandler(this.SizeLBtn_Click);
            // 
            // SizeMBtn
            // 
            this.SizeMBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SizeMBtn.FlatAppearance.BorderSize = 0;
            this.SizeMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SizeMBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeMBtn.Location = new System.Drawing.Point(114, 270);
            this.SizeMBtn.Name = "SizeMBtn";
            this.SizeMBtn.Size = new System.Drawing.Size(40, 40);
            this.SizeMBtn.TabIndex = 4;
            this.SizeMBtn.Text = "M";
            this.SizeMBtn.UseVisualStyleBackColor = false;
            this.SizeMBtn.Click += new System.EventHandler(this.SizeMBtn_Click);
            // 
            // SizeSBtn
            // 
            this.SizeSBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.SizeSBtn.FlatAppearance.BorderSize = 0;
            this.SizeSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SizeSBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeSBtn.Location = new System.Drawing.Point(54, 270);
            this.SizeSBtn.Name = "SizeSBtn";
            this.SizeSBtn.Size = new System.Drawing.Size(40, 40);
            this.SizeSBtn.TabIndex = 5;
            this.SizeSBtn.Text = "S";
            this.SizeSBtn.UseVisualStyleBackColor = false;
            this.SizeSBtn.Click += new System.EventHandler(this.SizeSBtn_Click);
            // 
            // PriceItem
            // 
            this.PriceItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceItem.Location = new System.Drawing.Point(140, 180);
            this.PriceItem.Name = "PriceItem";
            this.PriceItem.Size = new System.Drawing.Size(150, 40);
            this.PriceItem.TabIndex = 2;
            this.PriceItem.Text = "15.500.000 VNĐ";
            this.PriceItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderItemBtn
            // 
            this.OrderItemBtn.BackColor = System.Drawing.Color.Tan;
            this.OrderItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderItemBtn.ForeColor = System.Drawing.Color.White;
            this.OrderItemBtn.Location = new System.Drawing.Point(54, 370);
            this.OrderItemBtn.Name = "OrderItemBtn";
            this.OrderItemBtn.Size = new System.Drawing.Size(236, 60);
            this.OrderItemBtn.TabIndex = 1;
            this.OrderItemBtn.Text = "Order";
            this.OrderItemBtn.UseVisualStyleBackColor = false;
            this.OrderItemBtn.Click += new System.EventHandler(this.OrderItemBtn_Click);
            // 
            // ToppingLabel
            // 
            this.ToppingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToppingLabel.Location = new System.Drawing.Point(366, 230);
            this.ToppingLabel.Name = "ToppingLabel";
            this.ToppingLabel.Size = new System.Drawing.Size(100, 40);
            this.ToppingLabel.TabIndex = 0;
            this.ToppingLabel.Text = "Topping:";
            this.ToppingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SizeLabel
            // 
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SizeLabel.Location = new System.Drawing.Point(50, 230);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(100, 40);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "Size:";
            this.SizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pricelabel
            // 
            this.pricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pricelabel.Location = new System.Drawing.Point(50, 180);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(100, 40);
            this.pricelabel.TabIndex = 0;
            this.pricelabel.Text = "Price:";
            this.pricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameItem
            // 
            this.NameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameItem.Location = new System.Drawing.Point(50, 50);
            this.NameItem.Name = "NameItem";
            this.NameItem.Size = new System.Drawing.Size(630, 60);
            this.NameItem.TabIndex = 0;
            this.NameItem.Text = "Trà sữa trân châu đường đen";
            this.NameItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(287, 850);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 2;
            // 
            // DetailProductPagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DetailItemPanel);
            this.Controls.Add(this.RelationItemPanel);
            this.Name = "DetailProductPagePanel";
            this.Size = new System.Drawing.Size(1239, 583);
            this.DetailItemPanel.ResumeLayout(false);
            this.DetailItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox DescriptionItem;
        private System.Windows.Forms.FlowLayoutPanel ListImagePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label QuantityItem;
        private System.Windows.Forms.Button QuantityUp;
        private System.Windows.Forms.Button QuantityDown;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.FlowLayoutPanel ListToppings;
    }
}
