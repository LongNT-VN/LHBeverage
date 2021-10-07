
namespace LHBeverage
{
    partial class LHBeverage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HomePanel = new System.Windows.Forms.Panel();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1264, 681);
            this.HomePanel.TabIndex = 0;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.DarkRed;
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(100, 681);
            this.NavigationPanel.TabIndex = 1;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(100, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(1164, 80);
            this.SearchPanel.TabIndex = 2;
            // 
            // LHBeverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.HomePanel);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "LHBeverage";
            this.Text = "LHBeverage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Panel SearchPanel;
    }
}

