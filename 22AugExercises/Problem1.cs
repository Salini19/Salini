using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i <arr.Length; i++)
            {
                Console.WriteLine("enter a value for a[{0}]", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements in an array");
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.ReadLine();
        }
    }
}
