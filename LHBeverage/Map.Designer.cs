
namespace LHBeverage
{
    partial class Map
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
            this.MapControl = new GMap.NET.WindowsForms.GMapControl();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MapControl
            // 
            this.MapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapControl.Bearing = 0F;
            this.MapControl.CanDragMap = true;
            this.MapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.MapControl.GrayScaleMode = false;
            this.MapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MapControl.LevelsKeepInMemory = 5;
            this.MapControl.Location = new System.Drawing.Point(0, 0);
            this.MapControl.MarkersEnabled = true;
            this.MapControl.MaxZoom = 100;
            this.MapControl.MinZoom = 10;
            this.MapControl.MouseWheelZoomEnabled = true;
            this.MapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MapControl.Name = "MapControl";
            this.MapControl.NegativeMode = false;
            this.MapControl.PolygonsEnabled = true;
            this.MapControl.RetryLoadTile = 0;
            this.MapControl.RoutesEnabled = true;
            this.MapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MapControl.ShowTileGridLines = false;
            this.MapControl.Size = new System.Drawing.Size(784, 408);
            this.MapControl.TabIndex = 0;
            this.MapControl.Zoom = 0D;
            this.MapControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MapControl_MouseClick);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.ConfirmBtn.FlatAppearance.BorderSize = 0;
            this.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.Black;
            this.ConfirmBtn.Location = new System.Drawing.Point(300, 420);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(200, 40);
            this.ConfirmBtn.TabIndex = 3;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 468);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.MapControl);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl MapControl;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}