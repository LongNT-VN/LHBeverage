
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
            this.Order_FlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Order_FlowPanel.AutoScroll = true;
            this.Order_FlowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Order_FlowPanel.Location = new System.Drawing.Point(0, 72);
            this.Order_FlowPanel.Name = "Order_FlowPanel";
            this.Order_FlowPanel.Size = new System.Drawing.Size(1014, 488);
            this.Order_FlowPanel.TabIndex = 0;
            // 
            // FilterMonth_Cb
            // 
            this.FilterMonth_Cb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FilterMonth_Cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterMonth_Cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterMonth_Cb.FormattingEnabled = true;
            this.FilterMonth_Cb.Items.AddRange(new object[] {
            "All",
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.FilterMonth_Cb.Location = new System.Drawing.Point(22, 39);
            this.FilterMonth_Cb.Name = "FilterMonth_Cb";
            this.FilterMonth_Cb.Size = new System.Drawing.Size(217, 26);
            this.FilterMonth_Cb.TabIndex = 2;
            this.FilterMonth_Cb.SelectedIndexChanged += new System.EventHandler(this.FilterMonth_Cb_SelectedIndexChanged);
            // 
            // TodayFilter_btn
            // 
            this.TodayFilter_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TodayFilter_btn.BackColor = System.Drawing.Color.Blue;
            this.TodayFilter_btn.FlatAppearance.BorderSize = 0;
            this.TodayFilter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodayFilter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayFilter_btn.ForeColor = System.Drawing.Color.White;
            this.TodayFilter_btn.Location = new System.Drawing.Point(255, 39);
            this.TodayFilter_btn.Name = "TodayFilter_btn";
            this.TodayFilter_btn.Size = new System.Drawing.Size(96, 27);
            this.TodayFilter_btn.TabIndex = 3;
            this.TodayFilter_btn.Text = "Today";
            this.TodayFilter_btn.UseVisualStyleBackColor = false;
            this.TodayFilter_btn.Click += new System.EventHandler(this.TodayFilter_btn_Click);
            // 
            // orderEmpty_panel
            // 
            this.orderEmpty_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderEmpty_panel.BackColor = System.Drawing.Color.Transparent;
            this.orderEmpty_panel.Controls.Add(this.emptyOrder_lbl);
            this.orderEmpty_panel.Location = new System.Drawing.Point(1, 70);
            this.orderEmpty_panel.Name = "orderEmpty_panel";
            this.orderEmpty_panel.Size = new System.Drawing.Size(1018, 509);
            this.orderEmpty_panel.TabIndex = 16;
            this.orderEmpty_panel.Visible = false;
            // 
            // emptyOrder_lbl
            // 
            this.emptyOrder_lbl.AutoSize = true;
            this.emptyOrder_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyOrder_lbl.Location = new System.Drawing.Point(475, 141);
            this.emptyOrder_lbl.Name = "emptyOrder_lbl";
            this.emptyOrder_lbl.Size = new System.Drawing.Size(133, 31);
            this.emptyOrder_lbl.TabIndex = 16;
            this.emptyOrder_lbl.Text = "No orders";
            // 
            // OrderSuccessBtn
            // 
            this.OrderSuccessBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrderSuccessBtn.BackColor = System.Drawing.Color.White;
            this.OrderSuccessBtn.FlatAppearance.BorderSize = 0;
            this.OrderSuccessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderSuccessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSuccessBtn.ForeColor = System.Drawing.Color.Black;
            this.OrderSuccessBtn.Location = new System.Drawing.Point(174, 4);
            this.OrderSuccessBtn.Name = "OrderSuccessBtn";
            this.OrderSuccessBtn.Size = new System.Drawing.Size(133, 27);
            this.OrderSuccessBtn.TabIndex = 17;
            this.OrderSuccessBtn.Text = "Order Successfull";
            this.OrderSuccessBtn.UseVisualStyleBackColor = false;
            this.OrderSuccessBtn.Click += new System.EventHandler(this.OrderSuccessBtn_Click);
            // 
            // OrderCancelBtn
            // 
            this.OrderCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrderCancelBtn.BackColor = System.Drawing.Color.White;
            this.OrderCancelBtn.FlatAppearance.BorderSize = 0;
            this.OrderCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCancelBtn.ForeColor = System.Drawing.Color.Black;
            this.OrderCancelBtn.Location = new System.Drawing.Point(324, 4);
            this.OrderCancelBtn.Name = "OrderCancelBtn";
            this.OrderCancelBtn.Size = new System.Drawing.Size(133, 27);
            this.OrderCancelBtn.TabIndex = 18;
            this.OrderCancelBtn.Text = "Order Cancelled";
            this.OrderCancelBtn.UseVisualStyleBackColor = false;
            this.OrderCancelBtn.Click += new System.EventHandler(this.OrderCancelBtn_Click);
            // 
            // AllOrderBtn
            // 
            this.AllOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AllOrderBtn.BackColor = System.Drawing.Color.Orange;
            this.AllOrderBtn.FlatAppearance.BorderSize = 0;
            this.AllOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOrderBtn.ForeColor = System.Drawing.Color.White;
            this.AllOrderBtn.Location = new System.Drawing.Point(22, 4);
            this.AllOrderBtn.Name = "AllOrderBtn";
            this.AllOrderBtn.Size = new System.Drawing.Size(133, 27);
            this.AllOrderBtn.TabIndex = 19;
            this.AllOrderBtn.Text = "All Order ";
            this.AllOrderBtn.UseVisualStyleBackColor = false;
            this.AllOrderBtn.Click += new System.EventHandler(this.AllOrderBtn_Click);
            // 
            // AdminManageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AllOrderBtn);
            this.Controls.Add(this.OrderCancelBtn);
            this.Controls.Add(this.OrderSuccessBtn);
            this.Controls.Add(this.orderEmpty_panel);
            this.Controls.Add(this.TodayFilter_btn);
            this.Controls.Add(this.FilterMonth_Cb);
            this.Controls.Add(this.Order_FlowPanel);
            this.Name = "AdminManageOrder";
            this.Size = new System.Drawing.Size(1014, 600);
            this.orderEmpty_panel.ResumeLayout(false);
            this.orderEmpty_panel.PerformLayout();
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
