namespace SortingHat
{
    partial class SeatingPlanGrid
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
            this.ClassroomSpotPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GridVSlider = new System.Windows.Forms.TrackBar();
            this.GridHSlider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.GridVSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassroomSpotPanel
            // 
            this.ClassroomSpotPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassroomSpotPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ClassroomSpotPanel.ColumnCount = 2;
            this.ClassroomSpotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassroomSpotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassroomSpotPanel.Location = new System.Drawing.Point(3, 45);
            this.ClassroomSpotPanel.Name = "ClassroomSpotPanel";
            this.ClassroomSpotPanel.RowCount = 2;
            this.ClassroomSpotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassroomSpotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassroomSpotPanel.Size = new System.Drawing.Size(479, 419);
            this.ClassroomSpotPanel.TabIndex = 2;
            // 
            // GridVSlider
            // 
            this.GridVSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridVSlider.AutoSize = false;
            this.GridVSlider.Location = new System.Drawing.Point(488, 45);
            this.GridVSlider.Minimum = 2;
            this.GridVSlider.Name = "GridVSlider";
            this.GridVSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.GridVSlider.Size = new System.Drawing.Size(41, 419);
            this.GridVSlider.TabIndex = 1;
            this.GridVSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.GridVSlider.Value = 10;
            this.GridVSlider.Scroll += new System.EventHandler(this.GridVSlider_Scroll);
            // 
            // GridHSlider
            // 
            this.GridHSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridHSlider.AutoSize = false;
            this.GridHSlider.Location = new System.Drawing.Point(3, 3);
            this.GridHSlider.Minimum = 2;
            this.GridHSlider.Name = "GridHSlider";
            this.GridHSlider.Size = new System.Drawing.Size(479, 44);
            this.GridHSlider.TabIndex = 0;
            this.GridHSlider.Value = 10;
            this.GridHSlider.Scroll += new System.EventHandler(this.GridHSlider_Scroll);
            // 
            // SeatingPlanGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClassroomSpotPanel);
            this.Controls.Add(this.GridVSlider);
            this.Controls.Add(this.GridHSlider);
            this.DoubleBuffered = true;
            this.Name = "SeatingPlanGrid";
            this.Size = new System.Drawing.Size(532, 467);
            ((System.ComponentModel.ISupportInitialize)(this.GridVSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ClassroomSpotPanel;
        private System.Windows.Forms.TrackBar GridVSlider;
        private System.Windows.Forms.TrackBar GridHSlider;
    }
}
