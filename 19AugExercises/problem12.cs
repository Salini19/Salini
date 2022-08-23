using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem12
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Numbers between 100 and 200, divisible by 9 :");
            for (int i = 101; i < 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine("{0} ", i);
                    sum += i;
                }
            }
            Console.WriteLine("The sum is: {0}", sum);
            Console.ReadLine();
        }
    }
}
