﻿
namespace LHBeverage.UserControls
{
    partial class AdminManageTopping
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ListTopping_flowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAddTopping = new System.Windows.Forms.Panel();
            this.toppingPrice_lbl = new System.Windows.Forms.Label();
            this.PriceTopping_tb = new System.Windows.Forms.TextBox();
            this.Category_cb = new System.Windows.Forms.ComboBox();
            this.NameToppings_lbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UpdateCate_btn = new System.Windows.Forms.Button();
            this.AddCate_btn = new System.Windows.Forms.Button();
            this.NameTopping_tb = new System.Windows.Forms.TextBox();
            this.lbl_categortName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelAddTopping.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(930, 95);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(53, 417);
            this.panel5.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(427, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 31);
            this.panel1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "List Toppings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListTopping_flowpanel
            // 
            this.ListTopping_flowpanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ListTopping_flowpanel.AutoScroll = true;
            this.ListTopping_flowpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListTopping_flowpanel.Location = new System.Drawing.Point(427, 134);
            this.ListTopping_flowpanel.Name = "ListTopping_flowpanel";
            this.ListTopping_flowpanel.Size = new System.Drawing.Size(522, 371);
            this.ListTopping_flowpanel.TabIndex = 32;
            // 
            // panelAddTopping
            // 
            this.panelAddTopping.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAddTopping.BackColor = System.Drawing.Color.White;
            this.panelAddTopping.Controls.Add(this.toppingPrice_lbl);
            this.panelAddTopping.Controls.Add(this.PriceTopping_tb);
            this.panelAddTopping.Controls.Add(this.Category_cb);
            this.panelAddTopping.Controls.Add(this.NameToppings_lbl);
            this.panelAddTopping.Controls.Add(this.panel4);
            this.panelAddTopping.Controls.Add(this.UpdateCate_btn);
            this.panelAddTopping.Controls.Add(this.AddCate_btn);
            this.panelAddTopping.Controls.Add(this.NameTopping_tb);
            this.panelAddTopping.Controls.Add(this.lbl_categortName);
            this.panelAddTopping.Location = new System.Drawing.Point(102, 104);
            this.panelAddTopping.Name = "panelAddTopping";
            this.panelAddTopping.Size = new System.Drawing.Size(320, 400);
            this.panelAddTopping.TabIndex = 31;
            // 
            // toppingPrice_lbl
            // 
            this.toppingPrice_lbl.AutoSize = true;
            this.toppingPrice_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingPrice_lbl.ForeColor = System.Drawing.Color.Black;
            this.toppingPrice_lbl.Location = new System.Drawing.Point(44, 223);
            this.toppingPrice_lbl.Name = "toppingPrice_lbl";
            this.toppingPrice_lbl.Size = new System.Drawing.Size(115, 18);
            this.toppingPrice_lbl.TabIndex = 29;
            this.toppingPrice_lbl.Text = "Topping price:";
            // 
            // PriceTopping_tb
            // 
            this.PriceTopping_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PriceTopping_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTopping_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTopping_tb.Location = new System.Drawing.Point(47, 263);
            this.PriceTopping_tb.Name = "PriceTopping_tb";
            this.PriceTopping_tb.Size = new System.Drawing.Size(223, 20);
            this.PriceTopping_tb.TabIndex = 28;
            // 
            // Category_cb
            // 
            this.Category_cb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Category_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_cb.FormattingEnabled = true;
            this.Category_cb.Location = new System.Drawing.Point(47, 85);
            this.Category_cb.Name = "Category_cb";
            this.Category_cb.Size = new System.Drawing.Size(223, 23);
            this.Category_cb.TabIndex = 27;
            this.Category_cb.SelectedIndexChanged += new System.EventHandler(this.Category_cb_SelectedIndexChanged);
            // 
            // NameToppings_lbl
            // 
            this.NameToppings_lbl.AutoSize = true;
            this.NameToppings_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameToppings_lbl.ForeColor = System.Drawing.Color.Black;
            this.NameToppings_lbl.Location = new System.Drawing.Point(44, 131);
            this.NameToppings_lbl.Name = "NameToppings_lbl";
            this.NameToppings_lbl.Size = new System.Drawing.Size(119, 18);
            this.NameToppings_lbl.TabIndex = 26;
            this.NameToppings_lbl.Text = "Topping name:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 31);
            this.panel4.TabIndex = 25;
            // 
            // UpdateCate_btn
            // 
            this.UpdateCate_btn.BackColor = System.Drawing.Color.Orange;
            this.UpdateCate_btn.FlatAppearance.BorderSize = 0;
            this.UpdateCate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCate_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateCate_btn.Location = new System.Drawing.Point(173, 331);
            this.UpdateCate_btn.Name = "UpdateCate_btn";
            this.UpdateCate_btn.Size = new System.Drawing.Size(97, 33);
            this.UpdateCate_btn.TabIndex = 17;
            this.UpdateCate_btn.Text = "Update";
            this.UpdateCate_btn.UseVisualStyleBackColor = false;
            this.UpdateCate_btn.Click += new System.EventHandler(this.UpdateCate_btn_Click);
            // 
            // AddCate_btn
            // 
            this.AddCate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddCate_btn.FlatAppearance.BorderSize = 0;
            this.AddCate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCate_btn.ForeColor = System.Drawing.Color.White;
            this.AddCate_btn.Location = new System.Drawing.Point(47, 331);
            this.AddCate_btn.Name = "AddCate_btn";
            this.AddCate_btn.Size = new System.Drawing.Size(97, 33);
            this.AddCate_btn.TabIndex = 13;
            this.AddCate_btn.Text = "Add ";
            this.AddCate_btn.UseVisualStyleBackColor = false;
            this.AddCate_btn.Click += new System.EventHandler(this.AddCate_btn_Click);
            // 
            // NameTopping_tb
            // 
            this.NameTopping_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameTopping_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTopping_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTopping_tb.Location = new System.Drawing.Point(47, 171);
            this.NameTopping_tb.Name = "NameTopping_tb";
            this.NameTopping_tb.Size = new System.Drawing.Size(223, 20);
            this.NameTopping_tb.TabIndex = 12;
            // 
            // lbl_categortName
            // 
            this.lbl_categortName.AutoSize = true;
            this.lbl_categortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categortName.ForeColor = System.Drawing.Color.Black;
            this.lbl_categortName.Location = new System.Drawing.Point(44, 47);
            this.lbl_categortName.Name = "lbl_categortName";
            this.lbl_categortName.Size = new System.Drawing.Size(81, 18);
            this.lbl_categortName.TabIndex = 11;
            this.lbl_categortName.Text = "Category:";
            // 
            // AdminManageTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListTopping_flowpanel);
            this.Controls.Add(this.panelAddTopping);
            this.Name = "AdminManageTopping";
            this.Size = new System.Drawing.Size(1014, 600);
            this.panel1.ResumeLayout(false);
            this.panelAddTopping.ResumeLayout(false);
            this.panelAddTopping.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel ListTopping_flowpanel;
        private System.Windows.Forms.Panel panelAddTopping;
        private System.Windows.Forms.Label toppingPrice_lbl;
        private System.Windows.Forms.TextBox PriceTopping_tb;
        private System.Windows.Forms.ComboBox Category_cb;
        private System.Windows.Forms.Label NameToppings_lbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button UpdateCate_btn;
        private System.Windows.Forms.Button AddCate_btn;
        private System.Windows.Forms.TextBox NameTopping_tb;
        private System.Windows.Forms.Label lbl_categortName;
    }
}
