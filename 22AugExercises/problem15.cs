using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class problem15
    {
        static void Main(string[] args)
        {

            int n;
            int min = -1;
            Console.WriteLine("Enter the size of array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the element: arr[{0}]",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

     
            HashSet<int> set = new HashSet<int>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {

                if (set.Contains(arr[i]))
                {
                    min = i;
                }

                else
                { 
                    set.Add(arr[i]);
                }
            }
           
            if (min != -1)
            {
                Console.WriteLine("The first repeating element is " + arr[min]);
                Console.WriteLine("its first appearance is at index " + min);
            }
            else
            {
                Console.WriteLine("There are no repeating elements");
            }

            Console.ReadLine();
        
        }
    }
}
