using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = 5;
            int N2 = 6;
            Console.WriteLine("BeforeSwapping");
            Console.WriteLine("N1 :" + N1);
            Console.WriteLine("N2 :" + N2);
            Console.WriteLine("-------callbyvalue-------");
            callbyvalue(N1, N2);
            Console.WriteLine("-------callbyref-------");
            Callbyref(ref N1, ref N2);
            Console.ReadLine();
        }
        static void callbyvalue(int N1, int N2)
        {
            int N3 = N1;
            N1 = N2;
            N2 = N3;
            Console.WriteLine("after Swapping");
            Console.WriteLine("N1 :" + N1);
            Console.WriteLine("N2 :" + N2);

        }
        static void Callbyref(ref int N1, ref int N2)
        {
            int N3 = N1;
            N1 = N2;
            N2 = N3;
            Console.WriteLine("after Swapping");
            Console.WriteLine("N1 :" + N1);
            Console.WriteLine("N2 :" + N2);

        }
    }
}
