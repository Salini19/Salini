using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolymorphism
{
    public class BookCatgeory
    {
		private int _catid;

		public int CategoryID
		{
			get { return _catid; }
			set { _catid = value; }
		}

		private string _catname;

		public string CategoryName
		{
			get { return _catname; }
			set { _catname = value; }
		}
		private string _desc;

		public string Description
		{
			get { return _desc; }
			set { _desc = value; }
		}

		public BookCatgeory()
		{

		}
		public BookCatgeory(int cid,string cname,string desc)
		{
			_catid = cid;
			_catname = cname;
			_desc = desc;
		}


		public interface A
		{
			void Add(BookCatgeory bookCatgeory);
		}
	}
	public abstract class Category
	{
		public abstract void DeleteCategory(int cid);
	}
}
