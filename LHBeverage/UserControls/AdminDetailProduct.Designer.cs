
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.PriceS = new System.Windows.Forms.Label();
            this.PriceM = new System.Windows.Forms.Label();
            this.PriceL = new System.Windows.Forms.Label();
            this.QuantitysizeL = new System.Windows.Forms.Label();
            this.QuantitysizeS = new System.Windows.Forms.Label();
            this.QuantitysizeM = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_backPageProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListImagePanel
            // 
            this.ListImagePanel.AutoScroll = true;
            this.ListImagePanel.BackColor = System.Drawing.Color.White;
            this.ListImagePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ListImagePanel.Location = new System.Drawing.Point(93, 363);
            this.ListImagePanel.Name = "ListImagePanel";
            this.ListImagePanel.Size = new System.Drawing.Size(300, 92);
            this.ListImagePanel.TabIndex = 12;
            // 
            // ImgItem
            // 
            this.ImgItem.BackgroundImage = global::LHBeverage.Properties.Resources.Banner;
            this.ImgItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgItem.ErrorImage = null;
            this.ImgItem.Location = new System.Drawing.Point(41, 15);
            this.ImgItem.Name = "ImgItem";
            this.ImgItem.Size = new System.Drawing.Size(222, 256);
            this.ImgItem.TabIndex = 11;
            this.ImgItem.TabStop = false;
            // 
            // NameProduct_lbl
            // 
            this.NameProduct_lbl.AutoSize = true;
            this.NameProduct_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameProduct_lbl.Location = new System.Drawing.Point(429, 48);
            this.NameProduct_lbl.Name = "NameProduct_lbl";
            this.NameProduct_lbl.Size = new System.Drawing.Size(167, 29);
            this.NameProduct_lbl.TabIndex = 13;
            this.NameProduct_lbl.Text = "Name Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.QuantitysizeL);
            this.panel1.Controls.Add(this.QuantitysizeS);
            this.panel1.Controls.Add(this.PriceL);
            this.panel1.Controls.Add(this.PriceM);
            this.panel1.Controls.Add(this.QuantitysizeM);
            this.panel1.Controls.Add(this.PriceS);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(434, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 216);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(2, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Size S";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Size M";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(3, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Size L";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Description";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.Color.Transparent;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(437, 383);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(89, 20);
            this.Description.TabIndex = 21;
            this.Description.Text = "Description";
            // 
            // PriceS
            // 
            this.PriceS.BackColor = System.Drawing.SystemColors.Control;
            this.PriceS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceS.ForeColor = System.Drawing.Color.Red;
            this.PriceS.Location = new System.Drawing.Point(143, 34);
            this.PriceS.Name = "PriceS";
            this.PriceS.Size = new System.Drawing.Size(135, 42);
            this.PriceS.TabIndex = 20;
            this.PriceS.Text = "Price";
            this.PriceS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceM
            // 
            this.PriceM.BackColor = System.Drawing.SystemColors.Control;
            this.PriceM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceM.ForeColor = System.Drawing.Color.Red;
            this.PriceM.Location = new System.Drawing.Point(143, 101);
            this.PriceM.Name = "PriceM";
            this.PriceM.Size = new System.Drawing.Size(135, 42);
            this.PriceM.TabIndex = 21;
            this.PriceM.Text = "Price";
            this.PriceM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceL
            // 
            this.PriceL.BackColor = System.Drawing.SystemColors.Control;
            this.PriceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceL.ForeColor = System.Drawing.Color.Red;
            this.PriceL.Location = new System.Drawing.Point(144, 163);
            this.PriceL.Name = "PriceL";
            this.PriceL.Size = new System.Drawing.Size(135, 42);
            this.PriceL.TabIndex = 22;
            this.PriceL.Text = "Price";
            this.PriceL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantitysizeL
            // 
            this.QuantitysizeL.BackColor = System.Drawing.SystemColors.Control;
            this.QuantitysizeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantitysizeL.ForeColor = System.Drawing.Color.Red;
            this.QuantitysizeL.Location = new System.Drawing.Point(353, 163);
            this.QuantitysizeL.Name = "QuantitysizeL";
            this.QuantitysizeL.Size = new System.Drawing.Size(135, 42);
            this.QuantitysizeL.TabIndex = 25;
            this.QuantitysizeL.Text = "Price";
            this.QuantitysizeL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantitysizeS
            // 
            this.QuantitysizeS.BackColor = System.Drawing.SystemColors.Control;
            this.QuantitysizeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantitysizeS.ForeColor = System.Drawing.Color.Red;
            this.QuantitysizeS.Location = new System.Drawing.Point(353, 34);
            this.QuantitysizeS.Name = "QuantitysizeS";
            this.QuantitysizeS.Size = new System.Drawing.Size(135, 42);
            this.QuantitysizeS.TabIndex = 24;
            this.QuantitysizeS.Text = "Price";
            this.QuantitysizeS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantitysizeM
            // 
            this.QuantitysizeM.BackColor = System.Drawing.SystemColors.Control;
            this.QuantitysizeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantitysizeM.ForeColor = System.Drawing.Color.Red;
            this.QuantitysizeM.Location = new System.Drawing.Point(353, 101);
            this.QuantitysizeM.Name = "QuantitysizeM";
            this.QuantitysizeM.Size = new System.Drawing.Size(135, 42);
            this.QuantitysizeM.TabIndex = 23;
            this.QuantitysizeM.Text = "Price";
            this.QuantitysizeM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.ImgItem);
            this.panel4.Location = new System.Drawing.Point(93, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 291);
            this.panel4.TabIndex = 22;
            // 
            // Btn_backPageProduct
            // 
            this.Btn_backPageProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_backPageProduct.FlatAppearance.BorderSize = 0;
            this.Btn_backPageProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_backPageProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_backPageProduct.ForeColor = System.Drawing.Color.White;
            this.Btn_backPageProduct.Location = new System.Drawing.Point(3, 3);
            this.Btn_backPageProduct.Name = "Btn_backPageProduct";
            this.Btn_backPageProduct.Size = new System.Drawing.Size(91, 37);
            this.Btn_backPageProduct.TabIndex = 23;
            this.Btn_backPageProduct.Text = "Back";
            this.Btn_backPageProduct.UseVisualStyleBackColor = false;
            this.Btn_backPageProduct.Click += new System.EventHandler(this.Btn_backPageProduct_Click);
            // 
            // AdminDetailProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_backPageProduct);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NameProduct_lbl);
            this.Controls.Add(this.ListImagePanel);
            this.Name = "AdminDetailProduct";
            this.Size = new System.Drawing.Size(1014, 600);
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ListImagePanel;
        private System.Windows.Forms.PictureBox ImgItem;
        private System.Windows.Forms.Label NameProduct_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label QuantitysizeL;
        private System.Windows.Forms.Label QuantitysizeS;
        private System.Windows.Forms.Label QuantitysizeM;
        private System.Windows.Forms.Label PriceL;
        private System.Windows.Forms.Label PriceM;
        private System.Windows.Forms.Label PriceS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_backPageProduct;
    }
}
