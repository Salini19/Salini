using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _25Aug
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            string path = @"E:\Repos\25Aug\";
            Console.WriteLine("Enter the filename");
            string name = Console.ReadLine();
            string fname = string.Concat(path, name);
            //File.Create(fname);
            Console.WriteLine("Enter your file contents");
            string con = Console.ReadLine(); 
            File.WriteAllText(fname, con);
            Console.WriteLine("file created successfully with contents...");
            Console.WriteLine();

            Console.WriteLine("-------------FileCopy-sameFolder---------------------");
            File.Copy(fname, "CopiedFile.txt");
            Console.WriteLine("Copied file successfuly");
            Console.WriteLine();

            Console.WriteLine("-------------FileCopy-DifferentFolder-----------------");
            string dest = @"E:\Repos\CopiedFile.txt";
            File.Copy(fname, dest);
            Console.WriteLine("File copied to different location successfully");
            Console.WriteLine();

            Console.WriteLine("-----------MoveFile------------");
            File.Move(fname, "Movedfile.txt");
            Console.WriteLine("Moved file successfully");
            Console.WriteLine();

            //Console.WriteLine("------DeleteFile-------");
            //File.Delete(fname);
            //Console.WriteLine("deleted File successfully");
            //Console.WriteLine();

            Console.WriteLine("-----FileInfo----------");
            FileInfo Info = new FileInfo("Movedfile.txt");
            Console.WriteLine("Extension of the file : " + Info.Extension);
            Console.WriteLine(" DirectoryName : " + Info.DirectoryName);
            Console.WriteLine("Creation Time : " + Info.CreationTime);
            

          


            Console.ReadLine();
        }
    }
}
