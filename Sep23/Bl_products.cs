using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLvalidation
{
    public class Bl_products
    {
		
        private string _pname;

        public string ProductName
        {
            get { return _pname; }
            set
            {
                if ((value.Length > 40) || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Not valid Title.... Please check");
                }
                else
                {
                    _pname = value;
                }

            }
        }
        private int _pid;

        public int ProductId
        {
            get { return _pid; }
            set 
            {
                if (value!=0)
                {
                    _pid = value;
                }
                else
                {
                    throw new Exception("Productid is invalid");
                }
                
            }
        }

        public double Price { get; set; }




    }
}
