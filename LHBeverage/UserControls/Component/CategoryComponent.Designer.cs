
namespace LHBeverage.UserControls.Component
{
    partial class CategoryComponent
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
            this.Categorybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Categorybtn
            // 
            this.Categorybtn.FlatAppearance.BorderSize = 0;
            this.Categorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorybtn.Location = new System.Drawing.Point(0, 0);
            this.Categorybtn.Name = "Categorybtn";
            this.Categorybtn.Size = new System.Drawing.Size(150, 70);
            this.Categorybtn.TabIndex = 0;
            this.Categorybtn.Text = "Categorybtn";
            this.Categorybtn.UseVisualStyleBackColor = true;
            // 
            // CategoryComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Categorybtn);
            this.Name = "CategoryComponent";
            this.Size = new System.Drawing.Size(150, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Categorybtn;
    }
}
