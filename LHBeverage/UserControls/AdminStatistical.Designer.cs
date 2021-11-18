
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStatistical));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Order_btn = new System.Windows.Forms.Button();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOrder = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalProductSold_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalProductReject_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RevenueBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OrderSold_btn = new System.Windows.Forms.Button();
            this.panelRevenue = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.total_earning = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.total_earningDay = new System.Windows.Forms.Label();
            this.total_earningMonth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelOrderSold_Cancelled = new System.Windows.Forms.Panel();
            this.total_orderCancelled = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.total_orderSold = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chartRatioOrder = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelRevenue.SuspendLayout();
            this.panelOrderSold_Cancelled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRatioOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // Order_btn
            // 
            this.Order_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Order_btn.FlatAppearance.BorderSize = 0;
            this.Order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_btn.ForeColor = System.Drawing.Color.White;
            this.Order_btn.Location = new System.Drawing.Point(104, 0);
            this.Order_btn.Name = "Order_btn";
            this.Order_btn.Size = new System.Drawing.Size(166, 23);
            this.Order_btn.TabIndex = 0;
            this.Order_btn.Text = "Order Statistic";
            this.Order_btn.UseVisualStyleBackColor = false;
            this.Order_btn.Click += new System.EventHandler(this.Order_btn_Click);
            // 
            // chartRevenue
            // 
            this.chartRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend7);
            this.chartRevenue.Location = new System.Drawing.Point(407, 3);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Legend = "Legend1";
            series7.Name = "Revenue";
            this.chartRevenue.Series.Add(series7);
            this.chartRevenue.Size = new System.Drawing.Size(543, 417);
            this.chartRevenue.TabIndex = 2;
            this.chartRevenue.Text = "chart1";
            title7.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title7.Name = "Title1";
            title7.Text = "Revenue";
            this.chartRevenue.Titles.Add(title7);
            // 
            // chartOrder
            // 
            this.chartOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chartOrder.BackSecondaryColor = System.Drawing.Color.White;
            this.chartOrder.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chartOrder.BorderSkin.BorderWidth = 0;
            chartArea8.Name = "ChartArea1";
            this.chartOrder.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartOrder.Legends.Add(legend8);
            this.chartOrder.Location = new System.Drawing.Point(90, 18);
            this.chartOrder.Name = "chartOrder";
            this.chartOrder.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartOrder.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MediumTurquoise};
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Order";
            this.chartOrder.Series.Add(series8);
            this.chartOrder.Size = new System.Drawing.Size(869, 363);
            this.chartOrder.TabIndex = 3;
            this.chartOrder.Text = "chart1";
            title8.BackColor = System.Drawing.Color.White;
            title8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title8.Name = "Title1";
            title8.Text = "Orders";
            this.chartOrder.Titles.Add(title8);
            this.chartOrder.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRODUCTS SOLD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.TotalProductSold_lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(206, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 112);
            this.panel1.TabIndex = 5;
            // 
            // TotalProductSold_lbl
            // 
            this.TotalProductSold_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalProductSold_lbl.ForeColor = System.Drawing.Color.White;
            this.TotalProductSold_lbl.Location = new System.Drawing.Point(73, 21);
            this.TotalProductSold_lbl.Name = "TotalProductSold_lbl";
            this.TotalProductSold_lbl.Size = new System.Drawing.Size(162, 45);
            this.TotalProductSold_lbl.TabIndex = 5;
            this.TotalProductSold_lbl.Text = "0";
            this.TotalProductSold_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(82)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.TotalProductReject_lbl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(552, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 112);
            this.panel2.TabIndex = 6;
            // 
            // TotalProductReject_lbl
            // 
            this.TotalProductReject_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalProductReject_lbl.ForeColor = System.Drawing.Color.White;
            this.TotalProductReject_lbl.Location = new System.Drawing.Point(67, 22);
            this.TotalProductReject_lbl.Name = "TotalProductReject_lbl";
            this.TotalProductReject_lbl.Size = new System.Drawing.Size(200, 38);
            this.TotalProductReject_lbl.TabIndex = 5;
            this.TotalProductReject_lbl.Text = "0";
            this.TotalProductReject_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRODUCTS REJECTED";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // RevenueBtn
            // 
            this.RevenueBtn.BackColor = System.Drawing.Color.DeepPink;
            this.RevenueBtn.FlatAppearance.BorderSize = 0;
            this.RevenueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevenueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenueBtn.ForeColor = System.Drawing.Color.White;
            this.RevenueBtn.Location = new System.Drawing.Point(14, 0);
            this.RevenueBtn.Name = "RevenueBtn";
            this.RevenueBtn.Size = new System.Drawing.Size(84, 24);
            this.RevenueBtn.TabIndex = 7;
            this.RevenueBtn.Text = "Revenue";
            this.RevenueBtn.UseVisualStyleBackColor = false;
            this.RevenueBtn.Click += new System.EventHandler(this.RevenueBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panelOrderSold_Cancelled);
            this.panel3.Controls.Add(this.panelRevenue);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.chartOrder);
            this.panel3.Location = new System.Drawing.Point(11, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 570);
            this.panel3.TabIndex = 8;
            // 
            // OrderSold_btn
            // 
            this.OrderSold_btn.BackColor = System.Drawing.Color.Blue;
            this.OrderSold_btn.FlatAppearance.BorderSize = 0;
            this.OrderSold_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderSold_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSold_btn.ForeColor = System.Drawing.Color.White;
            this.OrderSold_btn.Location = new System.Drawing.Point(276, 0);
            this.OrderSold_btn.Name = "OrderSold_btn";
            this.OrderSold_btn.Size = new System.Drawing.Size(213, 24);
            this.OrderSold_btn.TabIndex = 8;
            this.OrderSold_btn.Text = "Order solded And Order cancelled";
            this.OrderSold_btn.UseVisualStyleBackColor = false;
            this.OrderSold_btn.Click += new System.EventHandler(this.OrderSold_btn_Click);
            // 
            // panelRevenue
            // 
            this.panelRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRevenue.Controls.Add(this.total_earningMonth);
            this.panelRevenue.Controls.Add(this.label7);
            this.panelRevenue.Controls.Add(this.total_earningDay);
            this.panelRevenue.Controls.Add(this.panel4);
            this.panelRevenue.Controls.Add(this.label4);
            this.panelRevenue.Controls.Add(this.total_earning);
            this.panelRevenue.Controls.Add(this.label2);
            this.panelRevenue.Controls.Add(this.chartRevenue);
            this.panelRevenue.Location = new System.Drawing.Point(21, 3);
            this.panelRevenue.Name = "panelRevenue";
            this.panelRevenue.Size = new System.Drawing.Size(953, 420);
            this.panelRevenue.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "TOTAL EARNINGS";
            // 
            // total_earning
            // 
            this.total_earning.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_earning.ForeColor = System.Drawing.Color.Teal;
            this.total_earning.Location = new System.Drawing.Point(30, 151);
            this.total_earning.Name = "total_earning";
            this.total_earning.Size = new System.Drawing.Size(259, 45);
            this.total_earning.TabIndex = 8;
            this.total_earning.Text = "0";
            this.total_earning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(26, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "TODAY\'S EARNINGS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(29, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 5);
            this.panel4.TabIndex = 10;
            // 
            // total_earningDay
            // 
            this.total_earningDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_earningDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.total_earningDay.Location = new System.Drawing.Point(180, 212);
            this.total_earningDay.Name = "total_earningDay";
            this.total_earningDay.Size = new System.Drawing.Size(199, 24);
            this.total_earningDay.TabIndex = 11;
            this.total_earningDay.Text = "0";
            this.total_earningDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_earningMonth
            // 
            this.total_earningMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_earningMonth.ForeColor = System.Drawing.Color.DeepPink;
            this.total_earningMonth.Location = new System.Drawing.Point(180, 257);
            this.total_earningMonth.Name = "total_earningMonth";
            this.total_earningMonth.Size = new System.Drawing.Size(199, 24);
            this.total_earningMonth.TabIndex = 13;
            this.total_earningMonth.Text = "0";
            this.total_earningMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(25, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "MONTH\'S  EARNINGS";
            // 
            // panelOrderSold_Cancelled
            // 
            this.panelOrderSold_Cancelled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrderSold_Cancelled.Controls.Add(this.chartRatioOrder);
            this.panelOrderSold_Cancelled.Controls.Add(this.total_orderCancelled);
            this.panelOrderSold_Cancelled.Controls.Add(this.label6);
            this.panelOrderSold_Cancelled.Controls.Add(this.total_orderSold);
            this.panelOrderSold_Cancelled.Controls.Add(this.label9);
            this.panelOrderSold_Cancelled.Location = new System.Drawing.Point(21, 3);
            this.panelOrderSold_Cancelled.Name = "panelOrderSold_Cancelled";
            this.panelOrderSold_Cancelled.Size = new System.Drawing.Size(953, 420);
            this.panelOrderSold_Cancelled.TabIndex = 14;
            this.panelOrderSold_Cancelled.Visible = false;
            // 
            // total_orderCancelled
            // 
            this.total_orderCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_orderCancelled.ForeColor = System.Drawing.Color.DeepPink;
            this.total_orderCancelled.Location = new System.Drawing.Point(204, 151);
            this.total_orderCancelled.Name = "total_orderCancelled";
            this.total_orderCancelled.Size = new System.Drawing.Size(182, 24);
            this.total_orderCancelled.TabIndex = 13;
            this.total_orderCancelled.Text = "0";
            this.total_orderCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "TOTAL ORDERS CANCELLED";
            // 
            // total_orderSold
            // 
            this.total_orderSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_orderSold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.total_orderSold.Location = new System.Drawing.Point(204, 109);
            this.total_orderSold.Name = "total_orderSold";
            this.total_orderSold.Size = new System.Drawing.Size(177, 24);
            this.total_orderSold.TabIndex = 11;
            this.total_orderSold.Text = "0";
            this.total_orderSold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(3, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "TOTAL ORDERS SOLD";
            // 
            // chartRatioOrder
            // 
            chartArea9.Name = "ChartArea1";
            this.chartRatioOrder.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartRatioOrder.Legends.Add(legend9);
            this.chartRatioOrder.Location = new System.Drawing.Point(477, 15);
            this.chartRatioOrder.Name = "chartRatioOrder";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "ratioOrder";
            this.chartRatioOrder.Series.Add(series9);
            this.chartRatioOrder.Size = new System.Drawing.Size(425, 379);
            this.chartRatioOrder.TabIndex = 14;
            this.chartRatioOrder.Text = "chart1";
            title9.Name = "Ratio Order";
            this.chartRatioOrder.Titles.Add(title9);
            // 
            // AdminStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.OrderSold_btn);
            this.Controls.Add(this.Order_btn);
            this.Controls.Add(this.RevenueBtn);
            this.Name = "AdminStatistical";
            this.Size = new System.Drawing.Size(1014, 600);
            this.Load += new System.EventHandler(this.AdminStatistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelRevenue.ResumeLayout(false);
            this.panelRevenue.PerformLayout();
            this.panelOrderSold_Cancelled.ResumeLayout(false);
            this.panelOrderSold_Cancelled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRatioOrder)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
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
