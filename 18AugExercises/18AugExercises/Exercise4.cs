using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise4
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.WriteLine("enter the first number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the fourth number");
            n4 = Convert.ToInt32(Console.ReadLine());
            double avg = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("the average of {0}, {1} ,{2}, {3} is : {4}", n1, n2, n3, n4, avg);
            Console.ReadLine();
        }
    }
}
