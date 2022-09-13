using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;


namespace Sep12
{
    internal class callculate
    {
        static void Main(string[] args)
        {
            string path = @"E:\Repos\Sep12\Calculator\bin\Debug\Calculator.dll";

            Assembly asm = Assembly.LoadFrom(path);

            Type[] types = asm.GetTypes();
            Type t = null;

            foreach (var item in types)
            {
               

                t = asm.GetType(item.FullName);

                Object obj= Activator.CreateInstance(t);

                if (item.Name == "Calculation")
                {
                    double ans = (double)item.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 5 });

                    double ans1 = (double)item.InvokeMember("SquareRoot", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 64 });


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Cube of 5 is : {0}", ans);
                    Console.WriteLine("Squareroot of 64 is : {0}", ans1);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
            Console.ReadLine();
            
        }
       
    }
}
