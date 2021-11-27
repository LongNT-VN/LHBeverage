
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageCategory));
            this.openImageCate = new System.Windows.Forms.OpenFileDialog();
            this.panelHide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListCate_flowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAddCate = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UpdateCate_btn = new System.Windows.Forms.Button();
            this.AddCate_btn = new System.Windows.Forms.Button();
            this.AddCate_tb = new System.Windows.Forms.TextBox();
            this.lbl_categortName = new System.Windows.Forms.Label();
            this.ImageCate_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelAddCate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCate_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageCate
            // 
            this.openImageCate.FileName = "openFileDialog1";
            resources.ApplyResources(this.openImageCate, "openImageCate");
            // 
            // panelHide
            // 
            resources.ApplyResources(this.panelHide, "panelHide");
            this.panelHide.BackColor = System.Drawing.Color.Transparent;
            this.panelHide.Name = "panelHide";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // ListCate_flowpanel
            // 
            resources.ApplyResources(this.ListCate_flowpanel, "ListCate_flowpanel");
            this.ListCate_flowpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListCate_flowpanel.Name = "ListCate_flowpanel";
            this.ListCate_flowpanel.Tag = "panelChange";
            // 
            // panelAddCate
            // 
            resources.ApplyResources(this.panelAddCate, "panelAddCate");
            this.panelAddCate.BackColor = System.Drawing.Color.White;
            this.panelAddCate.Controls.Add(this.label1);
            this.panelAddCate.Controls.Add(this.ImageCate_pictureBox);
            this.panelAddCate.Controls.Add(this.panel4);
            this.panelAddCate.Controls.Add(this.UpdateCate_btn);
            this.panelAddCate.Controls.Add(this.AddCate_btn);
            this.panelAddCate.Controls.Add(this.AddCate_tb);
            this.panelAddCate.Controls.Add(this.lbl_categortName);
            this.panelAddCate.Name = "panelAddCate";
            this.panelAddCate.Tag = "panelChange";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Name = "label1";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel4.Name = "panel4";
            // 
            // UpdateCate_btn
            // 
            resources.ApplyResources(this.UpdateCate_btn, "UpdateCate_btn");
            this.UpdateCate_btn.BackColor = System.Drawing.Color.Orange;
            this.UpdateCate_btn.FlatAppearance.BorderSize = 0;
            this.UpdateCate_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateCate_btn.Name = "UpdateCate_btn";
            this.UpdateCate_btn.UseVisualStyleBackColor = false;
            this.UpdateCate_btn.Click += new System.EventHandler(this.UpdateCate_btn_Click);
            // 
            // AddCate_btn
            // 
            resources.ApplyResources(this.AddCate_btn, "AddCate_btn");
            this.AddCate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddCate_btn.FlatAppearance.BorderSize = 0;
            this.AddCate_btn.ForeColor = System.Drawing.Color.White;
            this.AddCate_btn.Name = "AddCate_btn";
            this.AddCate_btn.UseVisualStyleBackColor = false;
            this.AddCate_btn.Click += new System.EventHandler(this.AddCate_btn_Click);
            // 
            // AddCate_tb
            // 
            resources.ApplyResources(this.AddCate_tb, "AddCate_tb");
            this.AddCate_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddCate_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddCate_tb.Name = "AddCate_tb";
            // 
            // lbl_categortName
            // 
            resources.ApplyResources(this.lbl_categortName, "lbl_categortName");
            this.lbl_categortName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_categortName.Name = "lbl_categortName";
            // 
            // ImageCate_pictureBox
            // 
            resources.ApplyResources(this.ImageCate_pictureBox, "ImageCate_pictureBox");
            this.ImageCate_pictureBox.Image = global::LHBeverage.Properties.Resources.cloud_upload_a30f385a928e44e199a62210d578375a;
            this.ImageCate_pictureBox.Name = "ImageCate_pictureBox";
            this.ImageCate_pictureBox.TabStop = false;
            this.ImageCate_pictureBox.Click += new System.EventHandler(this.ImageCate_pictureBox_Click);
            // 
            // AdminManageCategory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.panelHide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListCate_flowpanel);
            this.Controls.Add(this.panelAddCate);
            this.Name = "AdminManageCategory";
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
