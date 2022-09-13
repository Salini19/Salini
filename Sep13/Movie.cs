using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    public class Movie
    {
		private string _lang;

		public string Language
		{
			get { return _lang; }
			set { _lang = value; }
		}
		private string _genre;

		public string Genre
		{
			get { return _genre; }
			set { _genre = value; }
		}
		private string _name;

		public string MovieName
		{
			get { return _name; }
			set { _name = value; }
		}

		
	}
}
