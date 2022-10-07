using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Book_BAL;

namespace WebApp_Oct3
{
    public partial class BookRequestForm : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-1I1KGJE\\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Welcome " + Session["userid"].ToString();
            Display();
        }
        public void Display()
        {
            SqlCommand cmd = new SqlCommand("select * from Book", cn);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Label2.Text = "List of books displayed..";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User l = new User();
            Book b = new Book();
            b.Bookid = Convert.ToInt32(TextBox1.Text);

            SqlCommand cmd = new SqlCommand("select * from Book where Book_No=' " + b.Bookid + "'", cn);
            cn.Open();
            int i =cmd.ExecuteNonQuery();

            if (i != 0)
            {
                Label5.Text = "Book is available..";
            }
            else
            {
                Label5.Text = "Book is Not Available";
            }
            cn.Close();



        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            User l = new User();
            Book b = new Book();
            Issue i = new Issue();
            Members m = new Members();

            TextBox3.Text = Calendar4.SelectedDate.ToLongDateString();
            TextBox4.Text = Calendar1.SelectedDate.ToLongDateString();

            i.id = Convert.ToInt32(TextBox5.Text);
            b.Bookid = Convert.ToInt32(TextBox1.Text);
            m.MemberId = Convert.ToInt32(TextBox2.Text);
            i.Issuedate = Convert.ToDateTime(TextBox3.Text);
            i.return_date = Convert.ToDateTime(TextBox4.Text);

            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into Issue(Lib_Issue_id,MemberId,Book_No,Issue_date,Return_Date) values('" + i.id + "','" + m.MemberId+ "','" + b.Bookid +"','" + i.Issuedate + "','" + i.return_date + "')", cn);
            cmd.ExecuteNonQuery();
            Label8.Text = " Inserted succesfully...";
           

            cn.Close();
            Response.Redirect("~/WebForm2.aspx");

        }
    }
}