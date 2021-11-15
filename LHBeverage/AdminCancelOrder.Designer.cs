
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Reason_tb = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reason for invoice cancellation";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Blue;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(145, 209);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(89, 28);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Reason_tb
            // 
            this.Reason_tb.Location = new System.Drawing.Point(0, 60);
            this.Reason_tb.Multiline = true;
            this.Reason_tb.Name = "Reason_tb";
            this.Reason_tb.Size = new System.Drawing.Size(476, 133);
            this.Reason_tb.TabIndex = 3;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Red;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(240, 209);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(89, 28);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AdminCancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(477, 249);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Reason_tb);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label1);
            this.Name = "AdminCancelOrder";
            this.Text = "AdminCancelOrder";
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