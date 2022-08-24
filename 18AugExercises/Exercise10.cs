using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise10
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Input first Integer");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second Integer");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0));

            Console.ReadLine();
        }
    }
}
