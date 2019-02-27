namespace SortingHat
{
    partial class SeatingPlanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatingPlanForm));
            this.Unseatbtn = new System.Windows.Forms.Button();
            this.Seatbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.ClassroomSpotsPanel = new System.Windows.Forms.Panel();
            this.HelpBox = new System.Windows.Forms.PictureBox();
            this.HelperTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.DeskCountlbl = new System.Windows.Forms.Label();
            this.ExportImagebtn = new System.Windows.Forms.Button();
            this.StudentListbox = new SortingHat.StudentList();
            ((System.ComponentModel.ISupportInitialize)(this.HelpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Unseatbtn
            // 
            this.Unseatbtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Unseatbtn.Enabled = false;
            this.Unseatbtn.Location = new System.Drawing.Point(265, 208);
            this.Unseatbtn.Name = "Unseatbtn";
            this.Unseatbtn.Size = new System.Drawing.Size(75, 60);
            this.Unseatbtn.TabIndex = 4;
            this.Unseatbtn.Text = "Unseat\r\n <<<";
            this.Unseatbtn.UseVisualStyleBackColor = true;
            this.Unseatbtn.Click += new System.EventHandler(this.Unseatbtn_Click);
            // 
            // Seatbtn
            // 
            this.Seatbtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Seatbtn.Enabled = false;
            this.Seatbtn.Location = new System.Drawing.Point(265, 142);
            this.Seatbtn.Name = "Seatbtn";
            this.Seatbtn.Size = new System.Drawing.Size(75, 60);
            this.Seatbtn.TabIndex = 5;
            this.Seatbtn.Text = " Seat\r\n >>>";
            this.Seatbtn.UseVisualStyleBackColor = true;
            this.Seatbtn.Click += new System.EventHandler(this.Seatbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbtn.Location = new System.Drawing.Point(508, 412);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(96, 37);
            this.Cancelbtn.TabIndex = 9;
            this.Cancelbtn.Text = "&Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Savebtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Savebtn.Location = new System.Drawing.Point(388, 412);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(96, 37);
            this.Savebtn.TabIndex = 8;
            this.Savebtn.Text = "&Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // ClassroomSpotsPanel
            // 
            this.ClassroomSpotsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassroomSpotsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassroomSpotsPanel.Location = new System.Drawing.Point(346, 12);
            this.ClassroomSpotsPanel.Name = "ClassroomSpotsPanel";
            this.ClassroomSpotsPanel.Size = new System.Drawing.Size(635, 391);
            this.ClassroomSpotsPanel.TabIndex = 11;
            this.ClassroomSpotsPanel.Resize += new System.EventHandler(this.ClassroomSpotsPanel_Resize);
            // 
            // HelpBox
            // 
            this.HelpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpBox.Image = global::SortingHat.Properties.Resources.Help;
            this.HelpBox.Location = new System.Drawing.Point(944, 412);
            this.HelpBox.Name = "HelpBox";
            this.HelpBox.Size = new System.Drawing.Size(37, 37);
            this.HelpBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HelpBox.TabIndex = 10;
            this.HelpBox.TabStop = false;
            this.HelperTooltip.SetToolTip(this.HelpBox, resources.GetString("HelpBox.ToolTip"));
            // 
            // HelperTooltip
            // 
            this.HelperTooltip.AutoPopDelay = 30000;
            this.HelperTooltip.InitialDelay = 50;
            this.HelperTooltip.ReshowDelay = 10;
            this.HelperTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // DeskCountlbl
            // 
            this.DeskCountlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeskCountlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DeskCountlbl.Location = new System.Drawing.Point(13, 412);
            this.DeskCountlbl.Name = "DeskCountlbl";
            this.DeskCountlbl.Size = new System.Drawing.Size(257, 43);
            this.DeskCountlbl.TabIndex = 12;
            this.DeskCountlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeskCountlbl.Visible = false;
            // 
            // ExportImagebtn
            // 
            this.ExportImagebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportImagebtn.Location = new System.Drawing.Point(790, 412);
            this.ExportImagebtn.Name = "ExportImagebtn";
            this.ExportImagebtn.Size = new System.Drawing.Size(123, 37);
            this.ExportImagebtn.TabIndex = 13;
            this.ExportImagebtn.Text = "Export Image";
            this.ExportImagebtn.UseVisualStyleBackColor = true;
            this.ExportImagebtn.Click += new System.EventHandler(this.ExportImagebtn_Click);
            // 
            // StudentListbox
            // 
            this.StudentListbox.AllowDrop = true;
            this.StudentListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StudentListbox.DragMethod = System.Windows.Forms.DragDropEffects.Move;
            this.StudentListbox.Location = new System.Drawing.Point(13, 12);
            this.StudentListbox.Name = "StudentListbox";
            this.StudentListbox.ReceiveDrop = true;
            this.StudentListbox.Size = new System.Drawing.Size(246, 391);
            this.StudentListbox.TabIndex = 2;
            // 
            // SeatingPlanForm
            // 
            this.AcceptButton = this.Savebtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelbtn;
            this.ClientSize = new System.Drawing.Size(993, 458);
            this.Controls.Add(this.ExportImagebtn);
            this.Controls.Add(this.DeskCountlbl);
            this.Controls.Add(this.ClassroomSpotsPanel);
            this.Controls.Add(this.HelpBox);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Seatbtn);
            this.Controls.Add(this.Unseatbtn);
            this.Controls.Add(this.StudentListbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1015, 514);
            this.Name = "SeatingPlanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seating Plan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SeatingPlanForm_FormClosing);
            this.Load += new System.EventHandler(this.SeatingPlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HelpBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private StudentList StudentListbox;
        private System.Windows.Forms.Button Unseatbtn;
        private System.Windows.Forms.Button Seatbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.PictureBox HelpBox;
        private System.Windows.Forms.Panel ClassroomSpotsPanel;
        private System.Windows.Forms.ToolTip HelperTooltip;
        private System.Windows.Forms.Label DeskCountlbl;
        private System.Windows.Forms.Button ExportImagebtn;
    }
}