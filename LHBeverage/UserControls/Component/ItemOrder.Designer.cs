
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
            this.PriceItem = new System.Windows.Forms.Label();
            this.NameItem = new System.Windows.Forms.Label();
            this.ImageItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageItem)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceItem
            // 
            this.PriceItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PriceItem.Location = new System.Drawing.Point(278, 142);
            this.PriceItem.Name = "PriceItem";
            this.PriceItem.Size = new System.Drawing.Size(184, 40);
            this.PriceItem.TabIndex = 4;
            this.PriceItem.Text = "50.000 VNĐ";
            this.PriceItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameItem
            // 
            this.NameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameItem.ForeColor = System.Drawing.Color.DimGray;
            this.NameItem.Location = new System.Drawing.Point(278, 13);
            this.NameItem.Name = "NameItem";
            this.NameItem.Size = new System.Drawing.Size(415, 40);
            this.NameItem.TabIndex = 3;
            this.NameItem.Text = "Trà sữa trân châu đường đen";
            this.NameItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImageItem
            // 
            this.ImageItem.BackColor = System.Drawing.Color.White;
            this.ImageItem.BackgroundImage = global::LHBeverage.Properties.Resources.Banner;
            this.ImageItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageItem.InitialImage = null;
            this.ImageItem.Location = new System.Drawing.Point(78, 13);
            this.ImageItem.Name = "ImageItem";
            this.ImageItem.Size = new System.Drawing.Size(170, 170);
            this.ImageItem.TabIndex = 2;
            this.ImageItem.TabStop = false;
            // 
            // ItemOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriceItem);
            this.Controls.Add(this.NameItem);
            this.Controls.Add(this.ImageItem);
            this.Name = "ItemOrder";
            this.Size = new System.Drawing.Size(770, 190);
            ((System.ComponentModel.ISupportInitialize)(this.ImageItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PriceItem;
        private System.Windows.Forms.Label NameItem;
        private System.Windows.Forms.PictureBox ImageItem;
    }
}
