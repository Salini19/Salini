using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate string concatdel(string a, string b);
    public class Problem6
    {
        public string ConcatTwoStrings(string a, string b)
        {
            string c = string.Concat(a, b);
            Console.WriteLine("The concated string is " + c);
            return c;
        }

    }
}
