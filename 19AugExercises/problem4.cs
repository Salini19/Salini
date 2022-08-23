using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem4
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("enter first string value");
            s1 = Console.ReadLine();
            Console.WriteLine("enter second string value");
            s2 = Console.ReadLine();

            if (s1 == s2)
            {
                Console.WriteLine("{0} and {1} are equal", s1, s2);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal", s1, s2);
            }
            Console.ReadLine();
        }

        }
}
