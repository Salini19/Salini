using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Book_BAL;

namespace WebApp_Oct3
{
    public partial class BookingForm : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-1I1KGJE\\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.username = TextBox1.Text;
            u.password = TextBox2.Text;
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into users values('" + u.username + "','" + u.password + "')", cn);
            cmd.ExecuteNonQuery();
            Label3.Text = "Signed up succesfully...";
            TextBox1.Text = " ";
            cn.Close();
        }
    }
}