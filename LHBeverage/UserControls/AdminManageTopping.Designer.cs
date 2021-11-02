
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
            this.panelManageCategory = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ListTopping_flowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Category_cb = new System.Windows.Forms.ComboBox();
            this.NameToppings_lbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UpdateCate_btn = new System.Windows.Forms.Button();
            this.AddCate_btn = new System.Windows.Forms.Button();
            this.AddNameTopping_tb = new System.Windows.Forms.TextBox();
            this.lbl_categortName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelManageCategory.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManageCategory
            // 
            this.panelManageCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManageCategory.AutoScroll = true;
            this.panelManageCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.panelManageCategory.Controls.Add(this.panel3);
            this.panelManageCategory.Location = new System.Drawing.Point(0, 0);
            this.panelManageCategory.Name = "panelManageCategory";
            this.panelManageCategory.Size = new System.Drawing.Size(1014, 600);
            this.panelManageCategory.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.ListTopping_flowpanel);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(96, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 551);
            this.panel3.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(329, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 31);
            this.panel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
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
            this.ListTopping_flowpanel.Location = new System.Drawing.Point(329, 39);
            this.ListTopping_flowpanel.Name = "ListTopping_flowpanel";
            this.ListTopping_flowpanel.Size = new System.Drawing.Size(522, 371);
            this.ListTopping_flowpanel.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Category_cb);
            this.panel2.Controls.Add(this.NameToppings_lbl);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.UpdateCate_btn);
            this.panel2.Controls.Add(this.AddCate_btn);
            this.panel2.Controls.Add(this.AddNameTopping_tb);
            this.panel2.Controls.Add(this.lbl_categortName);
            this.panel2.Location = new System.Drawing.Point(4, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 280);
            this.panel2.TabIndex = 3;
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
            this.UpdateCate_btn.Location = new System.Drawing.Point(173, 228);
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
            this.AddCate_btn.Location = new System.Drawing.Point(47, 228);
            this.AddCate_btn.Name = "AddCate_btn";
            this.AddCate_btn.Size = new System.Drawing.Size(97, 33);
            this.AddCate_btn.TabIndex = 13;
            this.AddCate_btn.Text = "Add ";
            this.AddCate_btn.UseVisualStyleBackColor = false;
            this.AddCate_btn.Click += new System.EventHandler(this.AddCate_btn_Click);
            // 
            // AddNameTopping_tb
            // 
            this.AddNameTopping_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddNameTopping_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddNameTopping_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNameTopping_tb.Location = new System.Drawing.Point(47, 171);
            this.AddNameTopping_tb.Name = "AddNameTopping_tb";
            this.AddNameTopping_tb.Size = new System.Drawing.Size(223, 20);
            this.AddNameTopping_tb.TabIndex = 12;
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
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Location = new System.Drawing.Point(832, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(53, 409);
            this.panel5.TabIndex = 26;
            // 
            // AdminManageTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelManageCategory);
            this.Name = "AdminManageTopping";
            this.Size = new System.Drawing.Size(1014, 600);
            this.panelManageCategory.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManageCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel ListTopping_flowpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button UpdateCate_btn;
        private System.Windows.Forms.Button AddCate_btn;
        private System.Windows.Forms.TextBox AddNameTopping_tb;
        private System.Windows.Forms.Label lbl_categortName;
        private System.Windows.Forms.Label NameToppings_lbl;
        private System.Windows.Forms.ComboBox Category_cb;
        private System.Windows.Forms.Panel panel5;
    }
}
