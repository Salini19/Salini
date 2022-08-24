using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise7
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", n);
                Console.WriteLine("{0}{0}{0}{0}", n);

            }

            Console.ReadLine();
        }
    }
}
