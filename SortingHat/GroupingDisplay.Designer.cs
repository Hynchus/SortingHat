namespace SortingHat
{
    partial class GroupingDisplay
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
            this.GroupingLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // GroupingLayoutPanel
            // 
            this.GroupingLayoutPanel.AutoScroll = true;
            this.GroupingLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupingLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.GroupingLayoutPanel.Name = "GroupingLayoutPanel";
            this.GroupingLayoutPanel.Size = new System.Drawing.Size(502, 278);
            this.GroupingLayoutPanel.TabIndex = 0;
            // 
            // GroupingDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupingLayoutPanel);
            this.Name = "GroupingDisplay";
            this.Size = new System.Drawing.Size(502, 278);
            this.Load += new System.EventHandler(this.GroupingDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel GroupingLayoutPanel;
    }
}
