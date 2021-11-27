
namespace LHBeverage.UserControls
{
    partial class AdminManageOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageOrder));
            this.Order_FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FilterMonth_Cb = new System.Windows.Forms.ComboBox();
            this.TodayFilter_btn = new System.Windows.Forms.Button();
            this.orderEmpty_panel = new System.Windows.Forms.Panel();
            this.emptyOrder_lbl = new System.Windows.Forms.Label();
            this.OrderSuccessBtn = new System.Windows.Forms.Button();
            this.OrderCancelBtn = new System.Windows.Forms.Button();
            this.AllOrderBtn = new System.Windows.Forms.Button();
            this.orderEmpty_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Order_FlowPanel
            // 
            resources.ApplyResources(this.Order_FlowPanel, "Order_FlowPanel");
            this.Order_FlowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Order_FlowPanel.Name = "Order_FlowPanel";
            // 
            // FilterMonth_Cb
            // 
            resources.ApplyResources(this.FilterMonth_Cb, "FilterMonth_Cb");
            this.FilterMonth_Cb.FormattingEnabled = true;
            this.FilterMonth_Cb.Items.AddRange(new object[] {
            resources.GetString("FilterMonth_Cb.Items"),
            resources.GetString("FilterMonth_Cb.Items1"),
            resources.GetString("FilterMonth_Cb.Items2"),
            resources.GetString("FilterMonth_Cb.Items3"),
            resources.GetString("FilterMonth_Cb.Items4"),
            resources.GetString("FilterMonth_Cb.Items5"),
            resources.GetString("FilterMonth_Cb.Items6"),
            resources.GetString("FilterMonth_Cb.Items7"),
            resources.GetString("FilterMonth_Cb.Items8"),
            resources.GetString("FilterMonth_Cb.Items9"),
            resources.GetString("FilterMonth_Cb.Items10"),
            resources.GetString("FilterMonth_Cb.Items11"),
            resources.GetString("FilterMonth_Cb.Items12")});
            this.FilterMonth_Cb.Name = "FilterMonth_Cb";
            this.FilterMonth_Cb.SelectedIndexChanged += new System.EventHandler(this.FilterMonth_Cb_SelectedIndexChanged);
            // 
            // TodayFilter_btn
            // 
            resources.ApplyResources(this.TodayFilter_btn, "TodayFilter_btn");
            this.TodayFilter_btn.BackColor = System.Drawing.Color.Blue;
            this.TodayFilter_btn.FlatAppearance.BorderSize = 0;
            this.TodayFilter_btn.ForeColor = System.Drawing.Color.White;
            this.TodayFilter_btn.Name = "TodayFilter_btn";
            this.TodayFilter_btn.UseVisualStyleBackColor = false;
            this.TodayFilter_btn.Click += new System.EventHandler(this.TodayFilter_btn_Click);
            // 
            // orderEmpty_panel
            // 
            resources.ApplyResources(this.orderEmpty_panel, "orderEmpty_panel");
            this.orderEmpty_panel.BackColor = System.Drawing.Color.Transparent;
            this.orderEmpty_panel.Controls.Add(this.emptyOrder_lbl);
            this.orderEmpty_panel.Name = "orderEmpty_panel";
            // 
            // emptyOrder_lbl
            // 
            resources.ApplyResources(this.emptyOrder_lbl, "emptyOrder_lbl");
            this.emptyOrder_lbl.Name = "emptyOrder_lbl";
            // 
            // OrderSuccessBtn
            // 
            resources.ApplyResources(this.OrderSuccessBtn, "OrderSuccessBtn");
            this.OrderSuccessBtn.BackColor = System.Drawing.Color.White;
            this.OrderSuccessBtn.FlatAppearance.BorderSize = 0;
            this.OrderSuccessBtn.ForeColor = System.Drawing.Color.Black;
            this.OrderSuccessBtn.Name = "OrderSuccessBtn";
            this.OrderSuccessBtn.UseVisualStyleBackColor = false;
            this.OrderSuccessBtn.Click += new System.EventHandler(this.OrderSuccessBtn_Click);
            // 
            // OrderCancelBtn
            // 
            resources.ApplyResources(this.OrderCancelBtn, "OrderCancelBtn");
            this.OrderCancelBtn.BackColor = System.Drawing.Color.White;
            this.OrderCancelBtn.FlatAppearance.BorderSize = 0;
            this.OrderCancelBtn.ForeColor = System.Drawing.Color.Black;
            this.OrderCancelBtn.Name = "OrderCancelBtn";
            this.OrderCancelBtn.UseVisualStyleBackColor = false;
            this.OrderCancelBtn.Click += new System.EventHandler(this.OrderCancelBtn_Click);
            // 
            // AllOrderBtn
            // 
            resources.ApplyResources(this.AllOrderBtn, "AllOrderBtn");
            this.AllOrderBtn.BackColor = System.Drawing.Color.Orange;
            this.AllOrderBtn.FlatAppearance.BorderSize = 0;
            this.AllOrderBtn.ForeColor = System.Drawing.Color.White;
            this.AllOrderBtn.Name = "AllOrderBtn";
            this.AllOrderBtn.UseVisualStyleBackColor = false;
            this.AllOrderBtn.Click += new System.EventHandler(this.AllOrderBtn_Click);
            // 
            // AdminManageOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AllOrderBtn);
            this.Controls.Add(this.OrderCancelBtn);
            this.Controls.Add(this.OrderSuccessBtn);
            this.Controls.Add(this.orderEmpty_panel);
            this.Controls.Add(this.TodayFilter_btn);
            this.Controls.Add(this.FilterMonth_Cb);
            this.Controls.Add(this.Order_FlowPanel);
            this.Name = "AdminManageOrder";
            this.orderEmpty_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Order_FlowPanel;
        private System.Windows.Forms.ComboBox FilterMonth_Cb;
        private System.Windows.Forms.Button TodayFilter_btn;
        private System.Windows.Forms.Panel orderEmpty_panel;
        private System.Windows.Forms.Label emptyOrder_lbl;
        private System.Windows.Forms.Button OrderSuccessBtn;
        private System.Windows.Forms.Button OrderCancelBtn;
        private System.Windows.Forms.Button AllOrderBtn;
    }
}
