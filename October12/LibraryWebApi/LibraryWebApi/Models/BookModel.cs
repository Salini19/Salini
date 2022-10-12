using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApi.Models
{
    public class BookModel
    {
        public decimal BookNo { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string Category { get; set; }
    }
}