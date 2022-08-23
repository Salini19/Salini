using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class problem9
    {
        static void Main(string[] args)
        {
            List<float> list = new List<float>();
            list.Add(45.5f);
            list.Add(65.6f);
            list.Add(6.7f);
            Console.WriteLine("elements in list");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("elements in ascending order:");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine( item);
            }
            Console.WriteLine("elements in descending order:");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
