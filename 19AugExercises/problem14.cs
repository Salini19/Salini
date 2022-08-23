using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Menu \n 1.Check Zero or greater than 100 \n 2.Check odd or even \n 3.Check Multiple of 10 or not");

            int userchoice = Convert.ToInt32(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    {
                        if (n == 0)
                        {
                            Console.WriteLine("Input is Zero");
                        }
                        else if (n > 100)
                        {
                            Console.WriteLine("Too large Input");
                        }
                        break;
                    }
                case 2:
                    {
                        if (n % 2 != 0)
                        {
                            Console.WriteLine("Input {0} is a odd number", n);
                        }
                        else if (n % 2 == 0)
                        {
                            Console.WriteLine("Input {0} is a even number", n);
                        }
                        break;
                    }
                case 3:
                    {
                        if (n % 10 != 0)
                        {
                            Console.WriteLine("Input {0} is not a multiple of 10", n);
                        }
                        else if (n % 10 == 0)
                        {
                            Console.WriteLine("Input {0} is a multiple of 10", n);
                        }
                        break;

                    }



            }
            Console.ReadLine();
        }
    }
}
