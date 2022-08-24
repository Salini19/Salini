using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReusableCodeLibrary
{
    public class Createfile
    {
       public static void Makefiles()
        {
            string path = @"E:\Repos\MyApp\firstFile.txt";
            File.Create(path);
        }
    }
}
