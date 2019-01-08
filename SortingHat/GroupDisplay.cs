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
        private Color defaultGroupNameBackColor = SystemColors.Control;
        private Group group = null;

        public GroupDisplay()
        {
            InitializeComponent();
            defaultGroupNameBackColor = GroupNameTextbox.BackColor;
        }

        private void GroupDisplay_Load(object sender, EventArgs e)
        {

        }

        private int StudentAlphabeticalComparison(Student studentOne, Student studentTwo)
        {
            return string.Compare(studentOne.Name, studentTwo.Name);
        }

        public void displayGroup(Group group)
        {
            this.group = group;
            GroupNameTextbox.Text = group.Name;
            List<Student> studentList = group.getStudents();
            studentList.Sort(StudentAlphabeticalComparison);
            foreach (Student student in studentList)
            {
                GroupListbox.Items.Add(student.Name);
            }
        }

        private void GroupNameTextbox_TextChanged(object sender, EventArgs e)
        {
            group.Name = GroupNameTextbox.Text;
        }

        private void GroupNameTextbox_MouseEnter(object sender, EventArgs e)
        {
            //GroupNameTextbox.BorderStyle = BorderStyle.FixedSingle;
            //GroupNameTextbox.ReadOnly = false;
            GroupNameTextbox.BackColor = SystemColors.ControlLight;
        }

        private void GroupNameTextbox_MouseLeave(object sender, EventArgs e)
        {
            //GroupNameTextbox.BorderStyle = BorderStyle.None;
            //GroupNameTextbox.ReadOnly = true;
            GroupNameTextbox.BackColor = defaultGroupNameBackColor;
        }
    }
}
