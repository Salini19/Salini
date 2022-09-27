using BLLlibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALlibrary;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace HelperLibrary
{
    public class Helper_Books
    {
        Dal_books dal = null;
        public Helper_Books()
        {
            dal = new Dal_books();
        }
        public bool AddBook(BLL_Books Book)
        {
            return dal.InsertBook(Book);
        }
        public bool AddUser(BLL_Member member)
        {
            return dal.InsertUser(member);
        }
        public bool UpdateUser(BLL_Member member)
        {
            return dal.UpdateUser(member);
        }
        public void ValidateUser(BLL_Users user)
        {
            dal.ValidateUser(user);
        }
        public List<BLL_Books> Booklist()
        {
            return dal.Booklist();
        }
        public bool IssueBook(BLL_Issue issue)
        {
            return dal.BorrowBook(issue);
        }
        public bool ReturnBook(BLL_Issue issue)
        {
            return dal.ReturnBook(issue);
        }
    }

    
}
