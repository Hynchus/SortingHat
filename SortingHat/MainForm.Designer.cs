namespace SortingHat
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewClassbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseFormbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.groupingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGroupingbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ClassNameDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassEditbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassDeletebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupingDisplaybtn = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordExportbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Focuspnl = new System.Windows.Forms.Panel();
            this.GroupingDisplayPanel = new SortingHat.GroupingDisplay();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.groupingToolStripMenuItem,
            this.ClassNameDisplay,
            this.GroupingDisplaybtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classToolStripMenuItem,
            this.CloseFormbtn});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewClassbtn,
            this.toolStripSeparator1});
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.classToolStripMenuItem.Text = "Class";
            // 
            // NewClassbtn
            // 
            this.NewClassbtn.Name = "NewClassbtn";
            this.NewClassbtn.Size = new System.Drawing.Size(176, 30);
            this.NewClassbtn.Text = "New Class";
            this.NewClassbtn.Click += new System.EventHandler(this.NewClassbtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // CloseFormbtn
            // 
            this.CloseFormbtn.Name = "CloseFormbtn";
            this.CloseFormbtn.Size = new System.Drawing.Size(139, 30);
            this.CloseFormbtn.Text = "Close";
            this.CloseFormbtn.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // groupingToolStripMenuItem
            // 
            this.groupingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGroupingbtn,
            this.toolStripSeparator2});
            this.groupingToolStripMenuItem.Enabled = false;
            this.groupingToolStripMenuItem.Name = "groupingToolStripMenuItem";
            this.groupingToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.groupingToolStripMenuItem.Text = "Grouping";
            this.groupingToolStripMenuItem.Visible = false;
            // 
            // NewGroupingbtn
            // 
            this.NewGroupingbtn.Name = "NewGroupingbtn";
            this.NewGroupingbtn.Size = new System.Drawing.Size(131, 30);
            this.NewGroupingbtn.Text = "New";
            this.NewGroupingbtn.Click += new System.EventHandler(this.NewGroupingbtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(128, 6);
            // 
            // ClassNameDisplay
            // 
            this.ClassNameDisplay.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ClassNameDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClassEditbtn,
            this.ClassDeletebtn});
            this.ClassNameDisplay.Enabled = false;
            this.ClassNameDisplay.Name = "ClassNameDisplay";
            this.ClassNameDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClassNameDisplay.Size = new System.Drawing.Size(12, 29);
            this.ClassNameDisplay.Visible = false;
            // 
            // ClassEditbtn
            // 
            this.ClassEditbtn.Name = "ClassEditbtn";
            this.ClassEditbtn.Size = new System.Drawing.Size(146, 30);
            this.ClassEditbtn.Text = "Edit";
            this.ClassEditbtn.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // ClassDeletebtn
            // 
            this.ClassDeletebtn.Name = "ClassDeletebtn";
            this.ClassDeletebtn.Size = new System.Drawing.Size(146, 30);
            this.ClassDeletebtn.Text = "Delete";
            this.ClassDeletebtn.Click += new System.EventHandler(this.ClassDeletebtn_Click);
            // 
            // GroupingDisplaybtn
            // 
            this.GroupingDisplaybtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.GroupingDisplaybtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeGroupsToolStripMenuItem,
            this.toolStripSeparator3,
            this.editToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.GroupingDisplaybtn.Enabled = false;
            this.GroupingDisplaybtn.Name = "GroupingDisplaybtn";
            this.GroupingDisplaybtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupingDisplaybtn.Size = new System.Drawing.Size(12, 29);
            this.GroupingDisplaybtn.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.GroupingDisplaybtn.Visible = false;
            // 
            // randomizeGroupsToolStripMenuItem
            // 
            this.randomizeGroupsToolStripMenuItem.Name = "randomizeGroupsToolStripMenuItem";
            this.randomizeGroupsToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.randomizeGroupsToolStripMenuItem.Text = "Shuffle Groups";
            this.randomizeGroupsToolStripMenuItem.Click += new System.EventHandler(this.randomizeGroupsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(211, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordExportbtn});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // WordExportbtn
            // 
            this.WordExportbtn.Name = "WordExportbtn";
            this.WordExportbtn.Size = new System.Drawing.Size(228, 30);
            this.WordExportbtn.Text = "Word Document";
            this.WordExportbtn.Click += new System.EventHandler(this.WordExportbtn_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Focuspnl
            // 
            this.Focuspnl.Location = new System.Drawing.Point(693, 250);
            this.Focuspnl.Name = "Focuspnl";
            this.Focuspnl.Size = new System.Drawing.Size(11, 13);
            this.Focuspnl.TabIndex = 0;
            this.Focuspnl.TabStop = true;
            this.Focuspnl.Visible = false;
            // 
            // GroupingDisplayPanel
            // 
            this.GroupingDisplayPanel.BackColor = System.Drawing.SystemColors.Control;
            this.GroupingDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupingDisplayPanel.Location = new System.Drawing.Point(0, 33);
            this.GroupingDisplayPanel.Name = "GroupingDisplayPanel";
            this.GroupingDisplayPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.GroupingDisplayPanel.Size = new System.Drawing.Size(704, 242);
            this.GroupingDisplayPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 275);
            this.Controls.Add(this.Focuspnl);
            this.Controls.Add(this.GroupingDisplayPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 275);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Sorting Hat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseFormbtn;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewClassbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem groupingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGroupingbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ClassNameDisplay;
        private System.Windows.Forms.ToolStripMenuItem ClassEditbtn;
        private System.Windows.Forms.ToolStripMenuItem ClassDeletebtn;
        private System.Windows.Forms.ToolStripMenuItem GroupingDisplaybtn;
        private System.Windows.Forms.ToolStripMenuItem randomizeGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private GroupingDisplay GroupingDisplayPanel;
        private System.Windows.Forms.Panel Focuspnl;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WordExportbtn;
    }
}

