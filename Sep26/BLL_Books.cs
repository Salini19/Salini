using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLlibrary
{
	public class BLL_Books
	{
		private int _bookno;

		public int BookNo
		{
			get { return _bookno; }
			set
			{
				if (value != 0)
				{
					_bookno = value;
				}
				else
				{
					throw new Exception("Invlid bookNo");
				}
			}
		}
		private string _bname;

		public string BookName
		{
			get { return _bname; }
			set
			{
				if (value.Length >= 30)
				{
					throw new Exception("BookName too long.. it shud not exceed 30 chars");
				}
				else
				{
					_bname = value;
				}

			}
		}
		private string _author;

		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}
		public int Cost { get; set; }

		private string _cat;

		public string Category
		{
			get { return _cat; }
			set { _cat = value; }
		}

	}
	public class BLL_Member
	{ 
		private int _mid;
		public int MemberID
		{
			get { return _mid; }
			set { _mid = value; }
		}
		private string _mname;

		public string MemberName
		{
			get { return _mname; }
			set { _mname = value; }
		}

		private DateTime _adate;

		public DateTime Acc_Open_Date
		{
			get { return _adate; }
			set { _adate = value; }
		}
		private int _maxbook;

		public int MaxBooksAllowed
		{
			get { return _maxbook; }
			set { _maxbook = value; }
		}
		private int _penalty;

		public int Penalty
		{
			get { return _penalty; }
			set { _penalty = value; }
		}

	}
	public class BLL_Users
	{
		private string _userid;

		public string Userid
		{
			get { return _userid; }
			set 
			{
				if (string.IsNullOrEmpty(value) || value.Length >=10)
				{
					throw new Exception("Ivalid userid ");
				}
				else
				{
                    _userid = value;
                }
				
			}
		}
		private string _pass;

		public string Password
		{
			get { return _pass; }
			set
			{
				if (string.IsNullOrEmpty(value) || value.Length >= 20)
				{
					throw new Exception("Ivalid password ");
				}
				else
				{
					_pass = value;
				}

			}
		}

	}
	public class BLL_Issue
	{
        public int Lib_Issue_Id { get; set; }
        public int Book_No { get; set; }


        private int _memberid;

        public int Member_Id
        {
            get { return _memberid; }
            set
            {
                if (value > 0 && value < 7)
                {
                    _memberid = value;

                }
                else
                {
                    Console.WriteLine("Invalid Member Id");
                }
            }
        }


        public DateTime Issue_Date { get; set; }



        private DateTime _Return_Date;

        public DateTime Return_Date
        {
            get { return _Return_Date; }
            set { _Return_Date = value; }

        }
		public string status { get; set; }

	}
}
