using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class problem5
    {
        static void Main(string[] args)
        {
            int [][] Classroom = new int[5][];
            Classroom[0] = new int[] { 1, 37 };
            Classroom[1] = new int[] { 2, 19 };
            Classroom[2] = new int[] { 3, 25 };
            Classroom[3] = new int[] { 4, 45 };
            Classroom[4] = new int[] { 5, 38 };

            for (int n = 0; n < Classroom.Length; n++)
                {
                    Console.WriteLine("Classroom ({0})  ", n);
                    for (int i = 0; i < Classroom[n].Length; i++)
                    {
                        Console.Write(Classroom[n][i] +"\t " );
                    }
                    Console.WriteLine();

                }


                Console.ReadLine();
        }
    }
}
