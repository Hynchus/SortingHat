namespace SortingHat
{
    partial class GroupDisplay
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
            this.GroupListbox = new System.Windows.Forms.ListBox();
            this.GroupNameTextbox = new System.Windows.Forms.TextBox();
            this.Focuspnl = new System.Windows.Forms.Panel();
            this.GroupColourbtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GroupListbox
            // 
            this.GroupListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupListbox.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupListbox.FormattingEnabled = true;
            this.GroupListbox.ItemHeight = 22;
            this.GroupListbox.Location = new System.Drawing.Point(17, 43);
            this.GroupListbox.Name = "GroupListbox";
            this.GroupListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.GroupListbox.Size = new System.Drawing.Size(250, 136);
            this.GroupListbox.TabIndex = 2;
            this.GroupListbox.TabStop = false;
            // 
            // GroupNameTextbox
            // 
            this.GroupNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNameTextbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GroupNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroupNameTextbox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupNameTextbox.Location = new System.Drawing.Point(18, 18);
            this.GroupNameTextbox.Name = "GroupNameTextbox";
            this.GroupNameTextbox.Size = new System.Drawing.Size(223, 20);
            this.GroupNameTextbox.TabIndex = 1;
            this.GroupNameTextbox.TabStop = false;
            this.GroupNameTextbox.Text = "GroupName";
            this.GroupNameTextbox.TextChanged += new System.EventHandler(this.GroupNameTextbox_TextChanged);
            this.GroupNameTextbox.MouseEnter += new System.EventHandler(this.GroupNameTextbox_MouseEnter);
            this.GroupNameTextbox.MouseLeave += new System.EventHandler(this.GroupNameTextbox_MouseLeave);
            // 
            // Focuspnl
            // 
            this.Focuspnl.Location = new System.Drawing.Point(273, 193);
            this.Focuspnl.Name = "Focuspnl";
            this.Focuspnl.Size = new System.Drawing.Size(10, 10);
            this.Focuspnl.TabIndex = 0;
            this.Focuspnl.TabStop = true;
            // 
            // GroupColourbtn
            // 
            this.GroupColourbtn.BackColor = System.Drawing.Color.Transparent;
            this.GroupColourbtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupColourbtn.Location = new System.Drawing.Point(247, 17);
            this.GroupColourbtn.Name = "GroupColourbtn";
            this.GroupColourbtn.Size = new System.Drawing.Size(20, 20);
            this.GroupColourbtn.TabIndex = 3;
            this.GroupColourbtn.Click += new System.EventHandler(this.GroupColourbtn_Click);
            // 
            // GroupDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.GroupColourbtn);
            this.Controls.Add(this.Focuspnl);
            this.Controls.Add(this.GroupNameTextbox);
            this.Controls.Add(this.GroupListbox);
            this.Name = "GroupDisplay";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.Size = new System.Drawing.Size(284, 204);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox GroupListbox;
        private System.Windows.Forms.TextBox GroupNameTextbox;
        private System.Windows.Forms.Panel Focuspnl;
        private System.Windows.Forms.Label GroupColourbtn;
    }
}
