
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
            this.BigCard_panel = new System.Windows.Forms.Panel();
            this.DesShortBC_lbl = new System.Windows.Forms.Label();
            this.BuyBC_btn = new System.Windows.Forms.Button();
            this.priceDrinksBC_lbl = new System.Windows.Forms.Label();
            this.HotSaleBC_lbl = new System.Windows.Forms.Label();
            this.nameDrinkBC_lbl = new System.Windows.Forms.Label();
            this.BigCard_picture = new System.Windows.Forms.PictureBox();
            this.BigCard_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BigCard_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // BigCard_panel
            // 
            this.BigCard_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(84)))));
            this.BigCard_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BigCard_panel.Controls.Add(this.DesShortBC_lbl);
            this.BigCard_panel.Controls.Add(this.BuyBC_btn);
            this.BigCard_panel.Controls.Add(this.priceDrinksBC_lbl);
            this.BigCard_panel.Controls.Add(this.HotSaleBC_lbl);
            this.BigCard_panel.Controls.Add(this.nameDrinkBC_lbl);
            this.BigCard_panel.Controls.Add(this.BigCard_picture);
            this.BigCard_panel.Location = new System.Drawing.Point(0, 0);
            this.BigCard_panel.Name = "BigCard_panel";
            this.BigCard_panel.Size = new System.Drawing.Size(512, 245);
            this.BigCard_panel.TabIndex = 5;
            // 
            // DesShortBC_lbl
            // 
            this.DesShortBC_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesShortBC_lbl.ForeColor = System.Drawing.Color.MintCream;
            this.DesShortBC_lbl.Location = new System.Drawing.Point(280, 120);
            this.DesShortBC_lbl.Name = "DesShortBC_lbl";
            this.DesShortBC_lbl.Size = new System.Drawing.Size(220, 40);
            this.DesShortBC_lbl.TabIndex = 5;
            this.DesShortBC_lbl.Text = "Green tea with a little sweetness \r\n";
            // 
            // BuyBC_btn
            // 
            this.BuyBC_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(143)))), ((int)(((byte)(209)))));
            this.BuyBC_btn.FlatAppearance.BorderSize = 0;
            this.BuyBC_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBC_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyBC_btn.ForeColor = System.Drawing.Color.White;
            this.BuyBC_btn.Location = new System.Drawing.Point(390, 190);
            this.BuyBC_btn.Name = "BuyBC_btn";
            this.BuyBC_btn.Size = new System.Drawing.Size(100, 40);
            this.BuyBC_btn.TabIndex = 4;
            this.BuyBC_btn.Text = "Buy now!!";
            this.BuyBC_btn.UseVisualStyleBackColor = false;
            // 
            // priceDrinksBC_lbl
            // 
            this.priceDrinksBC_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceDrinksBC_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.priceDrinksBC_lbl.Location = new System.Drawing.Point(280, 190);
            this.priceDrinksBC_lbl.Name = "priceDrinksBC_lbl";
            this.priceDrinksBC_lbl.Size = new System.Drawing.Size(100, 40);
            this.priceDrinksBC_lbl.TabIndex = 3;
            this.priceDrinksBC_lbl.Text = "$5";
            this.priceDrinksBC_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HotSaleBC_lbl
            // 
            this.HotSaleBC_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotSaleBC_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(149)))));
            this.HotSaleBC_lbl.Location = new System.Drawing.Point(280, 10);
            this.HotSaleBC_lbl.Name = "HotSaleBC_lbl";
            this.HotSaleBC_lbl.Size = new System.Drawing.Size(220, 20);
            this.HotSaleBC_lbl.TabIndex = 2;
            this.HotSaleBC_lbl.Text = "Hot sale";
            // 
            // nameDrinkBC_lbl
            // 
            this.nameDrinkBC_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDrinkBC_lbl.ForeColor = System.Drawing.Color.White;
            this.nameDrinkBC_lbl.Location = new System.Drawing.Point(280, 50);
            this.nameDrinkBC_lbl.Name = "nameDrinkBC_lbl";
            this.nameDrinkBC_lbl.Size = new System.Drawing.Size(220, 60);
            this.nameDrinkBC_lbl.TabIndex = 1;
            this.nameDrinkBC_lbl.Text = "Black sugar pearl \r\nmilk tea";
            // 
            // BigCard_picture
            // 
            this.BigCard_picture.Image = ((System.Drawing.Image)(resources.GetObject("BigCard_picture.Image")));
            this.BigCard_picture.Location = new System.Drawing.Point(0, 0);
            this.BigCard_picture.Name = "BigCard_picture";
            this.BigCard_picture.Size = new System.Drawing.Size(270, 245);
            this.BigCard_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigCard_picture.TabIndex = 0;
            this.BigCard_picture.TabStop = false;
            // 
            // BigCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BigCard_panel);
            this.Name = "BigCard";
            this.Size = new System.Drawing.Size(512, 245);
            this.BigCard_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BigCard_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BigCard_panel;
        private System.Windows.Forms.Label DesShortBC_lbl;
        private System.Windows.Forms.Button BuyBC_btn;
        private System.Windows.Forms.Label priceDrinksBC_lbl;
        private System.Windows.Forms.Label HotSaleBC_lbl;
        private System.Windows.Forms.Label nameDrinkBC_lbl;
        private System.Windows.Forms.PictureBox BigCard_picture;
    }
}
