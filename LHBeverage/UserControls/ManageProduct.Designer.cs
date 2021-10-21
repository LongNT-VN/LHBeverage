
namespace LHBeverage.UserControls
{
    partial class ManageProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProduct));
            this.panelManageProduct = new System.Windows.Forms.Panel();
            this.AddImg_panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.loadImage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductList_cb = new System.Windows.Forms.ComboBox();
            this.Image_Pb = new System.Windows.Forms.PictureBox();
            this.AddImage = new System.Windows.Forms.Button();
            this.ImageBack_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ListPro_flowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPro_panel = new System.Windows.Forms.Panel();
            this.AddImg_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Quantity_tb = new System.Windows.Forms.TextBox();
            this.Des_Tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.category_Cb = new System.Windows.Forms.ComboBox();
            this.Price_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPro_btn = new System.Windows.Forms.Button();
            this.NamePro_tb = new System.Windows.Forms.TextBox();
            this.lbl_categortName = new System.Windows.Forms.Label();
            this.title_Cate_lbl = new System.Windows.Forms.Label();
            this.openFileDialog_Img = new System.Windows.Forms.OpenFileDialog();
            this.panelManageProduct.SuspendLayout();
            this.AddImg_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Pb)).BeginInit();
            this.AddPro_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManageProduct
            // 
            this.panelManageProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManageProduct.AutoScroll = true;
            this.panelManageProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.panelManageProduct.Controls.Add(this.AddImg_panel);
            this.panelManageProduct.Controls.Add(this.label2);
            this.panelManageProduct.Controls.Add(this.ListPro_flowpanel);
            this.panelManageProduct.Controls.Add(this.label1);
            this.panelManageProduct.Controls.Add(this.AddPro_panel);
            this.panelManageProduct.Location = new System.Drawing.Point(8, 8);
            this.panelManageProduct.Name = "panelManageProduct";
            this.panelManageProduct.Size = new System.Drawing.Size(1014, 600);
            this.panelManageProduct.TabIndex = 5;
            // 
            // AddImg_panel
            // 
            this.AddImg_panel.BackColor = System.Drawing.Color.White;
            this.AddImg_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddImg_panel.Controls.Add(this.label8);
            this.AddImg_panel.Controls.Add(this.loadImage);
            this.AddImg_panel.Controls.Add(this.label7);
            this.AddImg_panel.Controls.Add(this.ProductList_cb);
            this.AddImg_panel.Controls.Add(this.Image_Pb);
            this.AddImg_panel.Controls.Add(this.AddImage);
            this.AddImg_panel.Controls.Add(this.ImageBack_btn);
            this.AddImg_panel.Location = new System.Drawing.Point(580, 24);
            this.AddImg_panel.Name = "AddImg_panel";
            this.AddImg_panel.Size = new System.Drawing.Size(329, 422);
            this.AddImg_panel.TabIndex = 24;
            this.AddImg_panel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(109, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Add Image";
            // 
            // loadImage
            // 
            this.loadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.loadImage.FlatAppearance.BorderSize = 0;
            this.loadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadImage.ForeColor = System.Drawing.Color.Black;
            this.loadImage.Location = new System.Drawing.Point(113, 284);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(95, 26);
            this.loadImage.TabIndex = 27;
            this.loadImage.Text = "Load Image";
            this.loadImage.UseVisualStyleBackColor = false;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(59, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Choose product:";
            // 
            // ProductList_cb
            // 
            this.ProductList_cb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductList_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductList_cb.FormattingEnabled = true;
            this.ProductList_cb.Location = new System.Drawing.Point(58, 72);
            this.ProductList_cb.Name = "ProductList_cb";
            this.ProductList_cb.Size = new System.Drawing.Size(209, 21);
            this.ProductList_cb.TabIndex = 24;
            // 
            // Image_Pb
            // 
            this.Image_Pb.Image = ((System.Drawing.Image)(resources.GetObject("Image_Pb.Image")));
            this.Image_Pb.Location = new System.Drawing.Point(62, 122);
            this.Image_Pb.Name = "Image_Pb";
            this.Image_Pb.Size = new System.Drawing.Size(209, 133);
            this.Image_Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_Pb.TabIndex = 26;
            this.Image_Pb.TabStop = false;
            // 
            // AddImage
            // 
            this.AddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddImage.FlatAppearance.BorderSize = 0;
            this.AddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddImage.ForeColor = System.Drawing.Color.White;
            this.AddImage.Location = new System.Drawing.Point(200, 360);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(97, 33);
            this.AddImage.TabIndex = 25;
            this.AddImage.Text = "Add";
            this.AddImage.UseVisualStyleBackColor = false;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // ImageBack_btn
            // 
            this.ImageBack_btn.BackColor = System.Drawing.Color.Red;
            this.ImageBack_btn.FlatAppearance.BorderSize = 0;
            this.ImageBack_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageBack_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageBack_btn.ForeColor = System.Drawing.Color.White;
            this.ImageBack_btn.Location = new System.Drawing.Point(31, 360);
            this.ImageBack_btn.Name = "ImageBack_btn";
            this.ImageBack_btn.Size = new System.Drawing.Size(97, 33);
            this.ImageBack_btn.TabIndex = 24;
            this.ImageBack_btn.Text = "Back";
            this.ImageBack_btn.UseVisualStyleBackColor = false;
            this.ImageBack_btn.Click += new System.EventHandler(this.ImageBack_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(652, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "List category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListPro_flowpanel
            // 
            this.ListPro_flowpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPro_flowpanel.BackColor = System.Drawing.Color.White;
            this.ListPro_flowpanel.Location = new System.Drawing.Point(667, 45);
            this.ListPro_flowpanel.Name = "ListPro_flowpanel";
            this.ListPro_flowpanel.Size = new System.Drawing.Size(323, 361);
            this.ListPro_flowpanel.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Product manage page";
            // 
            // AddPro_panel
            // 
            this.AddPro_panel.BackColor = System.Drawing.Color.White;
            this.AddPro_panel.Controls.Add(this.AddImg_btn);
            this.AddPro_panel.Controls.Add(this.label6);
            this.AddPro_panel.Controls.Add(this.Quantity_tb);
            this.AddPro_panel.Controls.Add(this.Des_Tb);
            this.AddPro_panel.Controls.Add(this.label5);
            this.AddPro_panel.Controls.Add(this.category_Cb);
            this.AddPro_panel.Controls.Add(this.Price_tb);
            this.AddPro_panel.Controls.Add(this.label4);
            this.AddPro_panel.Controls.Add(this.label3);
            this.AddPro_panel.Controls.Add(this.AddPro_btn);
            this.AddPro_panel.Controls.Add(this.NamePro_tb);
            this.AddPro_panel.Controls.Add(this.lbl_categortName);
            this.AddPro_panel.Controls.Add(this.title_Cate_lbl);
            this.AddPro_panel.Location = new System.Drawing.Point(39, 45);
            this.AddPro_panel.Name = "AddPro_panel";
            this.AddPro_panel.Size = new System.Drawing.Size(621, 361);
            this.AddPro_panel.TabIndex = 3;
            // 
            // AddImg_btn
            // 
            this.AddImg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddImg_btn.FlatAppearance.BorderSize = 0;
            this.AddImg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddImg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddImg_btn.ForeColor = System.Drawing.Color.White;
            this.AddImg_btn.Location = new System.Drawing.Point(154, 315);
            this.AddImg_btn.Name = "AddImg_btn";
            this.AddImg_btn.Size = new System.Drawing.Size(135, 33);
            this.AddImg_btn.TabIndex = 23;
            this.AddImg_btn.Text = "Add  Images";
            this.AddImg_btn.UseVisualStyleBackColor = false;
            this.AddImg_btn.Click += new System.EventHandler(this.AddImg_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(334, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Quantity:";
            // 
            // Quantity_tb
            // 
            this.Quantity_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Quantity_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Quantity_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_tb.Location = new System.Drawing.Point(423, 111);
            this.Quantity_tb.Name = "Quantity_tb";
            this.Quantity_tb.Size = new System.Drawing.Size(180, 16);
            this.Quantity_tb.TabIndex = 21;
            // 
            // Des_Tb
            // 
            this.Des_Tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Des_Tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Des_Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Des_Tb.Location = new System.Drawing.Point(131, 167);
            this.Des_Tb.Multiline = true;
            this.Des_Tb.Name = "Des_Tb";
            this.Des_Tb.Size = new System.Drawing.Size(472, 122);
            this.Des_Tb.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(14, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Description:";
            // 
            // category_Cb
            // 
            this.category_Cb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.category_Cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_Cb.FormattingEnabled = true;
            this.category_Cb.Location = new System.Drawing.Point(482, 51);
            this.category_Cb.Name = "category_Cb";
            this.category_Cb.Size = new System.Drawing.Size(121, 21);
            this.category_Cb.TabIndex = 18;
            // 
            // Price_tb
            // 
            this.Price_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Price_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_tb.Location = new System.Drawing.Point(131, 110);
            this.Price_tb.Name = "Price_tb";
            this.Price_tb.Size = new System.Drawing.Size(180, 16);
            this.Price_tb.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(14, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(334, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Choose category:";
            // 
            // AddPro_btn
            // 
            this.AddPro_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddPro_btn.FlatAppearance.BorderSize = 0;
            this.AddPro_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPro_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPro_btn.ForeColor = System.Drawing.Color.White;
            this.AddPro_btn.Location = new System.Drawing.Point(17, 315);
            this.AddPro_btn.Name = "AddPro_btn";
            this.AddPro_btn.Size = new System.Drawing.Size(97, 33);
            this.AddPro_btn.TabIndex = 13;
            this.AddPro_btn.Text = "Add ";
            this.AddPro_btn.UseVisualStyleBackColor = false;
            this.AddPro_btn.Click += new System.EventHandler(this.AddPro_btn_Click);
            // 
            // NamePro_tb
            // 
            this.NamePro_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NamePro_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NamePro_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePro_tb.Location = new System.Drawing.Point(131, 52);
            this.NamePro_tb.Name = "NamePro_tb";
            this.NamePro_tb.Size = new System.Drawing.Size(180, 16);
            this.NamePro_tb.TabIndex = 12;
            // 
            // lbl_categortName
            // 
            this.lbl_categortName.AutoSize = true;
            this.lbl_categortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categortName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_categortName.Location = new System.Drawing.Point(14, 51);
            this.lbl_categortName.Name = "lbl_categortName";
            this.lbl_categortName.Size = new System.Drawing.Size(100, 17);
            this.lbl_categortName.TabIndex = 11;
            this.lbl_categortName.Text = "Product name:";
            // 
            // title_Cate_lbl
            // 
            this.title_Cate_lbl.AutoSize = true;
            this.title_Cate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Cate_lbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.title_Cate_lbl.Location = new System.Drawing.Point(13, 10);
            this.title_Cate_lbl.Name = "title_Cate_lbl";
            this.title_Cate_lbl.Size = new System.Drawing.Size(138, 22);
            this.title_Cate_lbl.TabIndex = 8;
            this.title_Cate_lbl.Text = "+ Add Product";
            // 
            // openFileDialog_Img
            // 
            this.openFileDialog_Img.FileName = "openFileDialog1";
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelManageProduct);
            this.Name = "ManageProduct";
            this.Size = new System.Drawing.Size(1014, 600);
            this.panelManageProduct.ResumeLayout(false);
            this.panelManageProduct.PerformLayout();
            this.AddImg_panel.ResumeLayout(false);
            this.AddImg_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Pb)).EndInit();
            this.AddPro_panel.ResumeLayout(false);
            this.AddPro_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManageProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel ListPro_flowpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AddPro_panel;
        private System.Windows.Forms.TextBox Price_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddPro_btn;
        private System.Windows.Forms.TextBox NamePro_tb;
        private System.Windows.Forms.Label lbl_categortName;
        private System.Windows.Forms.Label title_Cate_lbl;
        private System.Windows.Forms.ComboBox category_Cb;
        private System.Windows.Forms.TextBox Des_Tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Quantity_tb;
        private System.Windows.Forms.Button AddImg_btn;
        private System.Windows.Forms.Panel AddImg_panel;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ProductList_cb;
        private System.Windows.Forms.PictureBox Image_Pb;
        private System.Windows.Forms.Button AddImage;
        private System.Windows.Forms.Button ImageBack_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Img;
    }
}
