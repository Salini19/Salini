using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Input is Zero");

            }
            else if (n > 100)
            {
                Console.WriteLine("Too large input");
            }
            else if (n % 2 != 0)
            {
                Console.WriteLine("Input {0} is odd Number", n);

            }
            else if (n % 2 == 0)

            {
                if (n % 10 == 0)
                {
                    Console.WriteLine("Input {0} is a Multiple of 10", n);

                }
                else
                {
                    Console.WriteLine("Input {0} is Even Number", n);
                }

            }

            Console.ReadLine();

        }
    }
}
