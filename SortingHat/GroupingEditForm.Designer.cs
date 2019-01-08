namespace SortingHat
{
    partial class GroupingEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupingEditForm));
            this.GroupingNamelbl = new System.Windows.Forms.Label();
            this.GroupCountlbl = new System.Windows.Forms.Label();
            this.GroupingNametxtbox = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.GroupCountTrackbar = new System.Windows.Forms.TrackBar();
            this.GroupCountNumberlbl = new System.Windows.Forms.Label();
            this.ShuffleWarninglbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCountTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupingNamelbl
            // 
            this.GroupingNamelbl.AutoSize = true;
            this.GroupingNamelbl.Location = new System.Drawing.Point(45, 35);
            this.GroupingNamelbl.Name = "GroupingNamelbl";
            this.GroupingNamelbl.Size = new System.Drawing.Size(121, 20);
            this.GroupingNamelbl.TabIndex = 0;
            this.GroupingNamelbl.Text = "Grouping Name";
            // 
            // GroupCountlbl
            // 
            this.GroupCountlbl.AutoSize = true;
            this.GroupCountlbl.Location = new System.Drawing.Point(45, 125);
            this.GroupCountlbl.Name = "GroupCountlbl";
            this.GroupCountlbl.Size = new System.Drawing.Size(101, 20);
            this.GroupCountlbl.TabIndex = 1;
            this.GroupCountlbl.Text = "Group Count";
            // 
            // GroupingNametxtbox
            // 
            this.GroupingNametxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupingNametxtbox.Location = new System.Drawing.Point(49, 58);
            this.GroupingNametxtbox.Name = "GroupingNametxtbox";
            this.GroupingNametxtbox.Size = new System.Drawing.Size(218, 26);
            this.GroupingNametxtbox.TabIndex = 1;
            this.GroupingNametxtbox.TextChanged += new System.EventHandler(this.GroupingNametxtbox_TextChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Savebtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Savebtn.Location = new System.Drawing.Point(49, 262);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(96, 37);
            this.Savebtn.TabIndex = 4;
            this.Savebtn.Text = "&Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbtn.Location = new System.Drawing.Point(171, 262);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(96, 37);
            this.Cancelbtn.TabIndex = 5;
            this.Cancelbtn.Text = "&Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // GroupCountTrackbar
            // 
            this.GroupCountTrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupCountTrackbar.Location = new System.Drawing.Point(49, 149);
            this.GroupCountTrackbar.Maximum = 14;
            this.GroupCountTrackbar.Minimum = 1;
            this.GroupCountTrackbar.Name = "GroupCountTrackbar";
            this.GroupCountTrackbar.Size = new System.Drawing.Size(218, 69);
            this.GroupCountTrackbar.TabIndex = 2;
            this.GroupCountTrackbar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.GroupCountTrackbar.Value = 4;
            this.GroupCountTrackbar.ValueChanged += new System.EventHandler(this.GroupCountTrackbar_ValueChanged);
            // 
            // GroupCountNumberlbl
            // 
            this.GroupCountNumberlbl.Location = new System.Drawing.Point(209, 125);
            this.GroupCountNumberlbl.Name = "GroupCountNumberlbl";
            this.GroupCountNumberlbl.Size = new System.Drawing.Size(58, 21);
            this.GroupCountNumberlbl.TabIndex = 6;
            this.GroupCountNumberlbl.Text = "4";
            this.GroupCountNumberlbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ShuffleWarninglbl
            // 
            this.ShuffleWarninglbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ShuffleWarninglbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ShuffleWarninglbl.Location = new System.Drawing.Point(49, 218);
            this.ShuffleWarninglbl.Name = "ShuffleWarninglbl";
            this.ShuffleWarninglbl.Size = new System.Drawing.Size(218, 41);
            this.ShuffleWarninglbl.TabIndex = 7;
            this.ShuffleWarninglbl.Text = "Groups will be reshuffled due to change in group count.";
            this.ShuffleWarninglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShuffleWarninglbl.Visible = false;
            // 
            // GroupingEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelbtn;
            this.ClientSize = new System.Drawing.Size(316, 324);
            this.Controls.Add(this.ShuffleWarninglbl);
            this.Controls.Add(this.GroupCountNumberlbl);
            this.Controls.Add(this.GroupCountTrackbar);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.GroupingNametxtbox);
            this.Controls.Add(this.GroupCountlbl);
            this.Controls.Add(this.GroupingNamelbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(338, 380);
            this.Name = "GroupingEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grouping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GroupingEditForm_FormClosing);
            this.Load += new System.EventHandler(this.GroupingEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupCountTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GroupingNamelbl;
        private System.Windows.Forms.Label GroupCountlbl;
        private System.Windows.Forms.TextBox GroupingNametxtbox;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.TrackBar GroupCountTrackbar;
        private System.Windows.Forms.Label GroupCountNumberlbl;
        private System.Windows.Forms.Label ShuffleWarninglbl;
    }
}