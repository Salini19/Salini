using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep1
{
    internal class Shell_Sort
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the length of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] : ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Before Sorting");
            Console.ForegroundColor = ConsoleColor.Red;
            PrintArray(arr);
            Shellsort(arr);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sorted Array ");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintArray(arr);

            Console.ReadLine();
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
        //Original sequence
        public static void Shellsort(int[] arr)
        {
            int temp;
            int n = arr.Length;
            for (int gap = n / 2; gap >= 1; gap = gap / 2)
            {
                for (int j = gap; j < n; j++)
                {

                    for (int i = j - gap; i >= 0; i = i - gap)
                    {
                        if (arr[i + gap] > arr[i])
                        {
                            break;
                        }
                        else
                        {
                            temp = arr[i];
                            arr[i] = arr[i + gap];
                            arr[i + gap] = temp;
                        }
                    }
                }
            }
        }
        //knuth's sequence
        //public static void Shellsort(int[] arr)
        //{
        //    int temp;
        //    int n = arr.Length;
        //    for (int gap = 1; gap >= n/3; gap = (gap * 3) + 1)
        //    {
        //        for (int j = gap; j < n; j++)
        //        {

        //            for (int i = j - gap; i >= 0; i = i - gap)
        //            {
        //                if (arr[i + gap] > arr[i])
        //                {
        //                    break;
        //                }
        //                else
        //                {
        //                    temp = arr[i];
        //                    arr[i] = arr[i + gap];
        //                    arr[i + gap] = temp;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
