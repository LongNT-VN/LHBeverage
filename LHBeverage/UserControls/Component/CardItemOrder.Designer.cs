
namespace LHBeverage.UserControls.Component
{
    partial class CardItemOrder
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.amountitemOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.nameitem_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // amountitemOrder
            // 
            this.amountitemOrder.AutoSize = true;
            this.amountitemOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountitemOrder.ForeColor = System.Drawing.Color.DarkGray;
            this.amountitemOrder.Location = new System.Drawing.Point(310, 37);
            this.amountitemOrder.Name = "amountitemOrder";
            this.amountitemOrder.Size = new System.Drawing.Size(16, 18);
            this.amountitemOrder.TabIndex = 8;
            this.amountitemOrder.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(233, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantity";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_lbl.ForeColor = System.Drawing.Color.Red;
            this.Price_lbl.Location = new System.Drawing.Point(131, 71);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(75, 18);
            this.Price_lbl.TabIndex = 6;
            this.Price_lbl.Text = "TotalPrice";
            // 
            // nameitem_lbl
            // 
            this.nameitem_lbl.AutoSize = true;
            this.nameitem_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameitem_lbl.ForeColor = System.Drawing.Color.Black;
            this.nameitem_lbl.Location = new System.Drawing.Point(131, 1);
            this.nameitem_lbl.Name = "nameitem_lbl";
            this.nameitem_lbl.Size = new System.Drawing.Size(75, 17);
            this.nameitem_lbl.TabIndex = 5;
            this.nameitem_lbl.Text = "Name Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(131, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(289, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Size";
            // 
            // CardItemOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountitemOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.nameitem_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CardItemOrder";
            this.Size = new System.Drawing.Size(331, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label amountitemOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Label nameitem_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
