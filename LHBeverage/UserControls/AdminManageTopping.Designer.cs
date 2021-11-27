
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageTopping));
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
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Name = "panel5";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // ListTopping_flowpanel
            // 
            resources.ApplyResources(this.ListTopping_flowpanel, "ListTopping_flowpanel");
            this.ListTopping_flowpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListTopping_flowpanel.Name = "ListTopping_flowpanel";
            // 
            // panelAddTopping
            // 
            resources.ApplyResources(this.panelAddTopping, "panelAddTopping");
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
            this.panelAddTopping.Name = "panelAddTopping";
            // 
            // toppingPrice_lbl
            // 
            resources.ApplyResources(this.toppingPrice_lbl, "toppingPrice_lbl");
            this.toppingPrice_lbl.ForeColor = System.Drawing.Color.Black;
            this.toppingPrice_lbl.Name = "toppingPrice_lbl";
            // 
            // PriceTopping_tb
            // 
            resources.ApplyResources(this.PriceTopping_tb, "PriceTopping_tb");
            this.PriceTopping_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PriceTopping_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTopping_tb.Name = "PriceTopping_tb";
            // 
            // Category_cb
            // 
            resources.ApplyResources(this.Category_cb, "Category_cb");
            this.Category_cb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Category_cb.FormattingEnabled = true;
            this.Category_cb.Name = "Category_cb";
            this.Category_cb.SelectedIndexChanged += new System.EventHandler(this.Category_cb_SelectedIndexChanged);
            // 
            // NameToppings_lbl
            // 
            resources.ApplyResources(this.NameToppings_lbl, "NameToppings_lbl");
            this.NameToppings_lbl.ForeColor = System.Drawing.Color.Black;
            this.NameToppings_lbl.Name = "NameToppings_lbl";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Name = "panel4";
            // 
            // UpdateCate_btn
            // 
            resources.ApplyResources(this.UpdateCate_btn, "UpdateCate_btn");
            this.UpdateCate_btn.BackColor = System.Drawing.Color.Orange;
            this.UpdateCate_btn.FlatAppearance.BorderSize = 0;
            this.UpdateCate_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateCate_btn.Name = "UpdateCate_btn";
            this.UpdateCate_btn.UseVisualStyleBackColor = false;
            this.UpdateCate_btn.Click += new System.EventHandler(this.UpdateCate_btn_Click);
            // 
            // AddCate_btn
            // 
            resources.ApplyResources(this.AddCate_btn, "AddCate_btn");
            this.AddCate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddCate_btn.FlatAppearance.BorderSize = 0;
            this.AddCate_btn.ForeColor = System.Drawing.Color.White;
            this.AddCate_btn.Name = "AddCate_btn";
            this.AddCate_btn.UseVisualStyleBackColor = false;
            this.AddCate_btn.Click += new System.EventHandler(this.AddCate_btn_Click);
            // 
            // NameTopping_tb
            // 
            resources.ApplyResources(this.NameTopping_tb, "NameTopping_tb");
            this.NameTopping_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameTopping_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTopping_tb.Name = "NameTopping_tb";
            // 
            // lbl_categortName
            // 
            resources.ApplyResources(this.lbl_categortName, "lbl_categortName");
            this.lbl_categortName.ForeColor = System.Drawing.Color.Black;
            this.lbl_categortName.Name = "lbl_categortName";
            // 
            // AdminManageTopping
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListTopping_flowpanel);
            this.Controls.Add(this.panelAddTopping);
            this.Name = "AdminManageTopping";
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
