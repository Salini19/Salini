using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolymorphism
{
    internal class Novels:Book
    {
        private int _numpg;

        public int NumberofPages
        {
            get { return _numpg; }
            set { _numpg = value; }
        }

        public void InsertBook(int bookid, string bookname, int price, int numofpg)
        {
            BookID=bookid;
            BookName = bookname;
            Price = price;
            NumberofPages=numofpg;
        }
    }
}
