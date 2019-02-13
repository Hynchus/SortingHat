namespace SortingHat
{
    partial class ChecklistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChecklistForm));
            this.ChecklistPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Infolbl = new System.Windows.Forms.Label();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Okbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChecklistPanel
            // 
            this.ChecklistPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChecklistPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChecklistPanel.Location = new System.Drawing.Point(13, 84);
            this.ChecklistPanel.Name = "ChecklistPanel";
            this.ChecklistPanel.Size = new System.Drawing.Size(273, 229);
            this.ChecklistPanel.TabIndex = 0;
            this.ChecklistPanel.WrapContents = false;
            // 
            // Infolbl
            // 
            this.Infolbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Infolbl.Location = new System.Drawing.Point(13, 13);
            this.Infolbl.Name = "Infolbl";
            this.Infolbl.Size = new System.Drawing.Size(273, 45);
            this.Infolbl.TabIndex = 1;
            this.Infolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbtn.Location = new System.Drawing.Point(173, 339);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(96, 37);
            this.Cancelbtn.TabIndex = 7;
            this.Cancelbtn.Text = "&Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Okbtn
            // 
            this.Okbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Okbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Okbtn.Enabled = false;
            this.Okbtn.Location = new System.Drawing.Point(30, 339);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(96, 37);
            this.Okbtn.TabIndex = 6;
            this.Okbtn.Text = "&Ok";
            this.Okbtn.UseVisualStyleBackColor = true;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // ChecklistForm
            // 
            this.AcceptButton = this.Okbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelbtn;
            this.ClientSize = new System.Drawing.Size(298, 388);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.Infolbl);
            this.Controls.Add(this.ChecklistPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(320, 444);
            this.Name = "ChecklistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ChecklistPanel;
        private System.Windows.Forms.Label Infolbl;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Okbtn;
    }
}