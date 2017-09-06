using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Day4_Assignments
{
    static class ConToUpper
    {
        public static void ConToUppercase(this string str)
        {
            string newstr = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
            Console.WriteLine(str);
            Console.Write(newstr);
                
        }
    }
}
