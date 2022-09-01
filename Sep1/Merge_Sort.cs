using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Sep1
{
    internal class Merge_Sort
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the length of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
 
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Before Sorting");
            Console.ForegroundColor = ConsoleColor.Red;
            PrintArray(arr);

            int ub = n - 1;
            MergeSort(arr,0,ub);

           // PrintArray(arr);

            Console.ReadLine();
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
        static void MergeSort(int[] arr,int lb,int ub)
        {
            if (lb < ub)
            {
                int mid = (lb + ub) / 2;
                MergeSort(arr, lb, mid);
                MergeSort(arr, mid + 1, ub);
                MergeSub(arr, lb, mid, ub);

            }
        }
        static void MergeSub(int[] arr, int lb,int mid,int ub)
        {
            int i, j, k;
            int[] arr2=new int[ub];
          
            i= 0;
            j = mid + 1;
            k = lb;
            while (i<=mid && j<=ub)
            {
                if (arr[i] <= arr[j])
                {
                    arr2[k] = arr[i];
                    i++;
                }
                else
                {
                    arr2[k] = arr[j];
                    j++;
                }
                k++;
            }
            if (i>mid)
            {
                while (i<=mid)
                {
                    arr2[k] = arr[i];
                    i++;
                    k++;
                }
            }
            else
            {
                while (j<=ub)
                {
                    arr2[k] = arr[j];
                    j++;
                    k++;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sorted Array ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (k = lb; k < ub; k++)
            {
                Console.Write(arr2[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
