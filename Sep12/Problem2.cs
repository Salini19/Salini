using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sep12
{
    internal class Problem2
    {
        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("Methods " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is StereoDiscAttribute)
                {
                    StereoDiscAttribute a = (StereoDiscAttribute)attr;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(a.SongName);
                    Console.WriteLine(a.Language);
                    Console.WriteLine(a.Lyrics);
                }
            }
            Console.WriteLine("---------------------------------");
            MemberInfo[] minfo = t.GetMembers();

            foreach (var item in minfo)
            {
                System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                foreach (System.Attribute attrItem in attrs1)
                {
                    if (attrItem is StereoDiscAttribute)
                    {
                        StereoDiscAttribute a = (StereoDiscAttribute)attrItem;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("SongName : "+a.SongName);
                        Console.WriteLine("Language : "+a.Language);
                        Console.WriteLine("Lyrics   : "+a.Lyrics);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("---------------------------");
                    }
                }
            }

        }
        static void Main(string[] args)
        {

            Problem2.WritedataForEachCode(typeof(Song));
            Console.ReadLine();
        }
    }
}
