using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise14
    {
        static void Main(string[] args)
        {
            double celcius = 36;
            double fahrenheit;
            Console.WriteLine("Celcius: " + celcius);

            fahrenheit = (celcius * 9) / 5 + 32;
            Console.WriteLine("fahrenheit: " + fahrenheit);

            Console.ReadLine();

        }
    }
}
