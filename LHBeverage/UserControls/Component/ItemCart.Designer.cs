
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
            this.NameItem = new System.Windows.Forms.Label();
            this.PriceItem = new System.Windows.Forms.Label();
            this.SizeSBtn = new System.Windows.Forms.Button();
            this.SizeMBtn = new System.Windows.Forms.Button();
            this.SizeLBtn = new System.Windows.Forms.Button();
            this.QuantityItem = new System.Windows.Forms.Label();
            this.ImageItem = new System.Windows.Forms.PictureBox();
            this.QuantityDown = new System.Windows.Forms.Button();
            this.QuantityUp = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.Topping = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ImageItem)).BeginInit();
            this.SuspendLayout();
            // 
            // NameItem
            // 
            this.NameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameItem.ForeColor = System.Drawing.Color.DimGray;
            this.NameItem.Location = new System.Drawing.Point(250, 5);
            this.NameItem.Name = "NameItem";
            this.NameItem.Size = new System.Drawing.Size(415, 40);
            this.NameItem.TabIndex = 1;
            this.NameItem.Text = "Trà sữa trân châu đường đen";
            this.NameItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceItem
            // 
            this.PriceItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PriceItem.Location = new System.Drawing.Point(250, 139);
            this.PriceItem.Name = "PriceItem";
            this.PriceItem.Size = new System.Drawing.Size(184, 40);
            this.PriceItem.TabIndex = 1;
            this.PriceItem.Text = "50.000 VNĐ";
            this.PriceItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SizeSBtn
            // 
            this.SizeSBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.SizeSBtn.FlatAppearance.BorderSize = 0;
            this.SizeSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SizeSBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeSBtn.Location = new System.Drawing.Point(250, 55);
            this.SizeSBtn.Name = "SizeSBtn";
            this.SizeSBtn.Size = new System.Drawing.Size(40, 40);
            this.SizeSBtn.TabIndex = 2;
            this.SizeSBtn.Text = "S";
            this.SizeSBtn.UseVisualStyleBackColor = false;
            this.SizeSBtn.Click += new System.EventHandler(this.SizeSBtn_Click);
            // 
            // SizeMBtn
            // 
            this.SizeMBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SizeMBtn.FlatAppearance.BorderSize = 0;
            this.SizeMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SizeMBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeMBtn.Location = new System.Drawing.Point(310, 55);
            this.SizeMBtn.Name = "SizeMBtn";
            this.SizeMBtn.Size = new System.Drawing.Size(40, 40);
            this.SizeMBtn.TabIndex = 2;
            this.SizeMBtn.Text = "M";
            this.SizeMBtn.UseVisualStyleBackColor = false;
            this.SizeMBtn.Click += new System.EventHandler(this.SizeMBtn_Click);
            // 
            // SizeLBtn
            // 
            this.SizeLBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SizeLBtn.FlatAppearance.BorderSize = 0;
            this.SizeLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SizeLBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLBtn.Location = new System.Drawing.Point(370, 55);
            this.SizeLBtn.Name = "SizeLBtn";
            this.SizeLBtn.Size = new System.Drawing.Size(40, 40);
            this.SizeLBtn.TabIndex = 2;
            this.SizeLBtn.Text = "L";
            this.SizeLBtn.UseVisualStyleBackColor = false;
            this.SizeLBtn.Click += new System.EventHandler(this.SizeLBtn_Click);
            // 
            // QuantityItem
            // 
            this.QuantityItem.BackColor = System.Drawing.Color.White;
            this.QuantityItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityItem.Location = new System.Drawing.Point(310, 107);
            this.QuantityItem.Name = "QuantityItem";
            this.QuantityItem.Size = new System.Drawing.Size(40, 30);
            this.QuantityItem.TabIndex = 3;
            this.QuantityItem.Text = "11";
            this.QuantityItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuantityItem.TextChanged += new System.EventHandler(this.QuantityItem_TextChanged);
            // 
            // ImageItem
            // 
            this.ImageItem.BackColor = System.Drawing.Color.White;
            this.ImageItem.BackgroundImage = global::LHBeverage.Properties.Resources.Banner;
            this.ImageItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageItem.InitialImage = null;
            this.ImageItem.Location = new System.Drawing.Point(50, 10);
            this.ImageItem.Name = "ImageItem";
            this.ImageItem.Size = new System.Drawing.Size(170, 170);
            this.ImageItem.TabIndex = 0;
            this.ImageItem.TabStop = false;
            // 
            // QuantityDown
            // 
            this.QuantityDown.BackColor = System.Drawing.SystemColors.Control;
            this.QuantityDown.FlatAppearance.BorderSize = 0;
            this.QuantityDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityDown.Location = new System.Drawing.Point(265, 107);
            this.QuantityDown.Name = "QuantityDown";
            this.QuantityDown.Size = new System.Drawing.Size(30, 30);
            this.QuantityDown.TabIndex = 2;
            this.QuantityDown.Text = "-";
            this.QuantityDown.UseVisualStyleBackColor = false;
            this.QuantityDown.Click += new System.EventHandler(this.QuantityDown_Click);
            // 
            // QuantityUp
            // 
            this.QuantityUp.BackColor = System.Drawing.SystemColors.Control;
            this.QuantityUp.FlatAppearance.BorderSize = 0;
            this.QuantityUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityUp.Location = new System.Drawing.Point(365, 108);
            this.QuantityUp.Name = "QuantityUp";
            this.QuantityUp.Size = new System.Drawing.Size(30, 30);
            this.QuantityUp.TabIndex = 2;
            this.QuantityUp.Text = "+";
            this.QuantityUp.UseVisualStyleBackColor = false;
            this.QuantityUp.Click += new System.EventHandler(this.QuantityUp_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.Red;
            this.RemoveBtn.FlatAppearance.BorderSize = 0;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveBtn.Location = new System.Drawing.Point(720, 0);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(50, 190);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "Xóa";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // Topping
            // 
            this.Topping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Topping.Location = new System.Drawing.Point(440, 55);
            this.Topping.Name = "Topping";
            this.Topping.Size = new System.Drawing.Size(222, 100);
            this.Topping.TabIndex = 4;
            // 
            // ItemCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Size = new System.Drawing.Size(770, 190);
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
