using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public class CustomerOrder
    {
        public void Discount(Customer c,Order o)
        {
            if (c.CustType == CustomerType.Premium)
            {
                o.Amount = o.Amount - ((o.Amount * 10) / 100);
            }
            else if (c.CustType == CustomerType.Gold)
            {
                o.Amount = o.Amount - ((o.Amount * 20) / 100);
            }         
        }
        public void GetCustList(Customer c1)
        {
            SqlConnection cn = new SqlConnection("Data Source=desktop-1i1kgje\\sqlexpress01;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Customers",cn);
            cn.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            List<Customer> list = new List<Customer>();

            while (dr.Read())
            {
                Customer c = new Customer();
                c.CustomerId = dr["CustomerID"].ToString();
                c.CustName = dr["ContactName"].ToString();
                list.Add(c);

            }
            

            cn.Close();
            cn.Dispose();
            c1.CustList=list;


        }
    }
}
