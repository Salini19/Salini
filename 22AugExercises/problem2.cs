using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class problem2
    {
        static void Main(string[] args)
        {
            int n=3;
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter a value for a[{0}]", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values store into the array are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("The values store into the array in reverse are :");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", arr[i]);
            }
            
            Console.ReadLine();
        }
    }
}
