using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class DateProperties
    {
        public static void Date()
        {
            DateTime dt = new DateTime();
            dt=DateTime.Now;
            Console.WriteLine("DateTime : " + dt);
            Console.WriteLine("year : " + dt.Year);
            Console.WriteLine("Month : "+dt.Month);
            Console.WriteLine("Day : " + dt.Day);
            Console.WriteLine("Hour : " + dt.Hour);
            Console.WriteLine("Minute : " + dt.Minute);
            Console.WriteLine("Seconds : "+dt.Second);
            Console.WriteLine("Milliseconds : " + dt.Millisecond);
            Console.WriteLine("DayofYear : " + dt.DayOfYear);
            Console.WriteLine("DayofWeek : " + dt.DayOfWeek);
            Console.WriteLine("TimeofDay : " + dt.TimeOfDay);
            Console.WriteLine("Long Date : " + dt.ToLongDateString());
            Console.WriteLine("Short Date : " + dt.ToShortDateString());
            Console.WriteLine("Long Time : " + dt.ToLongTimeString());
            Console.WriteLine("Short Time : " + dt.ToShortTimeString());
            Console.WriteLine("Add 5 Days : " + dt.AddDays(5));
            Console.WriteLine("UTC time : " + dt.ToUniversalTime());
            Console.WriteLine("Local Time : " + dt.ToLocalTime());
            Console.WriteLine("Today : "+DateTime.Today);
           

        }
    }
}
