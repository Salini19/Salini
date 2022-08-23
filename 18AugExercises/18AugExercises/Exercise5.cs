using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise5
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("enter the fisrt Number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second Number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third Number");
            z = Convert.ToInt32(Console.ReadLine());
            int res1 = (x + y) * z;
            int res2 = (x * y) + (y * z);
            Console.WriteLine("result: {0},{1},{2}, (x=y).z is {3}, x.y+y.z is {4}", x, y, z, res1, res2);
            Console.ReadLine();

        }
    }
}
