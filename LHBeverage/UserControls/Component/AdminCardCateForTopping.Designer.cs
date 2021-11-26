
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoryname_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toppings have category:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryname_lbl
            // 
            this.categoryname_lbl.BackColor = System.Drawing.Color.Transparent;
            this.categoryname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryname_lbl.ForeColor = System.Drawing.Color.Yellow;
            this.categoryname_lbl.Location = new System.Drawing.Point(280, 0);
            this.categoryname_lbl.Name = "categoryname_lbl";
            this.categoryname_lbl.Size = new System.Drawing.Size(207, 31);
            this.categoryname_lbl.TabIndex = 1;
            this.categoryname_lbl.Text = "categoryname";
            this.categoryname_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminCardCateForTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.categoryname_lbl);
            this.Controls.Add(this.label1);
            this.Name = "AdminCardCateForTopping";
            this.Size = new System.Drawing.Size(490, 31);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label categoryname_lbl;
    }
}
