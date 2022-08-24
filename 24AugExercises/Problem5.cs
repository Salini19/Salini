using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class StrUpper
    {
        public static void UpperCase(string a)
        {
            string upper=a.ToUpper();
            Console.WriteLine(upper);
        }
    }
}
