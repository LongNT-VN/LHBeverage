
namespace LHBeverage.UserControls
{
    partial class AdminDetailProduct
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
            this.ListImagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ImgItem = new System.Windows.Forms.PictureBox();
            this.NameProduct_lbl = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.panel_CtnDetailPro = new System.Windows.Forms.Panel();
            this.QuantitysizeL = new System.Windows.Forms.Label();
            this.QuantitysizeS = new System.Windows.Forms.Label();
            this.PriceL = new System.Windows.Forms.Label();
            this.PriceM = new System.Windows.Forms.Label();
            this.QuantitysizeM = new System.Windows.Forms.Label();
            this.PriceS = new System.Windows.Forms.Label();
            this.sizeLlbl = new System.Windows.Forms.Label();
            this.sizeMlbl = new System.Windows.Forms.Label();
            this.sizeSLbl = new System.Windows.Forms.Label();
            this.quantity_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Btn_backPageProduct = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).BeginInit();
            this.panel_CtnDetailPro.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListImagePanel
            // 
            this.ListImagePanel.AutoScroll = true;
            this.ListImagePanel.BackColor = System.Drawing.Color.White;
            this.ListImagePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ListImagePanel.Location = new System.Drawing.Point(48, 324);
            this.ListImagePanel.Name = "ListImagePanel";
            this.ListImagePanel.Size = new System.Drawing.Size(300, 95);
            this.ListImagePanel.TabIndex = 12;
            this.ListImagePanel.Tag = "panelChange";
            // 
            // ImgItem
            // 
            this.ImgItem.BackgroundImage = global::LHBeverage.Properties.Resources.Banner;
            this.ImgItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgItem.ErrorImage = null;
            this.ImgItem.Location = new System.Drawing.Point(48, 19);
            this.ImgItem.Name = "ImgItem";
            this.ImgItem.Size = new System.Drawing.Size(300, 299);
            this.ImgItem.TabIndex = 11;
            this.ImgItem.TabStop = false;
            // 
            // NameProduct_lbl
            // 
            this.NameProduct_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameProduct_lbl.AutoSize = true;
            this.NameProduct_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameProduct_lbl.ForeColor = System.Drawing.Color.Red;
            this.NameProduct_lbl.Location = new System.Drawing.Point(424, 18);
            this.NameProduct_lbl.Name = "NameProduct_lbl";
            this.NameProduct_lbl.Size = new System.Drawing.Size(167, 29);
            this.NameProduct_lbl.TabIndex = 13;
            this.NameProduct_lbl.Text = "Name Product";
            // 
            // price_lbl
            // 
            this.price_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price_lbl.AutoSize = true;
            this.price_lbl.BackColor = System.Drawing.Color.Transparent;
            this.price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_lbl.Location = new System.Drawing.Point(589, 93);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(51, 22);
            this.price_lbl.TabIndex = 14;
            this.price_lbl.Tag = "change";
            this.price_lbl.Text = "Price";
            this.price_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_CtnDetailPro
            // 
            this.panel_CtnDetailPro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_CtnDetailPro.BackColor = System.Drawing.Color.White;
            this.panel_CtnDetailPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CtnDetailPro.Controls.Add(this.flowLayoutPanel1);
            this.panel_CtnDetailPro.Controls.Add(this.QuantitysizeL);
            this.panel_CtnDetailPro.Controls.Add(this.ImgItem);
            this.panel_CtnDetailPro.Controls.Add(this.QuantitysizeS);
            this.panel_CtnDetailPro.Controls.Add(this.ListImagePanel);
            this.panel_CtnDetailPro.Controls.Add(this.PriceL);
            this.panel_CtnDetailPro.Controls.Add(this.Description);
            this.panel_CtnDetailPro.Controls.Add(this.NameProduct_lbl);
            this.panel_CtnDetailPro.Controls.Add(this.PriceM);
            this.panel_CtnDetailPro.Controls.Add(this.label7);
            this.panel_CtnDetailPro.Controls.Add(this.QuantitysizeM);
            this.panel_CtnDetailPro.Controls.Add(this.PriceS);
            this.panel_CtnDetailPro.Controls.Add(this.sizeLlbl);
            this.panel_CtnDetailPro.Controls.Add(this.sizeMlbl);
            this.panel_CtnDetailPro.Controls.Add(this.sizeSLbl);
            this.panel_CtnDetailPro.Controls.Add(this.quantity_lbl);
            this.panel_CtnDetailPro.Controls.Add(this.price_lbl);
            this.panel_CtnDetailPro.Location = new System.Drawing.Point(63, 49);
            this.panel_CtnDetailPro.Name = "panel_CtnDetailPro";
            this.panel_CtnDetailPro.Size = new System.Drawing.Size(917, 492);
            this.panel_CtnDetailPro.TabIndex = 16;
            // 
            // QuantitysizeL
            // 
            this.QuantitysizeL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuantitysizeL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QuantitysizeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantitysizeL.ForeColor = System.Drawing.Color.Purple;
            this.QuantitysizeL.Location = new System.Drawing.Point(755, 255);
            this.QuantitysizeL.Name = "QuantitysizeL";
            this.QuantitysizeL.Size = new System.Drawing.Size(135, 42);
            this.QuantitysizeL.TabIndex = 25;
            this.QuantitysizeL.Text = "Price";
            this.QuantitysizeL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantitysizeS
            // 
            this.QuantitysizeS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuantitysizeS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QuantitysizeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantitysizeS.ForeColor = System.Drawing.Color.Purple;
            this.QuantitysizeS.Location = new System.Drawing.Point(755, 126);
            this.QuantitysizeS.Name = "QuantitysizeS";
            this.QuantitysizeS.Size = new System.Drawing.Size(135, 42);
            this.QuantitysizeS.TabIndex = 24;
            this.QuantitysizeS.Text = "Price";
            this.QuantitysizeS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceL
            // 
            this.PriceL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PriceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceL.ForeColor = System.Drawing.Color.Red;
            this.PriceL.Location = new System.Drawing.Point(546, 255);
            this.PriceL.Name = "PriceL";
            this.PriceL.Size = new System.Drawing.Size(135, 42);
            this.PriceL.TabIndex = 22;
            this.PriceL.Text = "Price";
            this.PriceL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceM
            // 
            this.PriceM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PriceM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceM.ForeColor = System.Drawing.Color.Red;
            this.PriceM.Location = new System.Drawing.Point(545, 193);
            this.PriceM.Name = "PriceM";
            this.PriceM.Size = new System.Drawing.Size(135, 42);
            this.PriceM.TabIndex = 21;
            this.PriceM.Text = "Price";
            this.PriceM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantitysizeM
            // 
            this.QuantitysizeM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuantitysizeM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QuantitysizeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantitysizeM.ForeColor = System.Drawing.Color.Purple;
            this.QuantitysizeM.Location = new System.Drawing.Point(755, 193);
            this.QuantitysizeM.Name = "QuantitysizeM";
            this.QuantitysizeM.Size = new System.Drawing.Size(135, 42);
            this.QuantitysizeM.TabIndex = 23;
            this.QuantitysizeM.Text = "Price";
            this.QuantitysizeM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceS
            // 
            this.PriceS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PriceS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceS.ForeColor = System.Drawing.Color.Red;
            this.PriceS.Location = new System.Drawing.Point(545, 126);
            this.PriceS.Name = "PriceS";
            this.PriceS.Size = new System.Drawing.Size(135, 42);
            this.PriceS.TabIndex = 20;
            this.PriceS.Text = "Price";
            this.PriceS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sizeLlbl
            // 
            this.sizeLlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sizeLlbl.BackColor = System.Drawing.Color.Transparent;
            this.sizeLlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLlbl.ForeColor = System.Drawing.Color.Black;
            this.sizeLlbl.Location = new System.Drawing.Point(405, 262);
            this.sizeLlbl.Name = "sizeLlbl";
            this.sizeLlbl.Size = new System.Drawing.Size(101, 28);
            this.sizeLlbl.TabIndex = 18;
            this.sizeLlbl.Tag = "change";
            this.sizeLlbl.Text = "Size L";
            this.sizeLlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sizeMlbl
            // 
            this.sizeMlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sizeMlbl.BackColor = System.Drawing.Color.Transparent;
            this.sizeMlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeMlbl.ForeColor = System.Drawing.Color.Black;
            this.sizeMlbl.Location = new System.Drawing.Point(405, 200);
            this.sizeMlbl.Name = "sizeMlbl";
            this.sizeMlbl.Size = new System.Drawing.Size(101, 28);
            this.sizeMlbl.TabIndex = 17;
            this.sizeMlbl.Tag = "change";
            this.sizeMlbl.Text = "Size M";
            this.sizeMlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sizeSLbl
            // 
            this.sizeSLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sizeSLbl.BackColor = System.Drawing.Color.Transparent;
            this.sizeSLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeSLbl.ForeColor = System.Drawing.Color.Black;
            this.sizeSLbl.Location = new System.Drawing.Point(404, 133);
            this.sizeSLbl.Name = "sizeSLbl";
            this.sizeSLbl.Size = new System.Drawing.Size(101, 28);
            this.sizeSLbl.TabIndex = 16;
            this.sizeSLbl.Tag = "change";
            this.sizeSLbl.Text = "Size S";
            this.sizeSLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantity_lbl
            // 
            this.quantity_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantity_lbl.AutoSize = true;
            this.quantity_lbl.BackColor = System.Drawing.Color.Transparent;
            this.quantity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_lbl.Location = new System.Drawing.Point(783, 93);
            this.quantity_lbl.Name = "quantity_lbl";
            this.quantity_lbl.Size = new System.Drawing.Size(77, 22);
            this.quantity_lbl.TabIndex = 15;
            this.quantity_lbl.Tag = "change";
            this.quantity_lbl.Text = "Quantity";
            this.quantity_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 20;
            this.label7.Tag = "change";
            this.label7.Text = "Description";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Description
            // 
            this.Description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.Color.Transparent;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(425, 381);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(89, 20);
            this.Description.TabIndex = 21;
            this.Description.Tag = "change";
            this.Description.Text = "Description";
            // 
            // Btn_backPageProduct
            // 
            this.Btn_backPageProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_backPageProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_backPageProduct.FlatAppearance.BorderSize = 0;
            this.Btn_backPageProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_backPageProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_backPageProduct.ForeColor = System.Drawing.Color.White;
            this.Btn_backPageProduct.Location = new System.Drawing.Point(63, 5);
            this.Btn_backPageProduct.Name = "Btn_backPageProduct";
            this.Btn_backPageProduct.Size = new System.Drawing.Size(91, 37);
            this.Btn_backPageProduct.TabIndex = 23;
            this.Btn_backPageProduct.Text = "Back";
            this.Btn_backPageProduct.UseVisualStyleBackColor = false;
            this.Btn_backPageProduct.Click += new System.EventHandler(this.Btn_backPageProduct_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(48, 393);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 33);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.Tag = "panelChange";
            // 
            // AdminDetailProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.Btn_backPageProduct);
            this.Controls.Add(this.panel_CtnDetailPro);
            this.Name = "AdminDetailProduct";
            this.Size = new System.Drawing.Size(1014, 600);
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).EndInit();
            this.panel_CtnDetailPro.ResumeLayout(false);
            this.panel_CtnDetailPro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ListImagePanel;
        private System.Windows.Forms.PictureBox ImgItem;
        private System.Windows.Forms.Label NameProduct_lbl;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Panel panel_CtnDetailPro;
        private System.Windows.Forms.Label sizeLlbl;
        private System.Windows.Forms.Label sizeMlbl;
        private System.Windows.Forms.Label sizeSLbl;
        private System.Windows.Forms.Label quantity_lbl;
        private System.Windows.Forms.Label QuantitysizeL;
        private System.Windows.Forms.Label QuantitysizeS;
        private System.Windows.Forms.Label QuantitysizeM;
        private System.Windows.Forms.Label PriceL;
        private System.Windows.Forms.Label PriceM;
        private System.Windows.Forms.Label PriceS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Button Btn_backPageProduct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
