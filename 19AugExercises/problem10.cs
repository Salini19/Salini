using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem10
    {
        static void Main(string[] args)
        {
            int n, rev = 0, rem;
            Console.WriteLine("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reversed Number: " + rev);
            Console.ReadLine();
        }
    }
}
