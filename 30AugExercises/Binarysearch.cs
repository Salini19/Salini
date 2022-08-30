using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30August
{
    internal class Binarysearch
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];      
            
            AcceptSortandPrintArray(arr);
            //PrintSortedArray(arr);
            Console.WriteLine("Find element to search");
            int f = Convert.ToInt32(Console.ReadLine());

            BinarySearch(arr, 1, arr.Length, f);
            Console.Read();

        }

        internal static void BinarySearch(int[] a, int i, int j, int k)
        {

            int mid;
            while (i <= j)
            {
                mid = (i + j) / 2;
                if (a[mid] == k)
                {
                    Console.WriteLine("Value found at the middle =  " + mid);
                    break;
                }
                else if (a[mid] > k)
                {
                    j = mid - 1;
                    Console.WriteLine("Value found at =  " + j);
                    break;
                }
                else
                    i = mid + 1;
                Console.WriteLine("Value found at  =  " + i);
                break;
            }
        }

        internal static void AcceptSortandPrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter element");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int  j, temp;
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] >= temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
            Console.WriteLine("Sorted Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

        }

       
    }
}
