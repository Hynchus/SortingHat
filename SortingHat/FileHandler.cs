using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;
using Xceed.Words.NET;

namespace SortingHat
{
    static class FileHandler
    {
        public const string DATA_FILE_EXTENSION = ".shd";
        public const string CLASS_FILE_EXTENSION = ".shc";
        private static string DATA_SAVE_FOLDER = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SortingHat");

        private static System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();


        private static void createRequiredDirectories()
        {
            Directory.CreateDirectory(DATA_SAVE_FOLDER);
        }

        static FileHandler()
        {
            createRequiredDirectories();
        }

        public static List<string> getSavedClassNames()
        {
            List<string> classNames = new List<string>();
            try
            {
                foreach (string filename in Directory.GetFiles(DATA_SAVE_FOLDER))
                {
                    if (Path.GetExtension(filename) == CLASS_FILE_EXTENSION)
                    {
                        classNames.Add(Path.GetFileNameWithoutExtension(filename));
                    }
                }
            }
            catch { /* Probably Directory doesn't exist, we ignore */ }
            return classNames;
        }

        public static bool classExists(string className)
        {
            return File.Exists(getClassFileName(className));
        }

        public static string getClassName(string classFilePath)
        {
            return Path.GetFileNameWithoutExtension(classFilePath);
        }

        private static string getClassFileName(string className)
        {
            return Path.Combine(DATA_SAVE_FOLDER, string.Join(string.Empty, className, CLASS_FILE_EXTENSION));
        }

        public static void saveClass(Class givenClass)
        {
            using (Stream stream = File.Open(getClassFileName(givenClass.Name), FileMode.Create))
            {
                binaryFormatter.Serialize(stream, givenClass);
            }
        }

        public static Class getClass(string className)
        {
            Class wantedClass = null;
            try
            {
                using (Stream stream = File.Open(getClassFileName(className), FileMode.Open))
                {
                    wantedClass = (Class)binaryFormatter.Deserialize(stream);
                }
            }
            catch (Exception exception) {
                Console.Write(exception.Message);
                /* We hit this with one file. Possibly file corruption? Haven't been able to replicate it */
            }
            return wantedClass;
        }

        public static void deleteClass(string className)
        {
            try
            {
                File.Delete(getClassFileName(className));
            }
            catch { /* File likely doesn't exist already, we'll ignore */ }
        }

        public static bool importClassFile(string filePath, bool overwrite = false)
        {
            string className = Path.GetFileNameWithoutExtension(filePath);
            string targetPath = getClassFileName(className);
            if (File.Exists(targetPath))
            {
                if (overwrite)
                {
                    File.Delete(targetPath);
                }
                else
                {
                    return false;
                }
            }
            File.Copy(filePath, targetPath);
            return true;
        }

        public static bool exportClassFile(string className, string folderPath, bool overwrite = false)
        {
            string classFilePath = getClassFileName(className);
            string targetPath = Path.Combine(folderPath, Path.GetFileName(classFilePath));
            if (File.Exists(targetPath))
            {
                if (overwrite)
                {
                    File.Delete(targetPath);
                }
                else
                {
                    return false;
                }
            }
            File.Copy(classFilePath, targetPath);
            return true;
        }

        public static void setSharingFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                folderPath = Path.GetDirectoryName(folderPath);
            }
            if (!Directory.Exists(folderPath)) { return; }
            Properties.Settings.Default.SharingFolder = folderPath;
            Properties.Settings.Default.Save();
        }

        public static string getSharingFolder()
        {
            string folderPath = Properties.Settings.Default.SharingFolder;
            if (!Directory.Exists(folderPath))
            {
                folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
            }
            return folderPath;
        }

        public static void exportGroupingToWord(string filepath, Grouping grouping, string classname)
        {
            DocX document = DocX.Create(filepath);
            Formatting groupingNameFormat = new Formatting();
            groupingNameFormat.FontFamily = new Xceed.Words.NET.Font("Tahoma");
            groupingNameFormat.Size = 20;
            Formatting classNameFormat = new Formatting();
            classNameFormat.FontFamily = new Xceed.Words.NET.Font("Tahoma");
            classNameFormat.Size = 10;
            Formatting groupNameFormat = new Formatting();
            groupNameFormat.FontFamily = new Xceed.Words.NET.Font("Verdana");
            groupNameFormat.Size = 14;
            Formatting groupListFormat = new Formatting();
            groupListFormat.FontFamily = new Xceed.Words.NET.Font("Trebuchet MS");
            groupListFormat.Size = 12;
            document.InsertParagraph(grouping.Name + Environment.NewLine, false, groupingNameFormat).Alignment = Alignment.center;
            document.InsertParagraph(classname + Environment.NewLine, false, classNameFormat).Alignment = Alignment.right;
            foreach (Group group in grouping.groups)
            {
                if (group.Colour == SystemColors.Control)
                {
                    groupNameFormat.FontColor = Color.Black;
                }
                else
                {
                    groupNameFormat.FontColor = group.Colour;
                }
                string groupName = group.Name;
                string bulletPoint = " - ";
                string groupList = bulletPoint + string.Join(Environment.NewLine + bulletPoint, group.getStudentNames());
                document.InsertParagraph(groupName, false, groupNameFormat);
                document.InsertParagraph(groupList + Environment.NewLine, false, groupListFormat);
            }

            document.Save();
        }
    }
}
