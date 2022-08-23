using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise3
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, k = 0, userchoice;
            char ch = '+';
            Console.WriteLine("Menu\n 1.add \n 2.subtract \n 3.Multiplication \n 4.division \n 5.exit");
            userchoice = Convert.ToInt32(Console.ReadLine());
            if (userchoice != 5)
            {
                Console.WriteLine("Enter the value for i ");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value for j ");
                j = Convert.ToInt32(Console.ReadLine());
            }
            switch (userchoice)
            {
                case 1:
                    ch = '+';
                    k = i + j;
                    Console.WriteLine(k);
                    break;
                case 2:
                    ch = '-';
                    k = i - j;
                    Console.WriteLine(k);
                    break;
                case 3:
                    ch = '*';
                    k = i * j;
                    Console.WriteLine(k);
                    break;
                case 4:
                    ch = '/';
                    k = i / j;
                    Console.WriteLine(k);
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Userchoice is not valid");
                    break;
            }
            Console.ReadLine();
        }
    }
}
