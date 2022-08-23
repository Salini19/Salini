using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter first number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number");
            b = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

        }
        public void sum(int a,int b)
        {
            int add = a + b;
            
            Console.WriteLine("sum = "+add);

        }
        
    }
}
