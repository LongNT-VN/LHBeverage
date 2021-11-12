
namespace LHBeverage.UserControls.Component
{
    partial class BigCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigCard));
            this.DesShortBC_lbl = new System.Windows.Forms.Label();
            this.BuyBC_btn = new System.Windows.Forms.Button();
            this.priceDrinksBC_lbl = new System.Windows.Forms.Label();
            this.HotSaleBC_lbl = new System.Windows.Forms.Label();
            this.nameDrinkBC_lbl = new System.Windows.Forms.Label();
            this.BigCard_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BigCard_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // DesShortBC_lbl
            // 
            this.DesShortBC_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesShortBC_lbl.ForeColor = System.Drawing.Color.MintCream;
            this.DesShortBC_lbl.Location = new System.Drawing.Point(210, 90);
            this.DesShortBC_lbl.Name = "DesShortBC_lbl";
            this.DesShortBC_lbl.Size = new System.Drawing.Size(257, 40);
            this.DesShortBC_lbl.TabIndex = 11;
            this.DesShortBC_lbl.Text = "Green tea with a little sweetness \r\n";
            // 
            // BuyBC_btn
            // 
            this.BuyBC_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(143)))), ((int)(((byte)(209)))));
            this.BuyBC_btn.FlatAppearance.BorderSize = 0;
            this.BuyBC_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBC_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyBC_btn.ForeColor = System.Drawing.Color.White;
            this.BuyBC_btn.Location = new System.Drawing.Point(371, 130);
            this.BuyBC_btn.Name = "BuyBC_btn";
            this.BuyBC_btn.Size = new System.Drawing.Size(100, 40);
            this.BuyBC_btn.TabIndex = 10;
            this.BuyBC_btn.Text = "Buy now!!";
            this.BuyBC_btn.UseVisualStyleBackColor = false;
            // 
            // priceDrinksBC_lbl
            // 
            this.priceDrinksBC_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceDrinksBC_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.priceDrinksBC_lbl.Location = new System.Drawing.Point(222, 130);
            this.priceDrinksBC_lbl.Name = "priceDrinksBC_lbl";
            this.priceDrinksBC_lbl.Size = new System.Drawing.Size(152, 40);
            this.priceDrinksBC_lbl.TabIndex = 9;
            this.priceDrinksBC_lbl.Text = "$5";
            this.priceDrinksBC_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HotSaleBC_lbl
            // 
            this.HotSaleBC_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotSaleBC_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(149)))));
            this.HotSaleBC_lbl.Location = new System.Drawing.Point(210, 5);
            this.HotSaleBC_lbl.Name = "HotSaleBC_lbl";
            this.HotSaleBC_lbl.Size = new System.Drawing.Size(264, 20);
            this.HotSaleBC_lbl.TabIndex = 8;
            this.HotSaleBC_lbl.Text = "Hot sale";
            // 
            // nameDrinkBC_lbl
            // 
            this.nameDrinkBC_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDrinkBC_lbl.ForeColor = System.Drawing.Color.White;
            this.nameDrinkBC_lbl.Location = new System.Drawing.Point(210, 30);
            this.nameDrinkBC_lbl.Name = "nameDrinkBC_lbl";
            this.nameDrinkBC_lbl.Size = new System.Drawing.Size(261, 60);
            this.nameDrinkBC_lbl.TabIndex = 7;
            this.nameDrinkBC_lbl.Text = "Trà sữa trân châu đường đen";
            // 
            // BigCard_picture
            // 
            this.BigCard_picture.Enabled = false;
            this.BigCard_picture.Image = ((System.Drawing.Image)(resources.GetObject("BigCard_picture.Image")));
            this.BigCard_picture.Location = new System.Drawing.Point(5, 5);
            this.BigCard_picture.Name = "BigCard_picture";
            this.BigCard_picture.Size = new System.Drawing.Size(200, 170);
            this.BigCard_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigCard_picture.TabIndex = 6;
            this.BigCard_picture.TabStop = false;
            // 
            // BigCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.DesShortBC_lbl);
            this.Controls.Add(this.BuyBC_btn);
            this.Controls.Add(this.priceDrinksBC_lbl);
            this.Controls.Add(this.HotSaleBC_lbl);
            this.Controls.Add(this.nameDrinkBC_lbl);
            this.Controls.Add(this.BigCard_picture);
            this.Name = "BigCard";
            this.Size = new System.Drawing.Size(475, 180);
            ((System.ComponentModel.ISupportInitialize)(this.BigCard_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DesShortBC_lbl;
        private System.Windows.Forms.Button BuyBC_btn;
        private System.Windows.Forms.Label priceDrinksBC_lbl;
        private System.Windows.Forms.Label HotSaleBC_lbl;
        private System.Windows.Forms.Label nameDrinkBC_lbl;
        private System.Windows.Forms.PictureBox BigCard_picture;
    }
}
