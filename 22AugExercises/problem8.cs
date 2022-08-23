using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class problem8
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "tea");
            h.Add(2, "Coffee");
            h.Add(3, "Coke");
            h.Add(4, "Milk");
            h.Add(5, "thumsup");
            IDictionaryEnumerator ie = h.GetEnumerator();
            Console.WriteLine("Elements:");
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + "  " + item.Value);

            }
            h.Remove(1);
            Console.WriteLine("After removing element");
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + "  " + item.Value);

            }

            Console.ReadLine();
        }
    }
}
