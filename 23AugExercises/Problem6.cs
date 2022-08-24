using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class Problem6
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter deptname");
            string dept_name = Console.ReadLine();
            int k;

            switch (dept_name)
            {
                case "Purchase":
                    k = (int)deptnames.Purchase;
                    Console.WriteLine("Dept NO: " +k);
                    break;
                case "Sales":
                    k = (int)deptnames.Sales;
                    Console.WriteLine("Dept NO: " + k);
                    break;
                case "Training":
                    k = (int)deptnames.Training;
                    Console.WriteLine("Dept NO: " + k);
                    break;
                case "Accounts":
                    k = (int)deptnames.Accounts;
                    Console.WriteLine("Dept NO: " + k);
                    break;
                default:
                    break;

            }
            Console.ReadLine();
            
        }
    
        enum deptnames 
        {
            Purchase = 1, 
            Sales = 2, 
            Training = 3,
            Accounts = 4
        }
    }
}
