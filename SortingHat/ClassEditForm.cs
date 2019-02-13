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
    public partial class ClassEditForm : Form
    {
        public string className;
        public List<string> studentNames;

        private void loadFields(string className)
        {
            Class existingClass = Model.getClass(className);
            ClassNametxtbox.Text = existingClass.Name;
            StudentNamestxtbox.Text = string.Join(Environment.NewLine, existingClass.Students.Select(s => s.Name).ToList());
        }

        private void loadSettings()
        {
            this.Location = Properties.Settings.Default.ClassEditFormLocation;
            this.Size = Properties.Settings.Default.ClassEditFormSize;
            this.BackColor = Properties.Settings.Default.ColourTheme;
        }

        private void saveSettings()
        {
            Properties.Settings.Default.ClassEditFormLocation = this.Location;
            Properties.Settings.Default.ClassEditFormSize = this.Size;
            Properties.Settings.Default.Save();
        }

        public ClassEditForm(string existingClassName = null)
        {
            InitializeComponent();
            className = existingClassName;
        }

        private void ClassEditForm_Load(object sender, EventArgs e)
        {
            if (className != null)
            {
                loadFields(className);
            }
            loadSettings();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            this.className = ClassNametxtbox.Text;
            this.studentNames = StudentNamestxtbox.Text.Split('\n').ToList<string>();
            this.Close();
        }

        private void toggleValidClassName(bool toggle)
        {
            Savebtn.Enabled = toggle;
            if (toggle)
            {
                ClassNamelbl.ForeColor = Color.Green;
            }
            else
            {
                ClassNamelbl.ForeColor = Color.Red;
            }
        }

        private void ClassNametxtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ClassNametxtbox.Text) || (ClassNametxtbox.Text != className && Model.getClassNames().Contains(ClassNametxtbox.Text)))
            {
                toggleValidClassName(false);
            }
            else
            {
                toggleValidClassName(true);

            }
            this.Text = ClassNametxtbox.Text;
        }

        private void ClassEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }
    }
}
