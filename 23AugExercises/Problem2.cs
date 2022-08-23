using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int b = Convert.ToInt32(Console.ReadLine());
            add(a, b);
            Console.WriteLine("sum = "+ add(a, b));
            Console.ReadLine();



        }
        static int add(int a, int b)
        {
            int sum = a + b;
            
            return sum;
        }
    }
}
