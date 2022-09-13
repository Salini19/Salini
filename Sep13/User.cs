using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        private int _phno;

        public int PhoneNumber
        {
            get { return _phno; }
            set { _phno = value; }
        }
        public DateTime AddedDate { get; set; }

        private List<Movie> _moviestock;

        public List<Movie> MovieStock
        {
            get { return _moviestock; }
            set
            {
                if (MovieStock.Count >= 5) { _moviestock = value; }
                else
                {
                    Console.WriteLine("No more rental is allowed if the limit is reached");
                }
            }
        }
        public void Display()
        {
            if (MovieStock.Count == 2)
                Console.WriteLine("Hello User you have a Silver Badge");
            if (MovieStock.Count == 3)
                Console.WriteLine("Hello User you have a Gold Badge");
            if (MovieStock.Count == 5)
                Console.WriteLine("Hello User you have a Platinum Badge");


        }
    }
    enum Seats
    {
        Silver = 2,
        Gold=3,
        Platinum=5
    }


    public class SilverUser : User
    {
        private List<Movie> _moviestock;

        public new List<Movie> MovieStock
        {
            get { return _moviestock; }
            set
            {
                if (MovieStock.Count == 2) { _moviestock = value; }

            }
        }


    }

    public class GoldUser : SilverUser
    {
        private List<Movie> _moviestock;

        public new List<Movie> MovieStock
        {
            get { return _moviestock; }
            set
            {
                if (MovieStock.Count == 3) { _moviestock = value; }

            }
        }

    }

    public class PlatinumUser : GoldUser
    {
        private List<Movie> _moviestock;

        public new List<Movie> MovieStock
        {
            get { return _moviestock; }
            set
            {
                if (MovieStock.Count == 5) { _moviestock = value; }

            }
        }


    }
}
