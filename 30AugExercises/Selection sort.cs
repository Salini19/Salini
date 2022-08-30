using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _30August
{
    internal class Selection_sort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter element");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Bofore Sorting");
            PrintArray(arr);
            SelectionSort(arr);
            Console.WriteLine("Sorted Array:");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintArray(arr);

            Console.ReadLine();
        }

        static void SelectionSort(int[] arr)
        {
            int MinIndex, i, j;
            int len = arr.Length - 1;
            for (i = 0; i < len; i++)
            {
                MinIndex = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[MinIndex])
                    {
                        MinIndex = j;
                    }
                }
                if (MinIndex != i)
                {
                    int temp = arr[MinIndex];
                    arr[MinIndex] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        public static void PrintArray(int[] arr) 
        {         
            for (int k = 0; k < arr.Length; k++)
            {
               
                Console.Write(arr[k]+"\t");
            }
            Console.WriteLine();
        }
    }
}
