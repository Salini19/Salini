using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class problem11
    {
        static void Main(string[] args)
        {
            SortedList<int, string> s1 = new SortedList<int, string>();
            s1.Add(1, "Dheeran");
            s1.Add(4, "Paiya");
            s1.Add(2, "viruman");
            s1.Add(3, "Thozha");

            foreach (var item in s1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.ReadLine();
        }
    }
}
