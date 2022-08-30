using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30August
{
    internal class Bubble_sort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter the elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before Sorting");
            PrintArray(arr);
            bubbleSort(arr);
            Console.WriteLine("After Sorting");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintArray(arr);

            Console.Read();
        }
        static void bubbleSort(int[] arr)
        {

            int temp;
            for (int i = 0; i < (arr.Length) - 1; i++)
            {
                for (int j = 0; j < (arr.Length - 1) - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void PrintArray(int[] arr) 
        { 
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine();


        }
    }
}
