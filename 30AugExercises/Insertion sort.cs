using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30August
{
    internal class Insertion_sort
    {
        static void Insert(int[] arr)
        {

            int i, j, temp;
            int n = arr.Length;
            for (i = 1; i < n; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 &&  arr[j]>= temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }

        static void PrintSortedArray(int[] arr)
        {

            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine();

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n] ;
            
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before Sorting");
            PrintSortedArray(arr);
            Insert(arr);
            Console.WriteLine("After Sorting");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintSortedArray(arr);
            Console.Read(); 
        }
    }
}
