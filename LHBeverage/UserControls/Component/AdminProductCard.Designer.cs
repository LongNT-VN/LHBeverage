
namespace LHBeverage.UserControls.Component
{
    partial class AdminProductCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameProduct_lbl = new System.Windows.Forms.Label();
            this.Picture_Pro = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Pro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.NameProduct_lbl);
            this.panel1.Controls.Add(this.Picture_Pro);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 100);
            this.panel1.TabIndex = 1;
            // 
            // NameProduct_lbl
            // 
            this.NameProduct_lbl.AutoSize = true;
            this.NameProduct_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameProduct_lbl.ForeColor = System.Drawing.Color.Black;
            this.NameProduct_lbl.Location = new System.Drawing.Point(157, 44);
            this.NameProduct_lbl.Name = "NameProduct_lbl";
            this.NameProduct_lbl.Size = new System.Drawing.Size(112, 17);
            this.NameProduct_lbl.TabIndex = 28;
            this.NameProduct_lbl.Text = "Choose product:";
            // 
            // Picture_Pro
            // 
            this.Picture_Pro.Location = new System.Drawing.Point(3, 0);
            this.Picture_Pro.Name = "Picture_Pro";
            this.Picture_Pro.Size = new System.Drawing.Size(115, 100);
            this.Picture_Pro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Pro.TabIndex = 0;
            this.Picture_Pro.TabStop = false;
            // 
            // AdminProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdminProductCard";
            this.Size = new System.Drawing.Size(320, 100);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Pro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameProduct_lbl;
        private System.Windows.Forms.PictureBox Picture_Pro;
    }
}
