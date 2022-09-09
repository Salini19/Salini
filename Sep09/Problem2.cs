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
            Thread.Sleep(3000);
            Console.WriteLine("Thread Name : " + Thread.CurrentThread.Name);
            Console.WriteLine("Sleep State =" + Thread.CurrentThread.ThreadState);
        }

       
        static void Main(string[] args)
        {

            Thread t1 = new Thread(M1);
            t1.Name = "Thread 1";
            Thread t2 = new Thread(M1);
            t2.Name = "Thread 2";
            Console.WriteLine("----Before Start---- ");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            t1.Start();
            t2.Start();
            Console.WriteLine("----After Start----");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            //t1.Abort();
            //t2.Abort();
            //Console.WriteLine("Thread state T1= " + t1.ThreadState);
            //Console.WriteLine("Thread state T2= " + t2.ThreadState);



            Console.ReadLine();

        }

       
    }
}
