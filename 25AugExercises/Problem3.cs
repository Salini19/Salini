using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Aug
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            string path = @"E:\Repos\25Aug\Results";
            Directory.CreateDirectory(path);
            Console.WriteLine("Directory created sucesfully");
            Directory.CreateDirectory(Path.Combine(path, "Results_17-18"));
            Directory.CreateDirectory(Path.Combine(path, "Results_18-19"));
            Directory.CreateDirectory(Path.Combine(path, "Results_20-21"));

            Console.WriteLine("Subdirectories created");
            Console.WriteLine("-----------------------------------");

            File.Create(@"E:\Repos\25Aug\Results\Results_17-18\file1.txt");
            File.Create(@"E:\Repos\25Aug\Results\Results_17-18\file2.txt");
            File.Create(@"E:\Repos\25Aug\Results\Results_18-19\file1.txt");
            File.Create(@"E:\Repos\25Aug\Results\Results_18-19\file2.txt");
            File.Create(@"E:\Repos\25Aug\Results\Results_20-21\file1.txt");
            File.Create(@"E:\Repos\25Aug\Results\Results_20-21\file2.txt");

            Console.WriteLine("files are Created");
            Console.WriteLine("-----------------------------------");

            Directory.CreateDirectory(@"E:\Repos\25Aug\Results\Results_18-19\January");
            Directory.CreateDirectory(@"E:\Repos\25Aug\Results\Results_18-19\Febrary");
            Directory.CreateDirectory(@"E:\Repos\25Aug\Results\Results_18-19\March");
            Directory.CreateDirectory(@"E:\Repos\25Aug\Results\Results_18-19\April");
            Directory.CreateDirectory(@"E:\Repos\25Aug\Results\Results_18-19\May");
            Directory.CreateDirectory(@"E:\Repos\25Aug\Results\Results_18-19\June");
            Directory.CreateDirectory(@"E:\Repos\25Aug\Results\Results_18-19\July");
            Directory.CreateDirectory(@"E:\Repos\25Aug\Results\Results_18-19\August");
            Directory.CreateDirectory(@"E:\Repos\25Aug\Results\Results_18-19\September");
            Directory.CreateDirectory(@"E:\Repos\25Aug\Results\Results_18-19\Octobar");
            Directory.CreateDirectory(@"E:\Repos\25Aug\Results\Results_18-19\November");
            Directory.CreateDirectory(@"E:\Repos\25Aug\Results\Results_18-19\December");

            Console.WriteLine("Month Dir are created");
            Console.WriteLine("-----------------------------------");

            string[] dir = Directory.GetDirectories(path);
            foreach (string dir2 in dir)
            {

                Console.WriteLine("Files in Directories:");
                string[] files = Directory.GetFiles(dir2);
                foreach (string file2 in files)
                {
                    Console.WriteLine(file2);
                }
                Console.WriteLine("----------------------------------------------------");
            }

            
            string[] fold = Directory.GetDirectories(@"E:\Repos\25Aug\Results\Results_18-19");
            foreach (string fold2 in fold) 
            { 
                Console.WriteLine(fold2); 
            }


            Console.ReadLine();
        }
    }
}
