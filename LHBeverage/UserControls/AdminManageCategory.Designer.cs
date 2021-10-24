
namespace LHBeverage.UserControls
{
    partial class AdminManageCategory
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
            this.label2 = new System.Windows.Forms.Label();
            this.ListCate_flowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddCate_btn = new System.Windows.Forms.Button();
            this.AddCate_tb = new System.Windows.Forms.TextBox();
            this.lbl_categortName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UpdateCate_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelManageCategory.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panelManageCategory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(318, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "List category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListCate_flowpanel
            // 
            this.ListCate_flowpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListCate_flowpanel.AutoScroll = true;
            this.ListCate_flowpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListCate_flowpanel.Location = new System.Drawing.Point(325, 48);
            this.ListCate_flowpanel.Name = "ListCate_flowpanel";
            this.ListCate_flowpanel.Size = new System.Drawing.Size(522, 371);
            this.ListCate_flowpanel.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.UpdateCate_btn);
            this.panel2.Controls.Add(this.AddCate_btn);
            this.panel2.Controls.Add(this.AddCate_tb);
            this.panel2.Controls.Add(this.lbl_categortName);
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 200);
            this.panel2.TabIndex = 3;
            // 
            // AddCate_btn
            // 
            this.AddCate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddCate_btn.FlatAppearance.BorderSize = 0;
            this.AddCate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCate_btn.ForeColor = System.Drawing.Color.White;
            this.AddCate_btn.Location = new System.Drawing.Point(38, 155);
            this.AddCate_btn.Name = "AddCate_btn";
            this.AddCate_btn.Size = new System.Drawing.Size(97, 33);
            this.AddCate_btn.TabIndex = 13;
            this.AddCate_btn.Text = "Add ";
            this.AddCate_btn.UseVisualStyleBackColor = false;
            this.AddCate_btn.Click += new System.EventHandler(this.AddCate_btn_Click);
            // 
            // AddCate_tb
            // 
            this.AddCate_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddCate_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddCate_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCate_tb.Location = new System.Drawing.Point(38, 97);
            this.AddCate_tb.Name = "AddCate_tb";
            this.AddCate_tb.Size = new System.Drawing.Size(223, 20);
            this.AddCate_tb.TabIndex = 12;
            // 
            // lbl_categortName
            // 
            this.lbl_categortName.AutoSize = true;
            this.lbl_categortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categortName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_categortName.Location = new System.Drawing.Point(35, 59);
            this.lbl_categortName.Name = "lbl_categortName";
            this.lbl_categortName.Size = new System.Drawing.Size(113, 18);
            this.lbl_categortName.TabIndex = 11;
            this.lbl_categortName.Text = "Category name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 28);
            this.panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(625, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Action";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.ListCate_flowpanel);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(96, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 548);
            this.panel3.TabIndex = 25;
            // 
            // UpdateCate_btn
            // 
            this.UpdateCate_btn.BackColor = System.Drawing.Color.Orange;
            this.UpdateCate_btn.FlatAppearance.BorderSize = 0;
            this.UpdateCate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCate_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateCate_btn.Location = new System.Drawing.Point(164, 155);
            this.UpdateCate_btn.Name = "UpdateCate_btn";
            this.UpdateCate_btn.Size = new System.Drawing.Size(97, 33);
            this.UpdateCate_btn.TabIndex = 17;
            this.UpdateCate_btn.Text = "Update";
            this.UpdateCate_btn.UseVisualStyleBackColor = false;
            this.UpdateCate_btn.Click += new System.EventHandler(this.UpdateCate_btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 31);
            this.panel4.TabIndex = 25;
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelManageCategory);
            this.Name = "ManageCategory";
            this.Size = new System.Drawing.Size(1014, 600);
            this.panelManageCategory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManageCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AddCate_tb;
        private System.Windows.Forms.Label lbl_categortName;
        private System.Windows.Forms.Button AddCate_btn;
        private System.Windows.Forms.FlowLayoutPanel ListCate_flowpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button UpdateCate_btn;
    }
}
