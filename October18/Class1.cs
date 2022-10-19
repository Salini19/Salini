using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SpecFlowProject1
{
    public class Class1
    {
        public int Add(int i, int j)
        {
            return i + j;
        }
        public double Sqrroot(double i)
        {

            return i != 0 ? Math.Sqrt(i) : 0;
        }
    }
    public class Login
    {
        public string? Userid { get; set; }
        public string? Passwrod { get; set; }

        public string login()
        {
            string s;
            if (Userid=="Salini" && Passwrod=="Shalu@123")
            {
               s = "Successfully Loggedin";
            }
            else
            {
                s = "Invalid Credentials";
            }
            return s;
        }
    }
   

}
