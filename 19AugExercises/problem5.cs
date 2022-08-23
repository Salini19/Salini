using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem5
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter the first number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("{0} is the biggest number", n1);
            }
            else
            {
                Console.WriteLine("{0} is the biggest number", n2);
            }
            Console.ReadLine();
        }
        }
}
