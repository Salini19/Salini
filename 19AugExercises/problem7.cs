using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem7
    {
        static void Main(string[] args)
        {
            int Sub1, Sub2, Sub3, total;
            float percent;

            Console.WriteLine("enter the mark scored in Chemistry Sub");
            Sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the mark scored in Physics Sub");
            Sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the mark scored in Maths Sub");
            Sub3 = Convert.ToInt32(Console.ReadLine());

            total = Sub1 + Sub2 + Sub3;
            Console.WriteLine("Subjects total is: {0}", total);

            percent = total / 3;
            Console.WriteLine("Percentage is: {0}", percent);

            if (percent < 35)
            {
                Console.WriteLine("Fail");
            }
            else if (percent >= 35 && percent < 45)
            {
                Console.WriteLine("third");
            }
            else if (percent >= 45 && percent < 60)
            {
                Console.WriteLine("second");
            }
            else
            {
                Console.WriteLine("first");
            }
            Console.ReadLine();
        }
    }
}
