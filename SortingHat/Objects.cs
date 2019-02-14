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
            int constraintGroupNumber = 0;
            foreach (Constraint constraint in this.constraints)
            {
                foreach (Student student in constraint.Students)
                {
                    if (student.ConstraintGroups == null)
                    {
                        student.ConstraintGroups = new List<int>();
                    }
                    student.ConstraintGroups.Add(constraintGroupNumber);
                }
                constraintGroupNumber++;
            }
            foreach (Grouping grouping in this.groupings)
            {
                grouping.refreshConstraints();
            }
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

        private Group getSmallestGroup(List<int> constraintGroupsToAvoid = null)
        {
            if (constraintGroupsToAvoid == null) { constraintGroupsToAvoid = new List<int>(); }
            Group smallestGroup = null;
            Group smallestConstraintFreeGroup = null;
            foreach (Group group in this.groups)
            {
                if (smallestGroup == null || (group.getStudentCount() < smallestGroup.getStudentCount()))
                {
                    smallestGroup = group;
                }
                if (smallestConstraintFreeGroup == null || (group.getStudentCount() < smallestConstraintFreeGroup.getStudentCount()))
                {
                    bool constraintFree = true;
                    foreach (Student student in group.Students)
                    {
                        try
                        {
                            if (student.ConstraintGroups.Intersect(constraintGroupsToAvoid).Any())
                            {
                                constraintFree = false;
                                break;
                            }
                        }
                        catch { /* Student doesn't have Constraint Groups, ignore */ }
                    }
                    if (constraintFree)
                    {
                        smallestConstraintFreeGroup = group;
                    }
                }
            }
            if (smallestConstraintFreeGroup != null)
            {
                return smallestConstraintFreeGroup;
            }
            return smallestGroup;
        }

        public bool resolveConstraintConflict(Student student, Group group)
        {
            group.removeStudent(student);
            foreach (Group prospectiveGroup in this.groups)
            {
                if (prospectiveGroup == group) { continue; }
                foreach (Student prospectiveStudent in prospectiveGroup.Students.ToList())  // Create separate copy of student list to avoid iterator modified errors.
                {
                    if (prospectiveStudent.ConstraintGroups == null) { prospectiveStudent.ConstraintGroups = new List<int>(); }
                    if (prospectiveStudent.ConstraintGroups.Intersect(group.ConstraintGroups).Any()) { continue; }
                    prospectiveGroup.removeStudent(prospectiveStudent);
                    if (student.ConstraintGroups.Intersect(prospectiveGroup.ConstraintGroups).Any())
                    {
                        prospectiveGroup.addStudent(prospectiveStudent);
                        continue;
                    }
                    else // Success!
                    {
                        group.addStudent(prospectiveStudent);
                        prospectiveGroup.addStudent(student);
                        return true;
                    }
                }
            }
            group.addStudent(student);
            return false;
        }

        public void resolveConstraintConflicts()
        {
            foreach (Group group in this.groups)
            {
                foreach (Student student in group.Students.ToList())  // Create separate copy of student list to avoid modification errors.
                {
                    List<int> constraintOffences = group.getConstraintOffences();
                    try
                    {
                        if (student.ConstraintGroups.Intersect(constraintOffences).Any())
                        {
                            resolveConstraintConflict(student, group);
                        }
                    }
                    catch { /* Student doesn't have Constraint Groups, ignore */ }
                }
            }
        }

        public void addStudent(Student student)
        {
            getSmallestGroup(student.ConstraintGroups).addStudent(student);
        }

        public void addStudents(List<Student> students)
        {
            students.Shuffle();
            foreach (Student student in students)
            {
                addStudent(student);
            }
            resolveConstraintConflicts();
        }

        public void updateStudents(ref List<Student> students)
        {
            removeStudents(getMissingStudents(ref students));
            addStudents(getNewStudents(ref students));
        }

        public void refreshConstraints()
        {
            foreach (Group group in this.groups)
            {
                group.refreshConstraintGroups();
            }
        }
    }


    [Serializable]
    public class Group
    {
        private string name;
        private Color colour = SystemColors.Control;
        private List<Student> students;
        private List<int> constraintGroups = new List<int>();

        public string Name { get => name; set => name = value; }
        public Color Colour { get => colour; set => colour = value; }
        public List<Student> Students { get => students; }
        public List<int> ConstraintGroups { get => constraintGroups; }

        public Group(string groupName, List<Student> students = null)
        {
            Name = groupName;
            if (students == null)
            {
                this.students = new List<Student>();
            }
            else
            {
                addStudents(students);
            }
        }

        public int getStudentCount()
        {
            return this.students.Count;
        }

        public bool addStudent(Student student)
        {
            if (this.students.Contains(student))
            {
                return false;
            }
            this.students.Add(student);
            try
            {
                this.ConstraintGroups.AddRange(student.ConstraintGroups);
            }
            catch { /* No Constraint Groups, ignore */ }
            return true;
        }

        public void addStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                addStudent(student);
            }
        }

        public bool removeStudent(Student student)
        {
            try
            {
                foreach (int constraintGroup in student.ConstraintGroups)
                {
                    this.constraintGroups.Remove(constraintGroup);
                }
            }
            catch { /* No Constraint Groups, ignore */ }
            return this.students.Remove(student);
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
            return this.students.Contains(student);
        }

        public List<string> getStudentNames()
        {
            return this.students.Select(s => s.Name).ToList<string>();
        }

        public void clearStudents()
        {
            this.students.Clear();
            try
            {
                this.constraintGroups.Clear();
            }
            catch { /* No Constraint Groups, ignore */ }
        }

        public void refreshConstraintGroups()
        {
            this.constraintGroups = new List<int>();
            foreach (Student student in this.students)
            {
                try
                {
                    this.constraintGroups.AddRange(student.ConstraintGroups);
                }
                catch { /* Student doesn't have Constraint Groups, ignore */ }
            }
        }

        public List<int> getConstraintOffences()
        {
            List<int> constraintOffences = new List<int>();
            try
            {
                this.constraintGroups.Sort();
            }
            catch
            {
                this.constraintGroups = new List<int>();
            }
            for (int i = 0; i < this.constraintGroups.Count-1; i++)  // Don't need to check the last one
            {
                if (this.constraintGroups[i] == this.constraintGroups[i+1])
                {
                    constraintOffences.Add(this.constraintGroups[i]);
                }
            }
            return constraintOffences;
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
        private List<int> constraintGroups = new List<int>();

        public string Name { get => name; set => name = value.Trim(); }
        public List<int> ConstraintGroups { get => constraintGroups; set => constraintGroups = value; }

        public Student(string name)
        {
            this.Name = name;
        }

    }
}
