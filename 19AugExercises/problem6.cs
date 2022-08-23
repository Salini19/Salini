using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem6
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter the year");
            year = Convert.ToInt32(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
            Console.ReadLine();
        }
        }
}
