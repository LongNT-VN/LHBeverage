
namespace LHBeverage.UserControls
{
    partial class HistoryOrderPage
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
            this.IsDelivery = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // IsDelivery
            // 
            this.IsDelivery.AutoScroll = true;
            this.IsDelivery.Location = new System.Drawing.Point(42, 100);
            this.IsDelivery.Name = "IsDelivery";
            this.IsDelivery.Size = new System.Drawing.Size(1100, 400);
            this.IsDelivery.TabIndex = 0;
            // 
            // HistoryOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IsDelivery);
            this.Name = "HistoryOrderPage";
            this.Size = new System.Drawing.Size(1184, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel IsDelivery;
    }
}
