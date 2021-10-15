
namespace LHBeverage.UserControls
{
    partial class ManageCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.title_Cate_lbl = new System.Windows.Forms.Label();
            this.lbl_categortName = new System.Windows.Forms.Label();
            this.AddCate_tb = new System.Windows.Forms.TextBox();
            this.AddCate_btn = new System.Windows.Forms.Button();
            this.ListCate_flowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelManageCategory.SuspendLayout();
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
            this.panelManageCategory.Controls.Add(this.label2);
            this.panelManageCategory.Controls.Add(this.ListCate_flowpanel);
            this.panelManageCategory.Controls.Add(this.label1);
            this.panelManageCategory.Controls.Add(this.panel2);
            this.panelManageCategory.Location = new System.Drawing.Point(0, 0);
            this.panelManageCategory.Name = "panelManageCategory";
            this.panelManageCategory.Size = new System.Drawing.Size(1014, 600);
            this.panelManageCategory.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Category manage page";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.AddCate_btn);
            this.panel2.Controls.Add(this.AddCate_tb);
            this.panel2.Controls.Add(this.lbl_categortName);
            this.panel2.Controls.Add(this.title_Cate_lbl);
            this.panel2.Location = new System.Drawing.Point(49, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 139);
            this.panel2.TabIndex = 3;
            // 
            // title_Cate_lbl
            // 
            this.title_Cate_lbl.AutoSize = true;
            this.title_Cate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Cate_lbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.title_Cate_lbl.Location = new System.Drawing.Point(13, 10);
            this.title_Cate_lbl.Name = "title_Cate_lbl";
            this.title_Cate_lbl.Size = new System.Drawing.Size(150, 22);
            this.title_Cate_lbl.TabIndex = 8;
            this.title_Cate_lbl.Text = "+ Add Category";
            // 
            // lbl_categortName
            // 
            this.lbl_categortName.AutoSize = true;
            this.lbl_categortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categortName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_categortName.Location = new System.Drawing.Point(14, 51);
            this.lbl_categortName.Name = "lbl_categortName";
            this.lbl_categortName.Size = new System.Drawing.Size(108, 17);
            this.lbl_categortName.TabIndex = 11;
            this.lbl_categortName.Text = "Category name:";
            // 
            // AddCate_tb
            // 
            this.AddCate_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddCate_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddCate_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCate_tb.Location = new System.Drawing.Point(128, 51);
            this.AddCate_tb.Name = "AddCate_tb";
            this.AddCate_tb.Size = new System.Drawing.Size(139, 16);
            this.AddCate_tb.TabIndex = 12;
            // 
            // AddCate_btn
            // 
            this.AddCate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddCate_btn.FlatAppearance.BorderSize = 0;
            this.AddCate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCate_btn.ForeColor = System.Drawing.Color.White;
            this.AddCate_btn.Location = new System.Drawing.Point(98, 90);
            this.AddCate_btn.Name = "AddCate_btn";
            this.AddCate_btn.Size = new System.Drawing.Size(97, 33);
            this.AddCate_btn.TabIndex = 13;
            this.AddCate_btn.Text = "Add ";
            this.AddCate_btn.UseVisualStyleBackColor = false;
            this.AddCate_btn.Click += new System.EventHandler(this.AddCate_btn_Click);
            // 
            // ListCate_flowpanel
            // 
            this.ListCate_flowpanel.BackColor = System.Drawing.Color.White;
            this.ListCate_flowpanel.Location = new System.Drawing.Point(49, 257);
            this.ListCate_flowpanel.Name = "ListCate_flowpanel";
            this.ListCate_flowpanel.Size = new System.Drawing.Size(288, 227);
            this.ListCate_flowpanel.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(46, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "List category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelManageCategory);
            this.Name = "ManageCategory";
            this.Size = new System.Drawing.Size(1014, 600);
            this.panelManageCategory.ResumeLayout(false);
            this.panelManageCategory.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManageCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title_Cate_lbl;
        private System.Windows.Forms.TextBox AddCate_tb;
        private System.Windows.Forms.Label lbl_categortName;
        private System.Windows.Forms.Button AddCate_btn;
        private System.Windows.Forms.FlowLayoutPanel ListCate_flowpanel;
        private System.Windows.Forms.Label label2;
    }
}
