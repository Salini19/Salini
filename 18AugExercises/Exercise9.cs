using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise9
    {
        static void Main(string[] args)
        {
            int Celcius;
            Console.WriteLine("enter the amount of Celcius");
            Celcius = Convert.ToInt32(Console.ReadLine());
            int kelvin = Celcius + 273;
            int Fahrenheit = Celcius * 18 / 10 + 32;

            Console.WriteLine("Kelvin: {0}", kelvin);
            Console.WriteLine("Fahrenheit: {0}", Fahrenheit);

            Console.ReadLine();

        }
    }
}
