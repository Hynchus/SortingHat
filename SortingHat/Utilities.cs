using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SortingHat
{
    static class Utilities
    {
        public static int StudentAlphabeticalComparison(Student studentOne, Student studentTwo)
        {
            return string.Compare(studentOne.Name, studentTwo.Name);
        }

        public static string CleanInput(string input)  // Copied from Microsoft Docs (How To: Strip Invalid Characters from a String)
        {
            try
            {
                return Regex.Replace(input, @"[^\w\.@-]", "", RegexOptions.None, TimeSpan.FromSeconds(1.5)).Trim();
            }
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }
    }
}
