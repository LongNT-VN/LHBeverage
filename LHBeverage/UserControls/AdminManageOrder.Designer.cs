
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
            // AdminManageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Order_FlowPanel);
            this.Name = "AdminManageOrder";
            this.Size = new System.Drawing.Size(1014, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Order_FlowPanel;
    }
}
