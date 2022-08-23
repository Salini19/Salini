using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class Problem8
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("enter tha value1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter tha value2:");
            b = Convert.ToInt32(Console.ReadLine());
            Exerror(a, b);
            Console.ReadLine();

        }
        static void Exerror(int a, int b)
        {
            try
            {   
              
                int div= a / b;
                Console.WriteLine("Division :" + div);

            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("finally fired");
            }
        }
    }
}
