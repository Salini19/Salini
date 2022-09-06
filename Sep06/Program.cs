using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep6
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //problem1
            //Employee emp1= new Employee();
            //emp1.Work();
            //Manager manager = new Manager();
            //manager.Work();
            //Clerk clerk = new Clerk();
            //clerk.Work();



            //problem 2 to 6
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("         WELCOME");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Press \n 1 for Savings Account \n 2 for Current Account");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("you have Seleceted Savings Account");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press \n 1 for Withdraw \n 2 for Depoist \n 3 for BalanceCheck \n 4 for Exit ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Saving saving = new Saving();
                double bal = 50000;
                switch (option)
                {
                    case 1:
                        
                        saving.Withdraw(bal);
                        break;

                    case 2:

                        saving.Deposit(bal);
                        break;

                    case 3:
                        saving.PrintBalance(bal);
                        saving.CalculateInterest(bal);
                        break;

                    case 4:
                        break;
                }

            }
            else if(choice == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("you have Seleceted Current Account");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press \n 1 for Withdraw \n 2 for Depoist \n 3 for BalanceCheck \n 4 for Exit ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Current current = new Current();
                double bal = 50000;
                switch (option)
                {
                    case 1:                       
                        current.Withdraw(bal);
                        break;

                    case 2:
                        current.Deposit(bal);
                        break;

                    case 3:
                        current.PrintBalance(bal);
                        current.CalculateInterest(bal);
                        break;

                    case 4:
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("enter Valid input");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("           Thank You \n             Visit Again....");
            Console.ForegroundColor = ConsoleColor.White;

            //problem7
            //Saving saving1 = new Saving();
            //double amount = 10000;
            //int days = (DateTime.Now.Date - saving1.date.Date).Days;
            //Console.WriteLine("Deposit amount {0} is kept in the bank for {1} days.", amount, days);

            Console.ReadLine();
        }
    }
    internal enum AccountTypes
    {
        Savings = 1,
        Current = 2
    }
}
