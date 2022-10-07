using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_BAL
{
    public class Book
    {
        public int Bookid { get; set; }
        public string BookName { get; set; }
        public int cost { get; set; }
    }
    public class Issue
    {
        public int id { get; set; }
        public DateTime Issuedate { get; set; }
        public DateTime return_date { get; set; }


    }
    public class Members
    {
        public int MemberId { get; set; }
    }
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
