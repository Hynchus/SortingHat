using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingHat
{
    public partial class GroupDisplay : UserControl
    {
        private static ColorDialog GroupColourDialog = null;
        private Color defaultGroupNameBackColor = SystemColors.Control;
        private Color highlightColor = SystemColors.ControlLight;
        private Group group = null;

        public GroupDisplay()
        {
            InitializeComponent();
            if (GroupColourDialog == null) { GroupColourDialog = new ColorDialog(); }
            defaultGroupNameBackColor = GroupNameTextbox.BackColor;
        }

        private void refreshColours()
        {
            this.BackColor = group.Colour;
            GroupNameTextbox.BackColor = group.Colour;
            GroupColourbtn.BackColor = group.Colour;
            float brightness = group.Colour.GetBrightness();
            if (group.Colour.GetBrightness() > 0.49f)
            {
                GroupNameTextbox.ForeColor = Color.Black;
            }
            else
            {
                GroupNameTextbox.ForeColor = Color.White;
            }
        }

        private void refreshCosmetics()
        {
            refreshColours();
        }

        public void displayGroup(Group group)
        {
            this.group = group;
            GroupNameTextbox.Text = group.Name;
            StudentList.updateStudentList(group.Students);
            refreshCosmetics();
        }

        private void GroupNameTextbox_TextChanged(object sender, EventArgs e)
        {
            group.Name = GroupNameTextbox.Text;
        }

        private void GroupNameTextbox_MouseEnter(object sender, EventArgs e)
        {
            GroupNameTextbox.BackColor = highlightColor;
        }

        private void GroupNameTextbox_MouseLeave(object sender, EventArgs e)
        {
            GroupNameTextbox.BackColor = group.Colour;
        }

        private void GroupColourbtn_Click(object sender, EventArgs e)
        {
            if (GroupColourDialog.ShowDialog() == DialogResult.OK)
            {
                group.Colour = GroupColourDialog.Color;
                refreshCosmetics();
            }
        }

        public Group getCurrentGroup()
        {
            return new Group(this.group.Name, StudentList.Students);
        }

        public List<Tuple<Student, StudentList.Change>> getChanges()
        {
            return this.StudentList.getChanges();
        }

        private void GroupColourbtn_MouseEnter(object sender, EventArgs e)
        {
            GroupColourbtn.BackColor = highlightColor;
        }

        private void GroupColourbtn_MouseLeave(object sender, EventArgs e)
        {
            GroupColourbtn.BackColor = group.Colour;
        }
    }
}
