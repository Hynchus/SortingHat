using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SortingHat
{
    [Serializable]
    public class Class
    {
        private string name;
        private List<Student> students;
        private List<Constraint> constraints;
        private List<Grouping> groupings;
        private string currentGroupingName = "";

        public string Name { get => name; }
        public List<Student> Students { get => students; }
        public List<Constraint> Constraints { get => constraints; }
        public List<Grouping> Groupings { get => groupings; }
        public string CurrentGroupingName 
        {
            get => currentGroupingName;
            set 
            {
                if (currentGroupingName != value)
                {
                    currentGroupingName = value;
                    Model.invokeCurrentGroupingChanged();
                }
            }
        }

        public Class(string name)
        {
            this.name = name;
            this.students = new List<Student>();
            this.constraints = new List<Constraint>();
            this.groupings = new List<Grouping>();
        }

        public void renameClass(string name)
        {
            this.name = name;
        }

        public void addGrouping(Grouping grouping)
        {
            grouping.updateStudents(ref this.students);
            Groupings.Add(grouping);
        }

        public void updateGrouping(string originalGroupingName, string newGroupingName, int newGroupCount)
        {
            Grouping originalGrouping = getGrouping(originalGroupingName);
            originalGrouping.Name = newGroupingName;
            if (currentGroupingName == originalGroupingName)
            {
                currentGroupingName = newGroupingName;
            }
            if (originalGrouping.changeGroupCount(newGroupCount))
            {
                originalGrouping.shuffleGroups(ref this.students);
            }
            if (Model.currentClass == this && this.currentGroupingName == newGroupingName)
            {
                Model.invokeCurrentGroupingChanged();
            }
        }

        public Grouping getGrouping(string name)
        {
            return Groupings.Find(g => g.Name == name);
        }

        public Grouping getCurrentGrouping()
        {
            try
            {
                return Groupings.Find(g => g.Name == this.currentGroupingName);
            }
            catch { /* There is no current grouping */ }
            return null;
        }

        public void shuffleGrouping(string groupingName)
        {
            Groupings.Find(g => g.Name == groupingName).shuffleGroups(ref this.students);
            if (groupingName == currentGroupingName)
            {
                Model.invokeCurrentGroupingChanged();
            }
        }

        public void removeGrouping(string name)
        {
            Groupings.Remove(getGrouping(name));
            if (currentGroupingName == name)
            {
                CurrentGroupingName = "";
            }
        }

        private void sortStudents()
        {
            this.Students.Sort(Utilities.StudentAlphabeticalComparison);
        }

        public void addStudent(Student student)
        {
            Students.Add(student);
            foreach (Grouping grouping in Groupings)
            {
                grouping.addStudent(student);
            }
            sortStudents();
        }

        public void removeStudent(Student student)
        {
            Students.Remove(student);
            foreach (Grouping grouping in Groupings)
            {
                grouping.removeStudent(student);
            }
        }

        public void updateStudents(List<Student> students)
        {
            this.students = students;
            foreach (Grouping grouping in Groupings)
            {
                grouping.updateStudents(ref students);
            }
            sortStudents();
        }

        public void updateConstraints(List<Constraint> constraints)
        {
            this.constraints = constraints;
        }
    }


    [Serializable]
    public class Grouping
    {
        private string name;

        private List<Group> groups;

        public string Name { get => name; set => name = value; }
        public List<Group> Groups { get => groups; }

        public Grouping(string name, int groupCount)
        {
            this.name = name;
            changeGroupCount(groupCount);
        }

        public bool changeGroupCount(int groupCount)
        {
            if (groupCount <= 0) { throw new ArgumentOutOfRangeException("groupCount", "Group count cannot be equal to or less than 0."); }
            if (Groups != null && groupCount == Groups.Count) { return false; }
            if (Groups == null) { this.groups = new List<Group>(); }
            while (Groups.Count > groupCount)
            {
                Groups.RemoveAt(Groups.Count - 1);
            }
            while (Groups.Count < groupCount)
            {
                string groupName = "Group " + (Groups.Count + 1).ToString();
                Groups.Add(new Group(groupName));
            }
            return true;
        }

        public void shuffleGroups(ref List<Student> students)
        {
            foreach (Group group in Groups)
            {
                group.clearStudents();
            }
            updateStudents(ref students);
        }

        public bool containsStudent(Student student)
        {
            foreach (Group group in this.groups)
            {
                try
                {
                    group.Students.Where(s => s.Name == student.Name).First();
                    return true;
                }
                catch
                {
                    // Group doesn't contain student
                }
            }
            return false;
        }

        public List<Student> getMissingStudents(ref List<Student> students)
        {
            List<Student> missingStudents = new List<Student>();
            foreach (Group group in Groups)
            {
                foreach (Student student in group.Students)
                {
                    try
                    {
                        students.Where(s => s.Name == student.Name).First();   // Throws if there isn't a match
                    }
                    catch
                    {
                        missingStudents.Add(student);
                    }
                }
            }
            return missingStudents;
        }

        public List<Student> getNewStudents(ref List<Student> students)
        {
            List<Student> newStudents = new List<Student>();
            foreach (Student student in students)
            {
                if (!this.containsStudent(student))
                {
                    newStudents.Add(student);
                }
            }
            return newStudents;
        }

        public void removeStudent(Student student)
        {
            foreach (Group group in Groups)
            {
                if (group.removeStudent(student))
                {
                    break;
                }
            }
        }

        public void removeStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                removeStudent(student);
            }
        }

        private Group getSmallestGroup()
        {
            Group smallestGroup = null;
            foreach (Group group in Groups)
            {
                if (smallestGroup == null || (group.getStudentCount() < smallestGroup.getStudentCount()))
                {
                    smallestGroup = group;
                }
            }
            return smallestGroup;
        }

        public void addStudent(Student student)
        {
            getSmallestGroup().addStudent(student);
        }

        public void addStudents(List<Student> students)
        {
            students.Shuffle();
            foreach (Student student in students)
            {
                addStudent(student);
            }
        }

        public void updateStudents(ref List<Student> students)
        {
            removeStudents(getMissingStudents(ref students));
            addStudents(getNewStudents(ref students));
        }
    }


    [Serializable]
    public class Group
    {
        private string name;
        private Color colour = SystemColors.Control;
        private List<Student> students;

        public string Name { get => name; set => name = value; }
        public Color Colour { get => colour; set => colour = value; }
        public List<Student> Students { get => students; set => students = value; }

        public Group(string groupName, List<Student> students = null)
        {
            Name = groupName;
            if (students == null)
            {
                this.Students = new List<Student>();
            }
            else
            {
                this.Students = students;
            }
        }

        public int getStudentCount()
        {
            return Students.Count;
        }

        public bool addStudent(Student student)
        {
            if (Students.Contains(student))
            {
                return false;
            }
            Students.Add(student);
            return true;
        }

        public bool removeStudent(Student student)
        {
            return Students.Remove(student);
        }

        public void removeStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                removeStudent(student);
            }
        }

        public bool containsStudent(Student student)
        {
            return Students.Contains(student);
        }

        public List<string> getStudentNames()
        {
            return Students.Select(s => s.Name).ToList<string>();
        }

        public void clearStudents()
        {
            Students.Clear();
        }
    }

    [Serializable]
    public class Constraint
    {
        private List<Student> students;

        public List<Student> Students { get => students; }


        public void updateConstraint(List<Student> students)
        {
            this.students = students;
        }

        public Constraint(List<Student> students)
        {
            updateConstraint(students);
        }
    }

    [Serializable]
    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.Name = name;
        }

        public string Name 
        {
            get => name;
            set => name = value.Trim();
        }
    }
}
