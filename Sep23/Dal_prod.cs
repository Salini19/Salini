using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLLvalidation;

namespace DAL_libarary
{
    public class Dal_prod
    {
        public List<Bl_products> ShowAllProducts()
        {
            string connectionString = "Data Source=DESKTOP-1I1KGJE\\SQLEXPRESS01;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from Products", cn);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<Bl_products> products = new List<Bl_products>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Bl_products productsItem = new Bl_products();
                    productsItem.ProductId = Convert.ToInt32(dr[0]);
                    productsItem.ProductName = dr[1].ToString();
                    productsItem.Price = Convert.ToDouble(dr[5]);

                    products.Add(productsItem);
                }
            }
            else
            {
                Console.WriteLine("No records found");
            }

            cn.Close();
            return products;
        }
        
    }
}
