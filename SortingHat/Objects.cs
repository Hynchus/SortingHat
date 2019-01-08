using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHat
{
    [Serializable]
    public class Class
    {
        private string name;
        private List<Student> students;
        private List<Grouping> groupings;

        private string currentGroupingName = "";

        public string Name { get => name; set => name = value; }
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
            this.Name = name;
            students = new List<Student>();
            groupings = new List<Grouping>();
        }

        public void addGrouping(Grouping grouping)
        {
            grouping.updateStudents(ref students);
            groupings.Add(grouping);
        }

        public void updateGrouping(string groupingName, Grouping updatedGrouping)
        {
            Grouping originalGrouping = getGrouping(groupingName);
            originalGrouping.Name = updatedGrouping.Name;
            if (currentGroupingName == groupingName)
            {
                currentGroupingName = updatedGrouping.Name;
            }
            if (originalGrouping.changeGroupCount(updatedGrouping.groups.Count))
            {
                originalGrouping.shuffleGroups(ref students);
            }
            Model.invokeCurrentGroupingChanged();
        }

        public Grouping getGrouping(string name)
        {
            return groupings.Find(g => g.Name == name);
        }

        public ref List<Grouping> getGroupings()
        {
            return ref groupings;
        }

        public void shuffleGrouping(string groupingName)
        {
            groupings.Find(g => g.Name == groupingName).shuffleGroups(ref students);
            if (groupingName == currentGroupingName)
            {
                Model.invokeCurrentGroupingChanged();
            }
        }

        public void removeGrouping(string name)
        {
            groupings.Remove(getGrouping(name));
            if (currentGroupingName == name)
            {
                CurrentGroupingName = "";
            }
        }

        public void addStudent(Student student)
        {
            students.Add(student);
            foreach (Grouping grouping in groupings)
            {
                grouping.addStudent(student);
            }
        }

        public void removeStudent(Student student)
        {
            students.Remove(student);
            foreach (Grouping grouping in groupings)
            {
                grouping.removeStudent(student);
            }
        }

        public void updateStudents(List<Student> students)
        {
            this.students = students;
            foreach (Grouping grouping in groupings)
            {
                grouping.updateStudents(ref students);
            }
        }

        public ref List<Student> getStudents()
        {
            return ref this.students;
        }
    }


    [Serializable]
    public class Grouping
    {
        private string name;
        public List<Group> groups;

        public string Name { get => name; set => name = value; }

        public Grouping(string name, int groupCount)
        {
            this.Name = name;
            changeGroupCount(groupCount);
        }

        public bool changeGroupCount(int groupCount)
        {
            if (groupCount <= 0) { throw new ArgumentOutOfRangeException("groupCount", "Group count cannot be equal to or less than 0."); }
            if (groups != null && groupCount == groups.Count) { return false; }
            if (groups == null) { groups = new List<Group>(); }
            while (groups.Count > groupCount)
            {
                groups.RemoveAt(groups.Count - 1);
            }
            while (groups.Count < groupCount)
            {
                string groupName = "Group " + (groups.Count + 1).ToString();
                groups.Add(new Group(groupName));
            }
            return true;
        }

        public void shuffleGroups(ref List<Student> students)
        {
            foreach (Group group in groups)
            {
                group.clearStudents();
            }
            updateStudents(ref students);
        }

        public bool containsStudent(Student student)
        {
            foreach (Group group in groups)
            {
                if (group.containsStudent(student))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Student> getMissingStudents(ref List<Student> students)
        {
            List<Student> missingStudents = new List<Student>();
            foreach (Group group in groups)
            {
                foreach (Student student in group.getStudents())
                {
                    if (!students.Contains(student))
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
            foreach (Group group in groups)
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
            foreach (Group group in groups)
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
        private List<Student> students;

        public string Name { get => name; set => name = value; }

        public Group(string groupName)
        {
            Name = groupName;
            students = new List<Student>();
        }

        public int getStudentCount()
        {
            return students.Count;
        }

        public bool addStudent(Student student)
        {
            if (students.Contains(student))
            {
                return false;
            }
            students.Add(student);
            return true;
        }

        public bool removeStudent(Student student)
        {
            return students.Remove(student);
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
            return students.Contains(student);
        }

        public List<Student> getStudents()
        {
            return students;
        }

        public void clearStudents()
        {
            students.Clear();
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
