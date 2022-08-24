using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise13
    {
        static void Main(string[] args)
        {
            int m = 5000, km = 8;
            Console.WriteLine("meter to kilometer");
            metertokilometer(m);
            Console.WriteLine("kilometer to meter");
            kilometertometer(km);


            Console.ReadLine();
        }
        static void metertokilometer(int m)
        {
            int km = m / 1000;
            Console.WriteLine("meter : {0}  Kilometer : {1}", m, km);
        }
        static void kilometertometer(int km)
        {
            int m = km * 1000;
            Console.WriteLine("kilometer : {0}  meter : {1}", km, m);
        }
    }
}
