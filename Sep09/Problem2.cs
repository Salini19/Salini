using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sep9
{
    internal class Problem2
    {
        static void M1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("ThreadName : "+Thread.CurrentThread.Name +" === "+ "Method1 : " + i);
                Console.ForegroundColor = ConsoleColor.White;
                if (i == 5)
                {
                    Thread.Sleep(5);

                }
            }
        }

        static void M2()
        {
            for (int j = 0; j < 5; j++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ThreadName : " + Thread.CurrentThread.Name + " === " + "Method2 : " + j);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

       
        static void Main(string[] args)
        {

            Thread t1 = new Thread(M1);
            t1.Name = "Thread 1";
            Thread t2 = new Thread(M2);
            t2.Name = "Thread 2";
            Console.WriteLine("----Before Start---- ");
            Console.WriteLine("T1 is alive= " + t1.IsAlive);
            Console.WriteLine("T2 is alive= " + t2.IsAlive);
            Console.WriteLine("State of Thread T1= " + t1.ThreadState);
            Console.WriteLine("state of Thread T2= " + t2.ThreadState);
            Console.WriteLine();

            t1.Start();
            t2.Start();
            Console.WriteLine();
            Console.WriteLine("----After Start----");
            Console.WriteLine("T1 is alive= " + t1.IsAlive);
            Console.WriteLine("T2 is alive= " + t2.IsAlive);
            Console.WriteLine("State of Thread T1= " + t1.ThreadState);
            Console.WriteLine("state of Thread T2= " + t2.ThreadState);
            Console.WriteLine();

            t1.Join();
            t2.Join();
            Console.WriteLine();
            Console.WriteLine("State of Thread T1= " + t1.ThreadState);
            Console.WriteLine("state of Thread T2= " + t2.ThreadState);
            Console.WriteLine();



            t1.Abort();
            t2.Abort();
            Console.WriteLine("T1 is alive= " + t1.IsAlive);
            Console.WriteLine("T2 is alive= " + t2.IsAlive);
            Console.WriteLine("State of Thread T1= " + t1.ThreadState);
            Console.WriteLine("state of Thread T2= " + t2.ThreadState);



            Console.ReadLine();

        }

       
    }
}
