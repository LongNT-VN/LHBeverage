
namespace LHBeverage.UserControls.Component
{
    partial class AdminImageCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminImageCard));
            this.Delete_btn = new System.Windows.Forms.Button();
            this.picturePro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePro)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_btn
            // 
            resources.ApplyResources(this.Delete_btn, "Delete_btn");
            this.Delete_btn.BackColor = System.Drawing.Color.Red;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // picturePro
            // 
            resources.ApplyResources(this.picturePro, "picturePro");
            this.picturePro.Name = "picturePro";
            this.picturePro.TabStop = false;
            // 
            // AdminImageCard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.picturePro);
            this.Name = "AdminImageCard";
            ((System.ComponentModel.ISupportInitialize)(this.picturePro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePro;
        private System.Windows.Forms.Button Delete_btn;
    }
}
