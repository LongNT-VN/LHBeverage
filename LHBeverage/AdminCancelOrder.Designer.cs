
namespace LHBeverage
{
    partial class AdminCancelOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCancelOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Reason_tb = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Blue;
            this.Cancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Name = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Reason_tb
            // 
            resources.ApplyResources(this.Reason_tb, "Reason_tb");
            this.Reason_tb.Name = "Reason_tb";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Red;
            this.Submit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Submit, "Submit");
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Name = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AdminCancelOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Reason_tb);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label1);
            this.Name = "AdminCancelOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox Reason_tb;
        private System.Windows.Forms.Button Submit;
    }
}