using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHat
{
    static class Utilities
    {
        public static int StudentAlphabeticalComparison(Student studentOne, Student studentTwo)
        {
            return string.Compare(studentOne.Name, studentTwo.Name);
        }
    }
}
