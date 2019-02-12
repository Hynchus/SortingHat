using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHat
{
    static class Model
    {
        private static Random rng = new Random();
        private static EventHandler CurrentClassChanged = delegate { };
        private static EventHandler CurrentGroupingChanged = delegate { };

        private static string currentClassOriginalName = null;
        public static Class currentClass = null;


        public static void Shuffle<T>(this IList<T> list)
        {
            int index = list.Count - 1;
            while (index >= 0)
            {
                int swapIndex = rng.Next(index);
                T hold = list[swapIndex];
                list[swapIndex] = list[index];
                list[index] = hold;
                index--;
            }
        }

        public static void subscribeToCurrentClassChanged(EventHandler subscriber)
        {
            CurrentClassChanged += subscriber;
        }

        public static void unsubscribeFromCurrentClassChanged(EventHandler subscriber)
        {
            CurrentClassChanged -= subscriber;
        }

        public static void subscribeToCurrentGroupingChanged(EventHandler subscriber)
        {
            CurrentGroupingChanged += subscriber;
        }

        public static void invokeCurrentGroupingChanged()
        {
            CurrentGroupingChanged(null, null);
        }

        public static void unsubscribeFromCurrentGroupingChanged(EventHandler subscriber)
        {
            CurrentGroupingChanged -= subscriber;
        }

        public static void createClass(string className, List<string> studentNames)
        {
            Class newClass = new Class(className);
            List<Student> students = new List<Student>();
            foreach (string studentName in studentNames)
            {
                if (!string.IsNullOrWhiteSpace(studentName))
                {
                    students.Add(new Student(studentName));
                }
            }
            newClass.updateStudents(students);
            FileHandler.saveClass(newClass);
        }

        public static void saveCurrentClass()
        {
            if (currentClass == null) { return; }
            FileHandler.saveClass(currentClass);
        }

        public static void setCurrentClass(string className)
        {
            Class newClass = getClass(className);
            if (newClass == null) { return; }
            saveCurrentClass();
            currentClass = newClass;
            currentClassOriginalName = newClass.Name;
            CurrentClassChanged.Invoke(null, null);
        }

        public static void updateCurrentClass(string className, List<string> studentNames)
        {
            currentClass.renameClass(className);
            List<Student> students = new List<Student>();
            foreach (string studentName in studentNames)
            {
                students.Add(new Student(studentName));
            }
            currentClass.updateStudents(students);
            FileHandler.deleteClass(currentClassOriginalName);
            FileHandler.saveClass(currentClass);
            currentClassOriginalName = currentClass.Name;
            CurrentClassChanged.Invoke(null, null);
        }

        public static Class getClass(string className)
        {
            return FileHandler.getClass(className);
        }

        public static void deleteCurrentClass()
        {
            FileHandler.deleteClass(currentClass.Name);
            currentClass = null;
            currentClassOriginalName = "";
            CurrentClassChanged.Invoke(null, null);
        }

        public static List<string> getClassNames()
        {
            return FileHandler.getSavedClassNames();
        }

        public static void createGrouping(string className, string groupingName, int groupCount)
        {
            Class targetClass = getClass(className);
            Grouping newGrouping = new Grouping(groupingName, groupCount);
            targetClass.addGrouping(newGrouping);
            FileHandler.saveClass(targetClass);
            if (targetClass.Name == currentClass.Name)
            {
                currentClass = getClass(targetClass.Name);
                CurrentClassChanged.Invoke(null, null);
            }
        }
    }
}
