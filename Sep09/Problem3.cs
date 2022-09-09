using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sep9
{
    internal class Problem3
    {
        static void M1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Print {0} ", i);
                Console.WriteLine("Thread name " + Thread.CurrentThread.Name);

                Thread.Sleep(200);
            }

        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(M1));
            t1.Name = "T1 Thread";

            Thread t2 = new Thread(M1);
            t2.Name = "T2 Thread";
            Thread t3 = new Thread(M1);
            t3.Name = "T3 Thread";
            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.Normal;
            t3.Priority = ThreadPriority.Lowest;
            t2.Start();
            t1.Start();
            t1.Join();

            t3.Start();

            Console.ReadLine();
        }
    }
}
