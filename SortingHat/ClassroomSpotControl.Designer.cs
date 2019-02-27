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
            this.BackgroundImages = new System.Windows.Forms.ImageList(this.components);
            this.Occupantlbl = new SortingHat.SeatTextbox();
            this.SuspendLayout();
            // 
            // BackgroundImages
            // 
            this.BackgroundImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BackgroundImages.ImageStream")));
            this.BackgroundImages.TransparentColor = System.Drawing.Color.Transparent;
            this.BackgroundImages.Images.SetKeyName(0, "Outline.jpg");
            this.BackgroundImages.Images.SetKeyName(1, "Full.jpg");
            // 
            // Occupantlbl
            // 
            this.Occupantlbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Occupantlbl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Occupantlbl.Location = new System.Drawing.Point(12, 14);
            this.Occupantlbl.Name = "Occupantlbl";
            this.Occupantlbl.Occupant = null;
            this.Occupantlbl.Size = new System.Drawing.Size(104, 22);
            this.Occupantlbl.TabIndex = 1;
            this.Occupantlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Occupantlbl.Visible = false;
            // 
            // ClassroomSpotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::SortingHat.Properties.Resources.Outline;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Occupantlbl);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ClassroomSpotControl";
            this.Size = new System.Drawing.Size(128, 64);
            this.Click += new System.EventHandler(this.ClassroomSpotControl_Click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList BackgroundImages;
        private SeatTextbox Occupantlbl;
    }
}
