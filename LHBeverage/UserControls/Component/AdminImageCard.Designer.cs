
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
            this.Delete_btn = new System.Windows.Forms.Button();
            this.picturePro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePro)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Red;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(0, 120);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(147, 27);
            this.Delete_btn.TabIndex = 1;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // picturePro
            // 
            this.picturePro.Location = new System.Drawing.Point(-3, 3);
            this.picturePro.Name = "picturePro";
            this.picturePro.Size = new System.Drawing.Size(147, 119);
            this.picturePro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePro.TabIndex = 0;
            this.picturePro.TabStop = false;
            // 
            // AdminImageCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.picturePro);
            this.Name = "AdminImageCard";
            this.Size = new System.Drawing.Size(147, 149);
            ((System.ComponentModel.ISupportInitialize)(this.picturePro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePro;
        private System.Windows.Forms.Button Delete_btn;
    }
}
