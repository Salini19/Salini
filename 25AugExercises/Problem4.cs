using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Aug
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C drive info");
            Console.WriteLine("----------------------------");
            DriveInfo Info = new DriveInfo("C");
            Console.WriteLine(Info.Name);
            Console.WriteLine(Info.TotalSize);
            Console.WriteLine(Info.TotalFreeSpace);
            Console.WriteLine(Info.AvailableFreeSpace);
            Console.WriteLine(Info.DriveFormat);
            Console.WriteLine(Info.DriveType);
            Console.WriteLine(Info.IsReady);
            Console.WriteLine(Info.RootDirectory);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Available drives");
            DriveInfo[] dinfo = DriveInfo.GetDrives();
            foreach (var item in dinfo)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();

           
        }
    }
}
