using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30August
{
    internal class Quick_sort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("enter the elements");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before Sorting:");
            PrintsortedArray(arr);
            QuickSort(arr, 0, arr.Length - 1);
            
            Console.WriteLine("After Sorting");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintsortedArray(arr);
            Console.Read();
        }

        private static void PrintsortedArray(int[] arr)
        {
            

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\t");

            }
            Console.WriteLine();
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int p = makePart(arr, start, end);
                QuickSort(arr, start, p - 1);
                QuickSort(arr, p + 1, end);

            }

        }

        private static int makePart(int[] arr, int start, int end)
        {

            int pivot = arr[end];
            int i = (start - 1);
            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;

                }
            }
            int temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return (i + 1);
        }
    }
}
