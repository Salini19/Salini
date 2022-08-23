using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem11
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 101; i < 200; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("the sum is : {0}", sum);
            Console.ReadLine();

        }
    }
}
