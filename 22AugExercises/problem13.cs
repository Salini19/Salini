using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class problem13
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5, 200, 22, 2244, 213, 111 };
            Console.WriteLine("elements greater than 100: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>100)
                {
                    Console.WriteLine(arr[i]);
                }
            }
           
            Console.ReadLine();
        }
    }
}
