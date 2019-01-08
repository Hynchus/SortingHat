namespace SortingHat
{
    partial class ClassEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassEditForm));
            this.ClassNamelbl = new System.Windows.Forms.Label();
            this.ClassNametxtbox = new System.Windows.Forms.TextBox();
            this.StudentNamestxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassNamelbl
            // 
            this.ClassNamelbl.AutoSize = true;
            this.ClassNamelbl.Location = new System.Drawing.Point(45, 35);
            this.ClassNamelbl.Name = "ClassNamelbl";
            this.ClassNamelbl.Size = new System.Drawing.Size(94, 20);
            this.ClassNamelbl.TabIndex = 0;
            this.ClassNamelbl.Text = "Class Name";
            // 
            // ClassNametxtbox
            // 
            this.ClassNametxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassNametxtbox.Location = new System.Drawing.Point(49, 58);
            this.ClassNametxtbox.Name = "ClassNametxtbox";
            this.ClassNametxtbox.Size = new System.Drawing.Size(250, 26);
            this.ClassNametxtbox.TabIndex = 1;
            this.ClassNametxtbox.TextChanged += new System.EventHandler(this.ClassNametxtbox_TextChanged);
            // 
            // StudentNamestxtbox
            // 
            this.StudentNamestxtbox.AcceptsReturn = true;
            this.StudentNamestxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentNamestxtbox.Location = new System.Drawing.Point(49, 148);
            this.StudentNamestxtbox.Multiline = true;
            this.StudentNamestxtbox.Name = "StudentNamestxtbox";
            this.StudentNamestxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StudentNamestxtbox.Size = new System.Drawing.Size(250, 185);
            this.StudentNamestxtbox.TabIndex = 2;
            this.StudentNamestxtbox.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Names   ( line separated )";
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Savebtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Savebtn.Enabled = false;
            this.Savebtn.Location = new System.Drawing.Point(51, 390);
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
            this.Cancelbtn.Location = new System.Drawing.Point(204, 390);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(96, 37);
            this.Cancelbtn.TabIndex = 5;
            this.Cancelbtn.Text = "&Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // ClassEditForm
            // 
            this.AcceptButton = this.Savebtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelbtn;
            this.ClientSize = new System.Drawing.Size(350, 451);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentNamestxtbox);
            this.Controls.Add(this.ClassNametxtbox);
            this.Controls.Add(this.ClassNamelbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(372, 446);
            this.Name = "ClassEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Class";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassEditForm_FormClosing);
            this.Load += new System.EventHandler(this.ClassEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClassNamelbl;
        private System.Windows.Forms.TextBox ClassNametxtbox;
        private System.Windows.Forms.TextBox StudentNamestxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Cancelbtn;
    }
}