using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class problem3
    {
        static void Main(string[] args)
        {
            int n = 3,sum=0;
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter a value for a[{0}]", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of all elements stored in the array is : " +sum);

            Console.ReadLine();
        }
    }
}
