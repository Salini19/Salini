using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class Problem14
    {
        static int count(int[] S, int m, int n)
        {
            if (n == 0)
                return 1;


            if (n < 0)
                return 0;

            if (m <= 0)
                return 0;


            return count(S, m - 1, n) +
                count(S, m, n - S[m - 1]);
        }


        public static void Main()
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("arr = ");
            int[] arr = new int[n];
            var stringArray = Console.ReadLine().Split(' ');
            for (var i = 0; i < m; i++)
            {
                arr[i] = int.Parse(stringArray[i]);
            }
            Console.WriteLine("Output = {0}", count(arr, m, n));

            Console.ReadLine();

        }
    }

}
