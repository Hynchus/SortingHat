namespace SortingHat
{
    partial class ClassroomSpotControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassroomSpotControl));
            this.OccupantNamelbl = new System.Windows.Forms.Label();
            this.BackgroundImages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // OccupantNamelbl
            // 
            this.OccupantNamelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OccupantNamelbl.BackColor = System.Drawing.Color.White;
            this.OccupantNamelbl.Location = new System.Drawing.Point(4, 44);
            this.OccupantNamelbl.Name = "OccupantNamelbl";
            this.OccupantNamelbl.Size = new System.Drawing.Size(143, 23);
            this.OccupantNamelbl.TabIndex = 0;
            this.OccupantNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OccupantNamelbl.Visible = false;
            // 
            // BackgroundImages
            // 
            this.BackgroundImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BackgroundImages.ImageStream")));
            this.BackgroundImages.TransparentColor = System.Drawing.Color.Transparent;
            this.BackgroundImages.Images.SetKeyName(0, "Tile.png");
            this.BackgroundImages.Images.SetKeyName(1, "Desk.png");
            // 
            // ClassroomSpotControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::SortingHat.Properties.Resources.Tile;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.OccupantNamelbl);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ClassroomSpotControl";
            this.Size = new System.Drawing.Size(150, 116);
            this.Click += new System.EventHandler(this.ClassroomSpotControl_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OccupantNamelbl;
        private System.Windows.Forms.ImageList BackgroundImages;
    }
}
