using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _22August
{
    internal class problem12
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10,2,40,99,77};
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max=arr[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("maximum element :" + max);
            Console.WriteLine("minimum element: " + min);
            Console.ReadLine();
        }
    }
}
