
namespace LHBeverage.UserControls.Component
{
    partial class AdminCardCateForTopping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCardCateForTopping));
            this.label1 = new System.Windows.Forms.Label();
            this.categoryname_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // categoryname_lbl
            // 
            resources.ApplyResources(this.categoryname_lbl, "categoryname_lbl");
            this.categoryname_lbl.BackColor = System.Drawing.Color.Transparent;
            this.categoryname_lbl.ForeColor = System.Drawing.Color.Yellow;
            this.categoryname_lbl.Name = "categoryname_lbl";
            // 
            // AdminCardCateForTopping
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.categoryname_lbl);
            this.Controls.Add(this.label1);
            this.Name = "AdminCardCateForTopping";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label categoryname_lbl;
    }
}
