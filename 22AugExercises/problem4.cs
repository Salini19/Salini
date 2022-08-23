using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class problem4
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList() { 37, "Hello", 34.45f, 444, "Hi" };
            a1.Add(new DateTime());
            a1.RemoveAt(0);
            var totalcount =a1.Count;
            Console.WriteLine("totalcount:" + totalcount);

            Console.ReadLine();

        }
    }
}
