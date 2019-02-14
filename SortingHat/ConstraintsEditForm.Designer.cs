namespace SortingHat
{
    partial class ConstraintsEditForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstraintsEditForm));
            this.ConstraintGroupsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewConstraintbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.HelpBox = new System.Windows.Forms.PictureBox();
            this.HelpTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.StudentListbox = new SortingHat.StudentList();
            this.ConstraintGroupsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ConstraintGroupsPanel
            // 
            this.ConstraintGroupsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConstraintGroupsPanel.AutoScroll = true;
            this.ConstraintGroupsPanel.Controls.Add(this.NewConstraintbtn);
            this.ConstraintGroupsPanel.Location = new System.Drawing.Point(289, 13);
            this.ConstraintGroupsPanel.Name = "ConstraintGroupsPanel";
            this.ConstraintGroupsPanel.Size = new System.Drawing.Size(499, 297);
            this.ConstraintGroupsPanel.TabIndex = 1;
            // 
            // NewConstraintbtn
            // 
            this.NewConstraintbtn.Location = new System.Drawing.Point(10, 10);
            this.NewConstraintbtn.Margin = new System.Windows.Forms.Padding(10);
            this.NewConstraintbtn.Name = "NewConstraintbtn";
            this.NewConstraintbtn.Size = new System.Drawing.Size(216, 128);
            this.NewConstraintbtn.TabIndex = 0;
            this.NewConstraintbtn.Text = "&New Constraint Group";
            this.NewConstraintbtn.UseVisualStyleBackColor = true;
            this.NewConstraintbtn.Click += new System.EventHandler(this.NewConstraintbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbtn.Location = new System.Drawing.Point(419, 339);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(96, 37);
            this.Cancelbtn.TabIndex = 7;
            this.Cancelbtn.Text = "&Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Savebtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Savebtn.Location = new System.Drawing.Point(299, 339);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(96, 37);
            this.Savebtn.TabIndex = 6;
            this.Savebtn.Text = "&Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // HelpBox
            // 
            this.HelpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpBox.Image = global::SortingHat.Properties.Resources.Help;
            this.HelpBox.Location = new System.Drawing.Point(751, 339);
            this.HelpBox.Name = "HelpBox";
            this.HelpBox.Size = new System.Drawing.Size(37, 37);
            this.HelpBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HelpBox.TabIndex = 8;
            this.HelpBox.TabStop = false;
            this.HelpTooltip.SetToolTip(this.HelpBox, resources.GetString("HelpBox.ToolTip"));
            // 
            // HelpTooltip
            // 
            this.HelpTooltip.AutomaticDelay = 30000;
            this.HelpTooltip.AutoPopDelay = 30000;
            this.HelpTooltip.InitialDelay = 50;
            this.HelpTooltip.ReshowDelay = 50;
            this.HelpTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // StudentListbox
            // 
            this.StudentListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StudentListbox.DragMethod = System.Windows.Forms.DragDropEffects.Copy;
            this.StudentListbox.Location = new System.Drawing.Point(13, 13);
            this.StudentListbox.Name = "StudentListbox";
            this.StudentListbox.ReceiveDrop = true;
            this.StudentListbox.Size = new System.Drawing.Size(250, 363);
            this.StudentListbox.TabIndex = 9;
            // 
            // ConstraintsEditForm
            // 
            this.AcceptButton = this.Savebtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.Cancelbtn;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.StudentListbox);
            this.Controls.Add(this.HelpBox);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.ConstraintGroupsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(822, 444);
            this.Name = "ConstraintsEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Constraints";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConstraintsEditForm_FormClosing);
            this.Load += new System.EventHandler(this.ConstraintsEditForm_Load);
            this.ConstraintGroupsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HelpBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ConstraintGroupsPanel;
        private System.Windows.Forms.Button NewConstraintbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.PictureBox HelpBox;
        private System.Windows.Forms.ToolTip HelpTooltip;
        private StudentList StudentListbox;
    }
}