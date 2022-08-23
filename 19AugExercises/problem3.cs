using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem3
    {
        static void Main(string[] args)
        {
            char Ch1, Ch2;
            Console.WriteLine("enter first character");
            Ch1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter second character");
            Ch2 = Convert.ToChar(Console.ReadLine());

            if (Ch1 == Ch2)
            {
                Console.WriteLine("Both Characters are equal");
            }
            else
            {
                Console.WriteLine("Both Characters are not equal");
            }

            Console.ReadLine();
        }
        }
}
