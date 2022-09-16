using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLibrary1;

namespace Sep14
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            CustomerUSer user = new CustomerUSer();
            Console.WriteLine("Enter userid");
            user.Userid = Console.ReadLine();
            Console.WriteLine("Enter password");
            user.Password = Console.ReadLine();
            user.Date = DateTime.Now;

            user.ValidUser(user.Userid, user.Password);

            //Serilization

            FileStream fs = new FileStream(@"ValidUser.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, user);

            fs.Flush();
            fs.Close();
            fs.Dispose();

            //Deserilize

            FileStream fs1 = new FileStream(@"validuser.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter1 = new BinaryFormatter();
            CustomerUSer user1 = (CustomerUSer)formatter1.Deserialize(fs1);

            Console.WriteLine("Details");
            Console.WriteLine();
            Console.WriteLine("Userid       : " + user1.Userid);
            Console.WriteLine("Password     : " + user1.Password);
            Console.WriteLine("Login Status : " + user1.LoginStatus);
            Console.WriteLine("Date         : "+user1.Date);

            fs1.Flush();
            fs1.Close();
            fs1.Dispose();


            Console.ReadLine();
        }
    }
}
