using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sep9
{
    internal class SemaphoreProblem
    {
        static Thread[] t = new Thread[8];
        static Semaphore sem = new Semaphore(3, 4);

        static void M1()
        {
            Console.WriteLine("{0} is waiting in line...", Thread.CurrentThread.Name);
            sem.WaitOne();
            Console.WriteLine("{0} enters the code", Thread.CurrentThread.Name);
            Thread.Sleep(300);
            Console.WriteLine("{0} is leaving the code", Thread.CurrentThread.Name);
            Console.WriteLine();
            sem.Release();
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                t[i] = new Thread(M1);
                t[i].Name = "thread_" + i;
                t[i].Start();
            }
            Console.ReadLine();
        }
    }
}
