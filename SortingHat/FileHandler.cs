﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortingHat
{
    static class FileHandler
    {
        private const string DATA_FILE_EXTENSION = ".shd";
        private const string CLASS_FILE_EXTENSION = ".shc";
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
            catch
            {
                // Probably Directory doesn't exist, we ignore
            }
            return classNames;
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
            catch
            {
                // Likely a missing file, we'll ignore
            }
            return wantedClass;
        }

        public static void deleteClass(string className)
        {
            try
            {
                File.Delete(getClassFileName(className));
            }
            catch
            {
                // File likely doesn't exist already, we'll ignore
            }
        }
    }
}