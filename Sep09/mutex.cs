using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sep9
{
    internal class MutexProblem
    {
        static void Main(string[] args)
        {
            
            using (Mutex mutex = new Mutex(false, "MyThread"))
            {

                if (!mutex.WaitOne(3000, false))
                {
                    Console.WriteLine("already running....");
                    Console.ReadLine();
                    return;

                }
                else
                {
                    Console.WriteLine("app is running");
                    Console.ReadLine();
                }

            }

        }
    }
}
