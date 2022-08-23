using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem2
    {
        static void Main(string[] args)


        {
            int n1, n2, n3;
            Console.WriteLine("Enter the first number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            n3 = Convert.ToInt32(Console.ReadLine());

            if ((n1 > n2) && (n1 > n3))
            {

                Console.WriteLine("the first number ({0}) is largest", n1);
            }
            else if ((n2 > n1) && (n2 > n3))
            {
                Console.WriteLine("the second number ({0}) is largest", n2);
            }
            else
            {
                Console.WriteLine("the third number ({0}) is largest", n3);
            }

            Console.ReadLine();
        }
    }
}
