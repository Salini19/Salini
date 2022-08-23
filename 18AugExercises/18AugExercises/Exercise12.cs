using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise12
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("enter the string");
            s = Console.ReadLine();
            bool res = string.IsNullOrEmpty(s);

            Console.WriteLine(res);

            Console.ReadLine();

        }
    }
}
