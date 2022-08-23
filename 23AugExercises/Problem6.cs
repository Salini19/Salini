using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class Problem6
    {
        static void Main(string[] args)
        {

            int[] Values = (int[])Enum.GetValues(typeof(deptnames));
            Console.WriteLine("Deptno");
            foreach (int value in Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();
            string[] Names = Enum.GetNames(typeof(deptnames));
            Console.WriteLine("Deptname ");
            foreach (string Name in Names)
            {
                Console.WriteLine(Name);
            }
            //Console.WriteLine("enter dept name");
            //string dname = Console.ReadLine();

            //int Deptno = deptnames.dname;
            //Console.WriteLine(Deptno);

            //string[] values = Enum.GetNames(typeof(deptnames));
            //int total = 0;
            //foreach (string s in values)
            //{
            //    Console.WriteLine(s);
            //    total++;
            //}
            //Console.WriteLine("Total values in enum type is : {0}", total);
            Console.ReadLine();
            
        }
    
        enum deptnames 
        {
            Purchase = 1, 
            Sales = 2, 
            Training = 3,
            Accounts = 4
        }
    }
}
