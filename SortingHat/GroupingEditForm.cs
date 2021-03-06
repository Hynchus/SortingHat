﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingHat
{
    public partial class GroupingEditForm : Form
    {
        private int originalGroupCount = 0;

        public string groupingName = "";
        public int groupCount = 0;


        private void loadSettings()
        {
            if (Properties.Settings.Default.GroupingEditFormSize != new Size(-1, -1))
            {
                this.Location = Properties.Settings.Default.GroupingEditFormLocation;
                this.Size = Properties.Settings.Default.GroupingEditFormSize;
            }
            this.BackColor = Properties.Settings.Default.ColourTheme;
            this.WindowState = (FormWindowState)Properties.Settings.Default.GroupingEditFormWindowState;
        }

        private void saveSettings()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.GroupingEditFormLocation = this.Location;
                Properties.Settings.Default.GroupingEditFormSize = this.Size;
            }
            Properties.Settings.Default.GroupingEditFormWindowState = (int)this.WindowState;
            Properties.Settings.Default.Save();
        }

        public GroupingEditForm(string groupingName = "")
        {
            InitializeComponent();
            this.groupingName = groupingName;
        }

        private void GroupingEditForm_Load(object sender, EventArgs e)
        {
            loadSettings();
            Grouping grouping = Model.currentClass.getGrouping(groupingName);
            if (grouping != null)
            {
                GroupingNametxtbox.Text = grouping.Name;
                GroupCountTrackbar.Value = grouping.Groups.Count;
                originalGroupCount = grouping.Groups.Count;
            }
        }

        private void validateGrouping()
        {
            // Ugly ugly, very ugly
            Savebtn.Enabled = (GroupingNamelbl.ForeColor == Color.Green);
        }

        private void GroupingNametxtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GroupingNametxtbox.Text) || (GroupingNametxtbox.Text != groupingName && Model.currentClass.Groupings.Exists(g => g.Name == GroupingNametxtbox.Text)))
            {
                GroupingNamelbl.ForeColor = Color.Red;
                validateGrouping();
            }
            else
            {
                GroupingNamelbl.ForeColor = Color.Green;
                validateGrouping();
            }
            this.Text = GroupingNametxtbox.Text;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            this.groupingName = Utilities.CleanInput(GroupingNametxtbox.Text);
            this.groupCount = GroupCountTrackbar.Value;
            this.Close();
        }

        private void GroupingEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void GroupCountTrackbar_ValueChanged(object sender, EventArgs e)
        {
            GroupCountNumberlbl.Text = GroupCountTrackbar.Value.ToString();
            if (originalGroupCount != 0 && GroupCountTrackbar.Value != originalGroupCount)
            {
                ShuffleWarninglbl.Visible = true;
            }
            else
            {
                ShuffleWarninglbl.Visible = false;
            }
        }
    }
}
