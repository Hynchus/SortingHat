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
    public partial class StudentList : UserControl
    {
        public enum Change { Added, Removed }
        private bool currentlyDragging = false;
        private DragDropEffects dragType = DragDropEffects.Move;
        private bool receiveDrop = true;
        private List<Student> students;
        private List<Tuple<Student, Change>> changes = new List<Tuple<Student, Change>>();

        public DragDropEffects DragMethod { get => dragType; set => dragType = value; }
        public List<Student> Students { get => students; }
        public bool ReceiveDrop { get => receiveDrop; set => receiveDrop = value; }

        public StudentList()
        {
            InitializeComponent();
            ListBox.DisplayMember = "Name";
            ListBox.ValueMember = "Name";
            updateStudentList();
        }

        private void refreshStudentList()
        {
            this.Students.Sort(Utilities.StudentAlphabeticalComparison);
            ListBox.Items.Clear();
            foreach (Student student in this.Students)
            {
                ListBox.Items.Add(student);
            }
        }

        private void clearChanges()
        {
            changes.Clear();
        }

        public void updateStudentList(List<Student> students = null)
        {
            if (students == null)
            {
                this.students = new List<Student>();
            }
            else
            {
                this.students = students;
            }
            refreshStudentList();
        }

        private void recordChange(Student student, Change change)
        {
            try
            {
                Tuple<Student, Change> existingChange = changes.Where(c => c.Item1 == student).First();
                if (existingChange.Item2 != change)
                {
                    changes.Remove(existingChange);
                }
                else
                {
                    changes.Add(new Tuple<Student, Change>(student, change));
                }
            }
            catch
            {
                changes.Add(new Tuple<Student, Change>(student, change));
            }
        }

        public void appendStudentList(List<Student> students)
        {
            foreach (Student student in students)
            {
                if (this.students.Contains(student)) { continue; }
                this.students.Add(student);
                recordChange(student, Change.Added);
            }
            refreshStudentList();
        }

        public void removeStudentList(List<Student> students)
        {
            foreach (Student student in students)
            {
                if (this.students.Contains(student))
                {
                    this.students.Remove(student);
                    recordChange(student, Change.Removed);
                }
            }
            refreshStudentList();
        }

        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (ListBox.Items.Count <= 0 || ListBox.SelectedItem == null) { return; }
            int clickedIndex = ListBox.IndexFromPoint(e.X, e.Y);
            List<Student> draggedStudents = new List<Student>();
            if (ListBox.SelectedIndices.Contains(clickedIndex)) {
                foreach (Student student in ListBox.SelectedItems)
                {
                    draggedStudents.Add(student);
                }
            }
            else
            {
                return;
            }
            this.currentlyDragging = true;
            DragDropEffects dragResult = DoDragDrop(draggedStudents, this.dragType);
            if (dragResult == DragDropEffects.All)
            {
                if (this.dragType == DragDropEffects.All || this.dragType == DragDropEffects.Move)
                {
                    removeStudentList(draggedStudents);
                }
            }
            this.currentlyDragging = false;
        }

        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (this.currentlyDragging) { return; }
            if (!e.Data.GetDataPresent(typeof(List<Student>))) { return; }
            e.Effect = DragDropEffects.All;
        }

        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(List<Student>))) { return; }
            if (!receiveDrop) { return; }
            List<Student> newStudents = (List<Student>)e.Data.GetData(typeof(List<Student>));
            appendStudentList(newStudents);
        }

        public List<Tuple<Student, Change>> getChanges()
        {
            return this.changes;
        }
    }
}
