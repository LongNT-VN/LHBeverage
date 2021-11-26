
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
            this.panelCtn = new System.Windows.Forms.Panel();
            this.NameProduct_lbl = new System.Windows.Forms.Label();
            this.lbl_namePro = new System.Windows.Forms.Label();
            this.DeletePro_btn = new System.Windows.Forms.Button();
            this.EditPro_btn = new System.Windows.Forms.Button();
            this.Picture_Pro = new System.Windows.Forms.PictureBox();
            this.panelCtn_2 = new System.Windows.Forms.Panel();
            this.QuantitysizeL_lbl = new System.Windows.Forms.Label();
            this.QuantitysizeM_lbl = new System.Windows.Forms.Label();
            this.QuantitysizeS_lbl = new System.Windows.Forms.Label();
            this.PriceMProduct_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PriceLProduct_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceSProduct_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Pro)).BeginInit();
            this.panelCtn_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCtn
            // 
            this.panelCtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCtn.Controls.Add(this.NameProduct_lbl);
            this.panelCtn.Controls.Add(this.lbl_namePro);
            this.panelCtn.Controls.Add(this.DeletePro_btn);
            this.panelCtn.Controls.Add(this.EditPro_btn);
            this.panelCtn.Controls.Add(this.Picture_Pro);
            this.panelCtn.Controls.Add(this.panelCtn_2);
            this.panelCtn.Location = new System.Drawing.Point(0, 0);
            this.panelCtn.Name = "panelCtn";
            this.panelCtn.Size = new System.Drawing.Size(860, 100);
            this.panelCtn.TabIndex = 1;
            // 
            // NameProduct_lbl
            // 
            this.NameProduct_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameProduct_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NameProduct_lbl.Location = new System.Drawing.Point(124, 38);
            this.NameProduct_lbl.Name = "NameProduct_lbl";
            this.NameProduct_lbl.Size = new System.Drawing.Size(151, 59);
            this.NameProduct_lbl.TabIndex = 34;
            this.NameProduct_lbl.Tag = "changeTextColor";
            this.NameProduct_lbl.Text = "Tên sản phẩm";
            this.NameProduct_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_namePro
            // 
            this.lbl_namePro.AutoSize = true;
            this.lbl_namePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namePro.ForeColor = System.Drawing.Color.Black;
            this.lbl_namePro.Location = new System.Drawing.Point(141, 5);
            this.lbl_namePro.Name = "lbl_namePro";
            this.lbl_namePro.Size = new System.Drawing.Size(113, 18);
            this.lbl_namePro.TabIndex = 31;
            this.lbl_namePro.Tag = "changeTextColor";
            this.lbl_namePro.Text = "Product name";
            // 
            // DeletePro_btn
            // 
            this.DeletePro_btn.BackColor = System.Drawing.Color.Red;
            this.DeletePro_btn.FlatAppearance.BorderSize = 0;
            this.DeletePro_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePro_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePro_btn.ForeColor = System.Drawing.Color.White;
            this.DeletePro_btn.Location = new System.Drawing.Point(780, 59);
            this.DeletePro_btn.Name = "DeletePro_btn";
            this.DeletePro_btn.Size = new System.Drawing.Size(74, 33);
            this.DeletePro_btn.TabIndex = 30;
            this.DeletePro_btn.Text = "Delete";
            this.DeletePro_btn.UseVisualStyleBackColor = false;
            this.DeletePro_btn.Click += new System.EventHandler(this.DeletePro_btn_Click);
            // 
            // EditPro_btn
            // 
            this.EditPro_btn.BackColor = System.Drawing.Color.Orange;
            this.EditPro_btn.FlatAppearance.BorderSize = 0;
            this.EditPro_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPro_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPro_btn.ForeColor = System.Drawing.Color.White;
            this.EditPro_btn.Location = new System.Drawing.Point(779, 11);
            this.EditPro_btn.Name = "EditPro_btn";
            this.EditPro_btn.Size = new System.Drawing.Size(74, 33);
            this.EditPro_btn.TabIndex = 29;
            this.EditPro_btn.Text = "Edit";
            this.EditPro_btn.UseVisualStyleBackColor = false;
            this.EditPro_btn.Click += new System.EventHandler(this.EditPro_btn_Click);
            // 
            // Picture_Pro
            // 
            this.Picture_Pro.Location = new System.Drawing.Point(3, 0);
            this.Picture_Pro.Name = "Picture_Pro";
            this.Picture_Pro.Size = new System.Drawing.Size(115, 100);
            this.Picture_Pro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Pro.TabIndex = 0;
            this.Picture_Pro.TabStop = false;
            this.Picture_Pro.Click += new System.EventHandler(this.Picture_Pro_Click);
            // 
            // panelCtn_2
            // 
            this.panelCtn_2.BackColor = System.Drawing.Color.Gainsboro;
            this.panelCtn_2.Controls.Add(this.QuantitysizeL_lbl);
            this.panelCtn_2.Controls.Add(this.QuantitysizeM_lbl);
            this.panelCtn_2.Controls.Add(this.QuantitysizeS_lbl);
            this.panelCtn_2.Controls.Add(this.PriceMProduct_lbl);
            this.panelCtn_2.Controls.Add(this.label10);
            this.panelCtn_2.Controls.Add(this.label11);
            this.panelCtn_2.Controls.Add(this.PriceLProduct_lbl);
            this.panelCtn_2.Controls.Add(this.label5);
            this.panelCtn_2.Controls.Add(this.PriceSProduct_lbl);
            this.panelCtn_2.Controls.Add(this.label4);
            this.panelCtn_2.Controls.Add(this.label2);
            this.panelCtn_2.Location = new System.Drawing.Point(281, 0);
            this.panelCtn_2.Name = "panelCtn_2";
            this.panelCtn_2.Size = new System.Drawing.Size(484, 100);
            this.panelCtn_2.TabIndex = 41;
            // 
            // QuantitysizeL_lbl
            // 
            this.QuantitysizeL_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantitysizeL_lbl.ForeColor = System.Drawing.Color.Red;
            this.QuantitysizeL_lbl.Location = new System.Drawing.Point(353, 73);
            this.QuantitysizeL_lbl.Name = "QuantitysizeL_lbl";
            this.QuantitysizeL_lbl.Size = new System.Drawing.Size(82, 18);
            this.QuantitysizeL_lbl.TabIndex = 42;
            this.QuantitysizeL_lbl.Text = "Qty_sizeL";
            this.QuantitysizeL_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantitysizeM_lbl
            // 
            this.QuantitysizeM_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantitysizeM_lbl.ForeColor = System.Drawing.Color.Red;
            this.QuantitysizeM_lbl.Location = new System.Drawing.Point(226, 73);
            this.QuantitysizeM_lbl.Name = "QuantitysizeM_lbl";
            this.QuantitysizeM_lbl.Size = new System.Drawing.Size(82, 18);
            this.QuantitysizeM_lbl.TabIndex = 41;
            this.QuantitysizeM_lbl.Text = "Qty_sizeM";
            this.QuantitysizeM_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantitysizeS_lbl
            // 
            this.QuantitysizeS_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantitysizeS_lbl.ForeColor = System.Drawing.Color.Red;
            this.QuantitysizeS_lbl.Location = new System.Drawing.Point(100, 73);
            this.QuantitysizeS_lbl.Name = "QuantitysizeS_lbl";
            this.QuantitysizeS_lbl.Size = new System.Drawing.Size(82, 18);
            this.QuantitysizeS_lbl.TabIndex = 36;
            this.QuantitysizeS_lbl.Text = "Qty_sizeS";
            this.QuantitysizeS_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceMProduct_lbl
            // 
            this.PriceMProduct_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceMProduct_lbl.ForeColor = System.Drawing.Color.Red;
            this.PriceMProduct_lbl.Location = new System.Drawing.Point(221, 40);
            this.PriceMProduct_lbl.Name = "PriceMProduct_lbl";
            this.PriceMProduct_lbl.Size = new System.Drawing.Size(96, 18);
            this.PriceMProduct_lbl.TabIndex = 38;
            this.PriceMProduct_lbl.Text = "0";
            this.PriceMProduct_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(3, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Price ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(3, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 33;
            this.label11.Text = "Quantity";
            // 
            // PriceLProduct_lbl
            // 
            this.PriceLProduct_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLProduct_lbl.ForeColor = System.Drawing.Color.Red;
            this.PriceLProduct_lbl.Location = new System.Drawing.Point(348, 40);
            this.PriceLProduct_lbl.Name = "PriceLProduct_lbl";
            this.PriceLProduct_lbl.Size = new System.Drawing.Size(96, 18);
            this.PriceLProduct_lbl.TabIndex = 40;
            this.PriceLProduct_lbl.Text = "0";
            this.PriceLProduct_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(362, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 40;
            this.label5.Tag = "changeTextColor";
            this.label5.Text = "Size L";
            // 
            // PriceSProduct_lbl
            // 
            this.PriceSProduct_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceSProduct_lbl.ForeColor = System.Drawing.Color.Red;
            this.PriceSProduct_lbl.Location = new System.Drawing.Point(95, 40);
            this.PriceSProduct_lbl.Name = "PriceSProduct_lbl";
            this.PriceSProduct_lbl.Size = new System.Drawing.Size(96, 18);
            this.PriceSProduct_lbl.TabIndex = 35;
            this.PriceSProduct_lbl.Text = "0";
            this.PriceSProduct_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(235, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 39;
            this.label4.Tag = "changeTextColor";
            this.label4.Text = "Size M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 37;
            this.label2.Tag = "changeTextColor";
            this.label2.Text = "Size S";
            // 
            // AdminProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCtn);
            this.Name = "AdminProductCard";
            this.Size = new System.Drawing.Size(860, 100);
            this.panelCtn.ResumeLayout(false);
            this.panelCtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Pro)).EndInit();
            this.panelCtn_2.ResumeLayout(false);
            this.panelCtn_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCtn;
        private System.Windows.Forms.PictureBox Picture_Pro;
        private System.Windows.Forms.Label QuantitysizeS_lbl;
        private System.Windows.Forms.Label PriceSProduct_lbl;
        private System.Windows.Forms.Label NameProduct_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_namePro;
        private System.Windows.Forms.Button DeletePro_btn;
        private System.Windows.Forms.Button EditPro_btn;
        private System.Windows.Forms.Label PriceLProduct_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PriceMProduct_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCtn_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label QuantitysizeL_lbl;
        private System.Windows.Forms.Label QuantitysizeM_lbl;
    }
}
