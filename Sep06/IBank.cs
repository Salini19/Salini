using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sep6
{

    interface IBank
    {
        void PrintBalance(double amt);
        void CalculateInterest(double amt);
    }     

    public class Saving : IBank
    {
        public DateTime date = new DateTime(2021, 09, 16);
        public void PrintBalance(double amt)
        {
            Console.WriteLine("Available Balanace : " + amt);
            Console.WriteLine();
        }
        public void CalculateInterest(double amt)
        {
            amt += (amt * 0.04);
            Console.WriteLine("Total balance includiong interest : " + amt);
            Console.WriteLine();
        }              
    }

    public class Current : IBank
    {
        public void PrintBalance(double amt)
        {
            Console.WriteLine("Available Balanace : " + amt);
            Console.WriteLine();
        }
        public void CalculateInterest(double amt)
        {
            amt +=(amt * 0.02);
            Console.WriteLine("Total balance including interest : " + amt);
            Console.WriteLine();
        }
    }

}
 