using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise2
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            num3 = Convert.ToInt32(Console.ReadLine());
            int Res = num1 * num2 * num3;
            Console.WriteLine("result: {0} x {1} x {2} = {3}", num1, num2, num3, Res);
            Console.ReadLine();

        }
    }
}
