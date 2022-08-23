using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem9
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.WriteLine("Enter the number of terms");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}", i);
                    sum += i;
                }
            }
            Console.WriteLine("the sum of natural number upto {0}: {1}", n, sum);
            Console.ReadLine();
        }
    }
}
