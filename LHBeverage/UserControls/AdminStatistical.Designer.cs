
namespace LHBeverage.UserControls
{
    partial class AdminStatistical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStatistical));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Order_btn = new System.Windows.Forms.Button();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOrder = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalProductSold_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalProductReject_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RevenueBtn = new System.Windows.Forms.Button();
            this.panelCtn_Root = new System.Windows.Forms.Panel();
            this.panelOrderSold_Cancelled = new System.Windows.Forms.Panel();
            this.chartRatioOrder = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.total_orderCancelled = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.total_orderSold = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelRevenue = new System.Windows.Forms.Panel();
            this.total_earningMonth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.total_earningDay = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.total_earning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderSold_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCtn_Root.SuspendLayout();
            this.panelOrderSold_Cancelled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRatioOrder)).BeginInit();
            this.panelRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Order_btn
            // 
            resources.ApplyResources(this.Order_btn, "Order_btn");
            this.Order_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Order_btn.FlatAppearance.BorderSize = 0;
            this.Order_btn.ForeColor = System.Drawing.Color.White;
            this.Order_btn.Name = "Order_btn";
            this.Order_btn.UseVisualStyleBackColor = false;
            this.Order_btn.Click += new System.EventHandler(this.Order_btn_Click);
            // 
            // chartRevenue
            // 
            resources.ApplyResources(this.chartRevenue, "chartRevenue");
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chartRevenue.Series.Add(series1);
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Revenue";
            this.chartRevenue.Titles.Add(title1);
            // 
            // chartOrder
            // 
            resources.ApplyResources(this.chartOrder, "chartOrder");
            this.chartOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chartOrder.BackSecondaryColor = System.Drawing.Color.White;
            this.chartOrder.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chartOrder.BorderSkin.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chartOrder.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartOrder.Legends.Add(legend2);
            this.chartOrder.Name = "chartOrder";
            this.chartOrder.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartOrder.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MediumTurquoise};
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Order";
            this.chartOrder.Series.Add(series2);
            title2.BackColor = System.Drawing.Color.White;
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Orders";
            this.chartOrder.Titles.Add(title2);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.TotalProductSold_lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // TotalProductSold_lbl
            // 
            resources.ApplyResources(this.TotalProductSold_lbl, "TotalProductSold_lbl");
            this.TotalProductSold_lbl.ForeColor = System.Drawing.Color.White;
            this.TotalProductSold_lbl.Name = "TotalProductSold_lbl";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(82)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.TotalProductReject_lbl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Name = "panel2";
            // 
            // TotalProductReject_lbl
            // 
            resources.ApplyResources(this.TotalProductReject_lbl, "TotalProductReject_lbl");
            this.TotalProductReject_lbl.ForeColor = System.Drawing.Color.White;
            this.TotalProductReject_lbl.Name = "TotalProductReject_lbl";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // RevenueBtn
            // 
            resources.ApplyResources(this.RevenueBtn, "RevenueBtn");
            this.RevenueBtn.BackColor = System.Drawing.Color.DeepPink;
            this.RevenueBtn.FlatAppearance.BorderSize = 0;
            this.RevenueBtn.ForeColor = System.Drawing.Color.White;
            this.RevenueBtn.Name = "RevenueBtn";
            this.RevenueBtn.UseVisualStyleBackColor = false;
            this.RevenueBtn.Click += new System.EventHandler(this.RevenueBtn_Click);
            // 
            // panelCtn_Root
            // 
            resources.ApplyResources(this.panelCtn_Root, "panelCtn_Root");
            this.panelCtn_Root.BackColor = System.Drawing.Color.Transparent;
            this.panelCtn_Root.Controls.Add(this.chartOrder);
            this.panelCtn_Root.Name = "panelCtn_Root";
            // 
            // panelOrderSold_Cancelled
            // 
            resources.ApplyResources(this.panelOrderSold_Cancelled, "panelOrderSold_Cancelled");
            this.panelOrderSold_Cancelled.BackColor = System.Drawing.Color.White;
            this.panelOrderSold_Cancelled.Controls.Add(this.chartRatioOrder);
            this.panelOrderSold_Cancelled.Controls.Add(this.total_orderCancelled);
            this.panelOrderSold_Cancelled.Controls.Add(this.label6);
            this.panelOrderSold_Cancelled.Controls.Add(this.total_orderSold);
            this.panelOrderSold_Cancelled.Controls.Add(this.label9);
            this.panelOrderSold_Cancelled.Name = "panelOrderSold_Cancelled";
            // 
            // chartRatioOrder
            // 
            resources.ApplyResources(this.chartRatioOrder, "chartRatioOrder");
            chartArea3.Name = "ChartArea1";
            this.chartRatioOrder.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRatioOrder.Legends.Add(legend3);
            this.chartRatioOrder.Name = "chartRatioOrder";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "ratioOrder";
            this.chartRatioOrder.Series.Add(series3);
            title3.Name = "Ratio Order";
            this.chartRatioOrder.Titles.Add(title3);
            // 
            // total_orderCancelled
            // 
            resources.ApplyResources(this.total_orderCancelled, "total_orderCancelled");
            this.total_orderCancelled.ForeColor = System.Drawing.Color.DeepPink;
            this.total_orderCancelled.Name = "total_orderCancelled";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Name = "label6";
            // 
            // total_orderSold
            // 
            resources.ApplyResources(this.total_orderSold, "total_orderSold");
            this.total_orderSold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.total_orderSold.Name = "total_orderSold";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Name = "label9";
            // 
            // panelRevenue
            // 
            resources.ApplyResources(this.panelRevenue, "panelRevenue");
            this.panelRevenue.BackColor = System.Drawing.Color.White;
            this.panelRevenue.Controls.Add(this.total_earningMonth);
            this.panelRevenue.Controls.Add(this.label7);
            this.panelRevenue.Controls.Add(this.total_earningDay);
            this.panelRevenue.Controls.Add(this.panel4);
            this.panelRevenue.Controls.Add(this.label4);
            this.panelRevenue.Controls.Add(this.total_earning);
            this.panelRevenue.Controls.Add(this.label2);
            this.panelRevenue.Controls.Add(this.chartRevenue);
            this.panelRevenue.Name = "panelRevenue";
            // 
            // total_earningMonth
            // 
            resources.ApplyResources(this.total_earningMonth, "total_earningMonth");
            this.total_earningMonth.ForeColor = System.Drawing.Color.DeepPink;
            this.total_earningMonth.Name = "total_earningMonth";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Name = "label7";
            // 
            // total_earningDay
            // 
            resources.ApplyResources(this.total_earningDay, "total_earningDay");
            this.total_earningDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.total_earningDay.Name = "total_earningDay";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Name = "panel4";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Name = "label4";
            // 
            // total_earning
            // 
            resources.ApplyResources(this.total_earning, "total_earning");
            this.total_earning.ForeColor = System.Drawing.Color.Aqua;
            this.total_earning.Name = "total_earning";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // OrderSold_btn
            // 
            resources.ApplyResources(this.OrderSold_btn, "OrderSold_btn");
            this.OrderSold_btn.BackColor = System.Drawing.Color.Blue;
            this.OrderSold_btn.FlatAppearance.BorderSize = 0;
            this.OrderSold_btn.ForeColor = System.Drawing.Color.White;
            this.OrderSold_btn.Name = "OrderSold_btn";
            this.OrderSold_btn.UseVisualStyleBackColor = false;
            this.OrderSold_btn.Click += new System.EventHandler(this.OrderSold_btn_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // AdminStatistical
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRevenue);
            this.Controls.Add(this.panelOrderSold_Cancelled);
            this.Controls.Add(this.panelCtn_Root);
            this.Controls.Add(this.OrderSold_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Order_btn);
            this.Controls.Add(this.RevenueBtn);
            this.Name = "AdminStatistical";
            this.Load += new System.EventHandler(this.AdminStatistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCtn_Root.ResumeLayout(false);
            this.panelOrderSold_Cancelled.ResumeLayout(false);
            this.panelOrderSold_Cancelled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRatioOrder)).EndInit();
            this.panelRevenue.ResumeLayout(false);
            this.panelRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Order_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalProductSold_lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalProductReject_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RevenueBtn;
        private System.Windows.Forms.Panel panelCtn_Root;
        private System.Windows.Forms.Panel panelRevenue;
        private System.Windows.Forms.Label total_earning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OrderSold_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total_earningMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label total_earningDay;
        private System.Windows.Forms.Panel panelOrderSold_Cancelled;
        private System.Windows.Forms.Label total_orderCancelled;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label total_orderSold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRatioOrder;
    }
}
