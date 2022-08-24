using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise6
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you look older than {0}", age);
            Console.ReadLine();
        }
    }
}
