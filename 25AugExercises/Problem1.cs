using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _25Aug
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text file name");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter the numbaer 1.Add 2.Edit 3.Truncate");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FileStream fs1 = new FileStream(fname, FileMode.Append, FileAccess.Write);
                    StreamWriter sw1 = new StreamWriter(fs1);
                    Console.WriteLine("Enter the content you need to add");
                    string content = Console.ReadLine();
                    sw1.Write(content);
                    sw1.Flush();
                    fs1.Flush();
                    sw1.Close();
                    fs1.Close();
                    sw1.Dispose();
                    fs1.Dispose();
                    Console.WriteLine("Content added Succesfuuly");
                    break;

                case 2:
                    string[] accounts = File.ReadAllLines(fname);
                    foreach (string account in accounts) 
                    { 
                        Console.WriteLine(account); 
                    }
                    Console.WriteLine("Select to change");
                    string change = Console.ReadLine();
                    Console.WriteLine("enter the content need to replace");
                    string dest = Console.ReadLine();
                    string[] items2 = accounts.Select(x => x.Replace(change, dest)).ToArray();
                    foreach (string account in items2) 
                    { 
                        Console.WriteLine(account); 
                    }
                    File.WriteAllLines(fname, items2);
                    Console.WriteLine("Content edited sucessfully");
                    break;

                case 3:
                    FileStream fs4 = new FileStream(fname, FileMode.Truncate, FileAccess.Write);
                    fs4.Close();
                    fs4.Dispose();
                    Console.WriteLine("Truncated");
                    break;
            }

            Console.ReadLine();

        }
    }
}
