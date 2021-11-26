
namespace LHBeverage.UserControls.Component
{
    partial class AdminCardOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCardOrder));
            this.panelCtn = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusOrder_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountItem = new System.Windows.Forms.Label();
            this.TotalPayment = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.DatePayment = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ViewDetailOrder_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.done_lbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProccessingOrdered_bar = new System.Windows.Forms.Panel();
            this.ProccessingPayment_bar = new System.Windows.Forms.Panel();
            this.ProccessingReceived_bar = new System.Windows.Forms.Panel();
            this.CodeOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCtn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCtn
            // 
            this.panelCtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCtn.BackColor = System.Drawing.Color.Orange;
            this.panelCtn.Controls.Add(this.panel1);
            this.panelCtn.Controls.Add(this.panel5);
            this.panelCtn.Controls.Add(this.DatePayment);
            this.panelCtn.Controls.Add(this.label15);
            this.panelCtn.Controls.Add(this.ViewDetailOrder_btn);
            this.panelCtn.Controls.Add(this.panel2);
            this.panelCtn.Controls.Add(this.CodeOrder);
            this.panelCtn.Controls.Add(this.label1);
            this.panelCtn.Location = new System.Drawing.Point(-3, 0);
            this.panelCtn.Name = "panelCtn";
            this.panelCtn.Size = new System.Drawing.Size(990, 183);
            this.panelCtn.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.statusOrder_lbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AmountItem);
            this.panel1.Controls.Add(this.TotalPayment);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(8, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 109);
            this.panel1.TabIndex = 11;
            // 
            // statusOrder_lbl
            // 
            this.statusOrder_lbl.AutoSize = true;
            this.statusOrder_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusOrder_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.statusOrder_lbl.Location = new System.Drawing.Point(193, 84);
            this.statusOrder_lbl.Name = "statusOrder_lbl";
            this.statusOrder_lbl.Size = new System.Drawing.Size(88, 20);
            this.statusOrder_lbl.TabIndex = 13;
            this.statusOrder_lbl.Text = "Cancelled";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status";
            // 
            // AmountItem
            // 
            this.AmountItem.AutoSize = true;
            this.AmountItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountItem.ForeColor = System.Drawing.Color.Black;
            this.AmountItem.Location = new System.Drawing.Point(219, 55);
            this.AmountItem.Name = "AmountItem";
            this.AmountItem.Size = new System.Drawing.Size(17, 17);
            this.AmountItem.TabIndex = 12;
            this.AmountItem.Text = "0";
            // 
            // TotalPayment
            // 
            this.TotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPayment.ForeColor = System.Drawing.Color.Red;
            this.TotalPayment.Location = new System.Drawing.Point(154, 11);
            this.TotalPayment.Name = "TotalPayment";
            this.TotalPayment.Size = new System.Drawing.Size(147, 20);
            this.TotalPayment.TabIndex = 18;
            this.TotalPayment.Text = "0";
            this.TotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(8, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 17);
            this.label18.TabIndex = 11;
            this.label18.Text = "Amount Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Total payment";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.CustomerName);
            this.panel5.Location = new System.Drawing.Point(7, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 28);
            this.panel5.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Customer";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.ForeColor = System.Drawing.Color.Black;
            this.CustomerName.Location = new System.Drawing.Point(200, 4);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(59, 20);
            this.CustomerName.TabIndex = 3;
            this.CustomerName.Text = "Huy Tô";
            // 
            // DatePayment
            // 
            this.DatePayment.AutoSize = true;
            this.DatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePayment.ForeColor = System.Drawing.Color.White;
            this.DatePayment.Location = new System.Drawing.Point(461, 11);
            this.DatePayment.Name = "DatePayment";
            this.DatePayment.Size = new System.Drawing.Size(89, 20);
            this.DatePayment.TabIndex = 9;
            this.DatePayment.Text = "11/11/2021";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(342, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 18);
            this.label15.TabIndex = 8;
            this.label15.Text = "Date Payment";
            // 
            // ViewDetailOrder_btn
            // 
            this.ViewDetailOrder_btn.BackColor = System.Drawing.Color.DarkViolet;
            this.ViewDetailOrder_btn.FlatAppearance.BorderSize = 0;
            this.ViewDetailOrder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewDetailOrder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDetailOrder_btn.ForeColor = System.Drawing.Color.White;
            this.ViewDetailOrder_btn.Location = new System.Drawing.Point(883, 3);
            this.ViewDetailOrder_btn.Name = "ViewDetailOrder_btn";
            this.ViewDetailOrder_btn.Size = new System.Drawing.Size(104, 28);
            this.ViewDetailOrder_btn.TabIndex = 7;
            this.ViewDetailOrder_btn.Text = "View Detail";
            this.ViewDetailOrder_btn.UseVisualStyleBackColor = false;
            this.ViewDetailOrder_btn.Click += new System.EventHandler(this.ViewDetailOrder_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.done_lbl);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ProccessingOrdered_bar);
            this.panel2.Controls.Add(this.ProccessingPayment_bar);
            this.panel2.Controls.Add(this.ProccessingReceived_bar);
            this.panel2.Location = new System.Drawing.Point(342, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 143);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(543, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(540, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 44);
            this.label11.TabIndex = 13;
            this.label11.Text = "Received";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(347, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 44);
            this.label10.TabIndex = 12;
            this.label10.Text = "Delivered to the shipping service";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(159, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 44);
            this.label9.TabIndex = 11;
            this.label9.Text = "payment information verified";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ordered";
            // 
            // done_lbl
            // 
            this.done_lbl.AutoSize = true;
            this.done_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.done_lbl.Location = new System.Drawing.Point(539, 8);
            this.done_lbl.Name = "done_lbl";
            this.done_lbl.Size = new System.Drawing.Size(62, 20);
            this.done_lbl.TabIndex = 7;
            this.done_lbl.Text = "Done!!";
            this.done_lbl.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(370, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(194, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ProccessingOrdered_bar
            // 
            this.ProccessingOrdered_bar.BackColor = System.Drawing.Color.Lime;
            this.ProccessingOrdered_bar.Location = new System.Drawing.Point(55, 54);
            this.ProccessingOrdered_bar.Name = "ProccessingOrdered_bar";
            this.ProccessingOrdered_bar.Size = new System.Drawing.Size(160, 10);
            this.ProccessingOrdered_bar.TabIndex = 8;
            // 
            // ProccessingPayment_bar
            // 
            this.ProccessingPayment_bar.BackColor = System.Drawing.Color.DarkGray;
            this.ProccessingPayment_bar.Location = new System.Drawing.Point(235, 54);
            this.ProccessingPayment_bar.Name = "ProccessingPayment_bar";
            this.ProccessingPayment_bar.Size = new System.Drawing.Size(180, 11);
            this.ProccessingPayment_bar.TabIndex = 9;
            // 
            // ProccessingReceived_bar
            // 
            this.ProccessingReceived_bar.BackColor = System.Drawing.Color.DarkGray;
            this.ProccessingReceived_bar.Location = new System.Drawing.Point(431, 54);
            this.ProccessingReceived_bar.Name = "ProccessingReceived_bar";
            this.ProccessingReceived_bar.Size = new System.Drawing.Size(165, 11);
            this.ProccessingReceived_bar.TabIndex = 10;
            // 
            // CodeOrder
            // 
            this.CodeOrder.AutoSize = true;
            this.CodeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeOrder.ForeColor = System.Drawing.Color.White;
            this.CodeOrder.Location = new System.Drawing.Point(64, 8);
            this.CodeOrder.Name = "CodeOrder";
            this.CodeOrder.Size = new System.Drawing.Size(45, 20);
            this.CodeOrder.TabIndex = 1;
            this.CodeOrder.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // AdminCardOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCtn);
            this.Name = "AdminCardOrder";
            this.Size = new System.Drawing.Size(990, 183);
            this.panelCtn.ResumeLayout(false);
            this.panelCtn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label AmountItem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label DatePayment;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ViewDetailOrder_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label done_lbl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ProccessingOrdered_bar;
        private System.Windows.Forms.Panel ProccessingPayment_bar;
        private System.Windows.Forms.Panel ProccessingReceived_bar;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label CodeOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusOrder_lbl;
        private System.Windows.Forms.Label label5;
    }
}
