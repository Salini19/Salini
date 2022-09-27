using BLLlibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http.Headers;

namespace DALlibrary
{
    public class Dal_books
    {
        public bool InsertBook(BLL_Books Book)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Librarycnstring"].ConnectionString);
            SqlCommand cmdinsert = new SqlCommand("insert into Book(Book_No,Book_Name,Author,Cost,Category) values(@BookNo,@BookName,@Author,@Cost,@Category) ",cn);

            cmdinsert.Parameters.AddWithValue("@BookNo" , Book.BookNo);
            cmdinsert.Parameters.AddWithValue("@BookName", Book.BookName);
            cmdinsert.Parameters.AddWithValue("@Author", Book.Author);
            cmdinsert.Parameters.AddWithValue("@Cost", Book.Cost);
            cmdinsert.Parameters.AddWithValue("@Category", Book.Category);

            cn.Open();
            int i = cmdinsert.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;
        }

        public bool InsertUser(BLL_Member member)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Librarycnstring"].ConnectionString);
            SqlCommand cmdinsertuser = new SqlCommand("[dbo].[sp_InsertUser]", cn);

            cmdinsertuser.CommandType = System.Data.CommandType.StoredProcedure;
            cmdinsertuser.Parameters.AddWithValue("@mem_id",member.MemberID);
            cmdinsertuser.Parameters.AddWithValue("@mem_name", member.MemberName);
            cmdinsertuser.Parameters.AddWithValue("@acc_date", member.Acc_Open_Date);
            cmdinsertuser.Parameters.AddWithValue("@max_books", member.MaxBooksAllowed);
            cmdinsertuser.Parameters.AddWithValue("@penalty", member.Penalty);

            cn.Open();
            int i = cmdinsertuser.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;

        }
        public bool BorrowBook( BLL_Issue issue)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Librarycnstring"].ConnectionString);
            SqlCommand cmdborrowbook = new SqlCommand("[dbo].[sp_Borrowbook]", cn);

            cmdborrowbook.CommandType = System.Data.CommandType.StoredProcedure;
            cmdborrowbook.Parameters.AddWithValue("@lib_issueid", issue.Lib_Issue_Id);
            cmdborrowbook.Parameters.AddWithValue("@BookNo", issue.Book_No);
            cmdborrowbook.Parameters.AddWithValue("@mem_id", issue.Member_Id);
            cmdborrowbook.Parameters.AddWithValue("@issue_date", issue.Issue_Date);
            cmdborrowbook.Parameters.AddWithValue("@return_date", issue.Return_Date);
          

            cn.Open();
            int i = cmdborrowbook.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;

        }
        public bool ReturnBook(BLL_Issue issue)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Librarycnstring"].ConnectionString);
            SqlCommand cmdreturnbook = new SqlCommand("[dbo].[sp_ReturnBook]", cn);

            cmdreturnbook.CommandType = System.Data.CommandType.StoredProcedure;
            cmdreturnbook.Parameters.AddWithValue("@lib_issueid", issue.Lib_Issue_Id);
         
            cn.Open();
            int i = cmdreturnbook.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;

        }
        public bool UpdateUser(BLL_Member member)
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Librarycnstring"].ConnectionString);
            SqlCommand cmdupdateuser = new SqlCommand("[dbo].[sp_UpdateUser]", cn);

            cmdupdateuser.CommandType = System.Data.CommandType.StoredProcedure;

            cmdupdateuser.Parameters.AddWithValue("@mem_id", member.MemberID);
            cmdupdateuser.Parameters.AddWithValue("@mem_name", member.MemberName);
            cmdupdateuser.Parameters.AddWithValue("@acc_date", member.Acc_Open_Date);
            cmdupdateuser.Parameters.AddWithValue("@max_books", member.MaxBooksAllowed);
            cmdupdateuser.Parameters.AddWithValue("@penalty", member.Penalty);

            cn.Open();
            int i = cmdupdateuser.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;
        }
        public void ValidateUser(BLL_Users user)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Librarycnstring"].ConnectionString);
            SqlCommand cmdvalidateuser = new SqlCommand(" [dbo].[fn_ValidateUser](@p_userid,@p_pwd)", cn);
            cmdvalidateuser.Parameters.AddWithValue("@user_id", user.Userid);
            cmdvalidateuser.Parameters.AddWithValue("@password", user.Password);

            cn.Open();
            SqlDataReader dr = cmdvalidateuser.ExecuteReader();
            if(dr != null)
            {
                Console.WriteLine("Logged in Successfully..!");
                
            }
            else
            {
                Console.WriteLine("Invalid Username and password");
            }



        }
        public List<BLL_Books> Booklist()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Librarycnstring"].ConnectionString);
            SqlCommand cmdlist = new SqlCommand("select * from [dbo].[fn_Booklist]()", cn);
            cn.Open();
            SqlDataReader dr = cmdlist.ExecuteReader();
            List<BLL_Books> booklist = new List<BLL_Books>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    BLL_Books bal = new BLL_Books();
                    bal.BookNo = Convert.ToInt32(dr["Book_No"]);
                    bal.BookName = dr["Book_Name"].ToString();
                    bal.Author = dr["Author"].ToString();
                    bal.Cost= Convert.ToInt32(dr["Cost"]);
                    bal.Category = dr["Category"].ToString();

                    booklist.Add(bal);
                }
            }
            cn.Close();
            cn.Dispose();

            return booklist;

        } 
        
    }
}
