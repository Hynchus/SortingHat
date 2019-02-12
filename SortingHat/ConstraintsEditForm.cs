using System;
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
    public partial class ConstraintsEditForm : Form
    {
        private List<Constraint> constraints;

        public List<Constraint> Constraints { get => constraints; }


        private void loadSettings()
        {
            this.Location = Properties.Settings.Default.ConstraintsEditFormLocation;
            this.Size = Properties.Settings.Default.ConstraintsEditFormSize;
            this.BackColor = Properties.Settings.Default.ColourTheme;
        }

        private void saveSettings()
        {
            Properties.Settings.Default.ConstraintsEditFormLocation = this.Location;
            Properties.Settings.Default.ConstraintsEditFormSize = this.Size;
            Properties.Settings.Default.Save();
        }

        private void loadConstraints(List<Constraint> constraints)
        {
            if (constraints == null) { return; }
            foreach (Constraint constraint in constraints)
            {
                addConstraintGroup(constraint);
            }
        }

        public ConstraintsEditForm(List<Student> students, List<Constraint> constraints)
        {
            InitializeComponent();
            StudentListbox.updateStudentList(students);
            loadConstraints(constraints);
        }

        private void gatherConstraints()
        {
            this.constraints = new List<Constraint>();
            foreach (Control control in ConstraintGroupsPanel.Controls)
            {
                try
                {
                    StudentList list = (StudentList)control;
                    if (list.Students.Count > 1)
                    {
                        constraints.Add(new Constraint(list.Students));
                    }
                }
                catch { /* Button control, skip */ }
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            gatherConstraints();
            this.Close();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConstraintsEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void ConstraintsEditForm_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void addConstraintGroup(Constraint constraint = null)
        {
            StudentList newConstraintGroup = new StudentList();
            newConstraintGroup.Size = NewConstraintbtn.Size;
            newConstraintGroup.Margin = NewConstraintbtn.Margin;
            if (constraint != null)
            {
                newConstraintGroup.updateStudentList(constraint.Students);
            }
            ConstraintGroupsPanel.Controls.Add(newConstraintGroup);
            ConstraintGroupsPanel.Controls.SetChildIndex(NewConstraintbtn, ConstraintGroupsPanel.Controls.Count - 1);
        }

        private void NewConstraintbtn_Click(object sender, EventArgs e)
        {
            addConstraintGroup();
        }
    }
}
