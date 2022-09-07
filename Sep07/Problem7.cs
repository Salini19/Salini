using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void strfirst(string str);
    public class Problem7
    {

        public void StrCap(string a)
        {
            if (a.Length == 0)
            {
                Console.WriteLine("Empty String");
            }
            else if (a.Length == 1)
            {
                Console.WriteLine(char.ToUpper(a[0]));
            }
            else
            {
                Console.WriteLine(char.ToUpper(a[0]) + a.Substring(1));
            }

        }
    }
}
