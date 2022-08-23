using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, min, max;
            Console.WriteLine("Enter the first number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            n2 = Convert.ToInt32(Console.ReadLine());

            //minimum number

            if (n1 < n2)
            {
                min = n1;
            }
            else
            {
                min = n2;
            }
            //maximum number
            if (n1 > n2)
            {
                max = n1;
            }
            else
            {
                max = n2;
            }

            Console.WriteLine("Maximum number: {0}", max);
            Console.WriteLine("Minimum number: {0}", min);
            Console.ReadLine();

        }
    }
}
