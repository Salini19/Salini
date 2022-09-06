using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep6
{
    public static class ExtensionMethods
    {
        public static void Withdraw(this Saving s,double amt)
        {
            Console.WriteLine("Enter the Amount to withdraw");
            int cash = int.Parse(Console.ReadLine());

            if (cash < amt)
            {
                amt -= cash;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rs {0} withdrawn Succesfully..", cash);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Remaining Balanace : " + amt);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no Sufficient Balance");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void Deposit(this Saving s,double amt)
        {
            Console.WriteLine("Enter the Amount to Deposit");
            int cash = int.Parse(Console.ReadLine());
            amt += cash;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Rs {0} is added in your account", cash);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Availabale Balance : " + amt);

        }

        public static void Withdraw(this Current c, double amt)
        {
            Console.WriteLine("Enter the Amount to withdraw");
            int cash = int.Parse(Console.ReadLine());

            if (cash < amt)
            {
                amt -= cash;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rs {0} withdrawn Succesfully..", cash);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Remaining Balanace : " + amt);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no Sufficient Balance");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void Deposit(this Current c, double amt)
        {
            Console.WriteLine("Enter the Amount to Deposit");
            int cash = int.Parse(Console.ReadLine());
            if (amt>0)
            {
                amt += cash;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rs {0} is added in your account", cash);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Availabale Balance : " + amt + cash);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Deposit amount can't be zero");
                Console.ForegroundColor = ConsoleColor.White;
            }
            

        }

    }
}
