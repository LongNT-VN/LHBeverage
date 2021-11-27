
namespace LHBeverage.UserControls.Component
{
    partial class AdminCardCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCardCategory));
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameCategory_lbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.delete_btn = new System.Windows.Forms.Button();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.CateImage = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CateImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.CateImage);
            this.panel3.Controls.Add(this.nameCategory_lbl);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Name = "panel3";
            // 
            // nameCategory_lbl
            // 
            resources.ApplyResources(this.nameCategory_lbl, "nameCategory_lbl");
            this.nameCategory_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameCategory_lbl.Name = "nameCategory_lbl";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.delete_btn);
            this.panel4.Controls.Add(this.Edit_btn);
            this.panel4.Name = "panel4";
            // 
            // delete_btn
            // 
            resources.ApplyResources(this.delete_btn, "delete_btn");
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Edit_btn
            // 
            resources.ApplyResources(this.Edit_btn, "Edit_btn");
            this.Edit_btn.BackColor = System.Drawing.Color.Blue;
            this.Edit_btn.FlatAppearance.BorderSize = 0;
            this.Edit_btn.ForeColor = System.Drawing.Color.White;
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.UseVisualStyleBackColor = false;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // CateImage
            // 
            resources.ApplyResources(this.CateImage, "CateImage");
            this.CateImage.Name = "CateImage";
            this.CateImage.TabStop = false;
            // 
            // AdminCardCategory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Name = "AdminCardCategory";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CateImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label nameCategory_lbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.PictureBox CateImage;
    }
}
