using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the US dollers");
            double dollers = Convert.ToDouble(Console.ReadLine());
            double rupees = dollers * 64;
            Console.WriteLine("Indian Rupees :" + rupees + "rupees");

            Console.ReadLine();
        }
    }
}
