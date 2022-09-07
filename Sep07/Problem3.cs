using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void arithmeticdel(int a, int b);
    public class Problem3
    {
        public void Add(int a, int b)
        {
            int ans = a + b;

            Console.WriteLine("The addition of {0} and {1} is       : {2}", a, b, ans);
        }

        public void Sub(int a, int b)
        {
            int ans = a - b;
            Console.WriteLine("The Subtarction of {0} and {1} is    : {2}", a, b, ans);
        }

        public void Mul(int a, int b)
        {
            int ans = a * b;
            Console.WriteLine("The Multiplication of {0} and {1} is : {2}", a, b, ans);
        }

    }
}
