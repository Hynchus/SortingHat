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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatingPlanForm));
            this.Unseatbtn = new System.Windows.Forms.Button();
            this.Seatbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.HelpBox = new System.Windows.Forms.PictureBox();
            this.StudentListbox = new SortingHat.StudentList();
            this.ClassroomSpotTable = new System.Windows.Forms.TableLayoutPanel();
            this.GridHSlider = new System.Windows.Forms.TrackBar();
            this.GridVSlider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.HelpBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // Unseatbtn
            // 
            this.Unseatbtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Unseatbtn.Location = new System.Drawing.Point(265, 231);
            this.Unseatbtn.Name = "Unseatbtn";
            this.Unseatbtn.Size = new System.Drawing.Size(75, 60);
            this.Unseatbtn.TabIndex = 4;
            this.Unseatbtn.Text = "Unseat\r\n <<<";
            this.Unseatbtn.UseVisualStyleBackColor = true;
            // 
            // Seatbtn
            // 
            this.Seatbtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Seatbtn.Location = new System.Drawing.Point(265, 165);
            this.Seatbtn.Name = "Seatbtn";
            this.Seatbtn.Size = new System.Drawing.Size(75, 60);
            this.Seatbtn.TabIndex = 5;
            this.Seatbtn.Text = " Seat\r\n >>>";
            this.Seatbtn.UseVisualStyleBackColor = true;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbtn.Location = new System.Drawing.Point(563, 401);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(96, 37);
            this.Cancelbtn.TabIndex = 9;
            this.Cancelbtn.Text = "&Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Savebtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Savebtn.Location = new System.Drawing.Point(443, 401);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(96, 37);
            this.Savebtn.TabIndex = 8;
            this.Savebtn.Text = "&Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            // 
            // HelpBox
            // 
            this.HelpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpBox.Image = global::SortingHat.Properties.Resources.Help;
            this.HelpBox.Location = new System.Drawing.Point(1053, 401);
            this.HelpBox.Name = "HelpBox";
            this.HelpBox.Size = new System.Drawing.Size(37, 37);
            this.HelpBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HelpBox.TabIndex = 10;
            this.HelpBox.TabStop = false;
            // 
            // StudentListbox
            // 
            this.StudentListbox.AllowDrop = true;
            this.StudentListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StudentListbox.DragMethod = System.Windows.Forms.DragDropEffects.Move;
            this.StudentListbox.Location = new System.Drawing.Point(13, 13);
            this.StudentListbox.Name = "StudentListbox";
            this.StudentListbox.ReceiveDrop = true;
            this.StudentListbox.Size = new System.Drawing.Size(246, 425);
            this.StudentListbox.TabIndex = 2;
            // 
            // ClassroomSpotTable
            // 
            this.ClassroomSpotTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassroomSpotTable.ColumnCount = 2;
            this.ClassroomSpotTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassroomSpotTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassroomSpotTable.Location = new System.Drawing.Point(346, 63);
            this.ClassroomSpotTable.Name = "ClassroomSpotTable";
            this.ClassroomSpotTable.RowCount = 2;
            this.ClassroomSpotTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassroomSpotTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassroomSpotTable.Size = new System.Drawing.Size(697, 332);
            this.ClassroomSpotTable.TabIndex = 11;
            // 
            // GridHSlider
            // 
            this.GridHSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridHSlider.AutoSize = false;
            this.GridHSlider.LargeChange = 1;
            this.GridHSlider.Location = new System.Drawing.Point(346, 13);
            this.GridHSlider.Minimum = 2;
            this.GridHSlider.Name = "GridHSlider";
            this.GridHSlider.Size = new System.Drawing.Size(706, 44);
            this.GridHSlider.TabIndex = 1;
            this.GridHSlider.Value = 10;
            this.GridHSlider.Scroll += new System.EventHandler(this.GridHSlider_Scroll);
            // 
            // GridVSlider
            // 
            this.GridVSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridVSlider.AutoSize = false;
            this.GridVSlider.LargeChange = 1;
            this.GridVSlider.Location = new System.Drawing.Point(1049, 53);
            this.GridVSlider.Minimum = 2;
            this.GridVSlider.Name = "GridVSlider";
            this.GridVSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.GridVSlider.Size = new System.Drawing.Size(41, 342);
            this.GridVSlider.TabIndex = 12;
            this.GridVSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.GridVSlider.Value = 10;
            this.GridVSlider.Scroll += new System.EventHandler(this.GridVSlider_Scroll);
            // 
            // SeatingPlanForm
            // 
            this.AcceptButton = this.Savebtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelbtn;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.GridVSlider);
            this.Controls.Add(this.GridHSlider);
            this.Controls.Add(this.ClassroomSpotTable);
            this.Controls.Add(this.HelpBox);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Seatbtn);
            this.Controls.Add(this.Unseatbtn);
            this.Controls.Add(this.StudentListbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(768, 345);
            this.Name = "SeatingPlanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seating Plan";
            this.Load += new System.EventHandler(this.SeatingPlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HelpBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private StudentList StudentListbox;
        private System.Windows.Forms.Button Unseatbtn;
        private System.Windows.Forms.Button Seatbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.PictureBox HelpBox;
        private System.Windows.Forms.TableLayoutPanel ClassroomSpotTable;
        private System.Windows.Forms.TrackBar GridHSlider;
        private System.Windows.Forms.TrackBar GridVSlider;
    }
}