namespace SortingHat
{
    partial class StudentList
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.AllowDrop = true;
            this.ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 20;
            this.ListBox.Location = new System.Drawing.Point(0, 0);
            this.ListBox.Name = "ListBox";
            this.ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox.Size = new System.Drawing.Size(150, 150);
            this.ListBox.TabIndex = 0;
            this.ListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.ListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListBox);
            this.Name = "StudentList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
    }
}
