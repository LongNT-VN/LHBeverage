
namespace LHBeverage.UserControls
{
    partial class AdminManageCategory
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
            this.openImageCate = new System.Windows.Forms.OpenFileDialog();
            this.panelHide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListCate_flowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAddCate = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageCate_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UpdateCate_btn = new System.Windows.Forms.Button();
            this.AddCate_btn = new System.Windows.Forms.Button();
            this.AddCate_tb = new System.Windows.Forms.TextBox();
            this.lbl_categortName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelAddCate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCate_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageCate
            // 
            this.openImageCate.FileName = "openFileDialog1";
            // 
            // panelHide
            // 
            this.panelHide.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelHide.BackColor = System.Drawing.Color.Transparent;
            this.panelHide.Location = new System.Drawing.Point(912, 96);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(53, 409);
            this.panelHide.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(409, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 31);
            this.panel1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(287, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Action";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "List category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListCate_flowpanel
            // 
            this.ListCate_flowpanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ListCate_flowpanel.AutoScroll = true;
            this.ListCate_flowpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListCate_flowpanel.Location = new System.Drawing.Point(409, 131);
            this.ListCate_flowpanel.Name = "ListCate_flowpanel";
            this.ListCate_flowpanel.Size = new System.Drawing.Size(522, 371);
            this.ListCate_flowpanel.TabIndex = 31;
            this.ListCate_flowpanel.Tag = "panelChange";
            // 
            // panelAddCate
            // 
            this.panelAddCate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAddCate.BackColor = System.Drawing.Color.White;
            this.panelAddCate.Controls.Add(this.label1);
            this.panelAddCate.Controls.Add(this.ImageCate_pictureBox);
            this.panelAddCate.Controls.Add(this.panel4);
            this.panelAddCate.Controls.Add(this.UpdateCate_btn);
            this.panelAddCate.Controls.Add(this.AddCate_btn);
            this.panelAddCate.Controls.Add(this.AddCate_tb);
            this.panelAddCate.Controls.Add(this.lbl_categortName);
            this.panelAddCate.Location = new System.Drawing.Point(93, 99);
            this.panelAddCate.Name = "panelAddCate";
            this.panelAddCate.Size = new System.Drawing.Size(310, 366);
            this.panelAddCate.TabIndex = 30;
            this.panelAddCate.Tag = "panelChange";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(35, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Category Image:";
            // 
            // ImageCate_pictureBox
            // 
            this.ImageCate_pictureBox.Image = global::LHBeverage.Properties.Resources.cloud_upload_a30f385a928e44e199a62210d578375a;
            this.ImageCate_pictureBox.Location = new System.Drawing.Point(93, 169);
            this.ImageCate_pictureBox.Name = "ImageCate_pictureBox";
            this.ImageCate_pictureBox.Size = new System.Drawing.Size(128, 117);
            this.ImageCate_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageCate_pictureBox.TabIndex = 26;
            this.ImageCate_pictureBox.TabStop = false;
            this.ImageCate_pictureBox.Click += new System.EventHandler(this.ImageCate_pictureBox_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 31);
            this.panel4.TabIndex = 25;
            // 
            // UpdateCate_btn
            // 
            this.UpdateCate_btn.BackColor = System.Drawing.Color.Orange;
            this.UpdateCate_btn.FlatAppearance.BorderSize = 0;
            this.UpdateCate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCate_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateCate_btn.Location = new System.Drawing.Point(161, 315);
            this.UpdateCate_btn.Name = "UpdateCate_btn";
            this.UpdateCate_btn.Size = new System.Drawing.Size(97, 33);
            this.UpdateCate_btn.TabIndex = 17;
            this.UpdateCate_btn.Text = "Update";
            this.UpdateCate_btn.UseVisualStyleBackColor = false;
            this.UpdateCate_btn.Click += new System.EventHandler(this.UpdateCate_btn_Click);
            // 
            // AddCate_btn
            // 
            this.AddCate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddCate_btn.FlatAppearance.BorderSize = 0;
            this.AddCate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCate_btn.ForeColor = System.Drawing.Color.White;
            this.AddCate_btn.Location = new System.Drawing.Point(38, 315);
            this.AddCate_btn.Name = "AddCate_btn";
            this.AddCate_btn.Size = new System.Drawing.Size(97, 33);
            this.AddCate_btn.TabIndex = 13;
            this.AddCate_btn.Text = "Add ";
            this.AddCate_btn.UseVisualStyleBackColor = false;
            this.AddCate_btn.Click += new System.EventHandler(this.AddCate_btn_Click);
            // 
            // AddCate_tb
            // 
            this.AddCate_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddCate_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddCate_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCate_tb.Location = new System.Drawing.Point(38, 97);
            this.AddCate_tb.Name = "AddCate_tb";
            this.AddCate_tb.Size = new System.Drawing.Size(223, 20);
            this.AddCate_tb.TabIndex = 12;
            // 
            // lbl_categortName
            // 
            this.lbl_categortName.AutoSize = true;
            this.lbl_categortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categortName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_categortName.Location = new System.Drawing.Point(35, 59);
            this.lbl_categortName.Name = "lbl_categortName";
            this.lbl_categortName.Size = new System.Drawing.Size(113, 18);
            this.lbl_categortName.TabIndex = 11;
            this.lbl_categortName.Text = "Category name:";
            // 
            // AdminManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.panelHide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListCate_flowpanel);
            this.Controls.Add(this.panelAddCate);
            this.Name = "AdminManageCategory";
            this.Size = new System.Drawing.Size(1014, 600);
            this.panel1.ResumeLayout(false);
            this.panelAddCate.ResumeLayout(false);
            this.panelAddCate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCate_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openImageCate;
        private System.Windows.Forms.Panel panelHide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel ListCate_flowpanel;
        private System.Windows.Forms.Panel panelAddCate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImageCate_pictureBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button UpdateCate_btn;
        private System.Windows.Forms.Button AddCate_btn;
        private System.Windows.Forms.TextBox AddCate_tb;
        private System.Windows.Forms.Label lbl_categortName;
    }
}
