using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void findlength(string s);
    public class Problem1
    {
        public void LengthString(string s)
        {
            int length = s.Length;
            Console.WriteLine("The length of the given string '{0}' is {1}", s, length);
        }

        public void Greetuser(string s)
        {
            Console.WriteLine("Hello " + s);
        }       
    }

}
