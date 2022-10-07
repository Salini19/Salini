using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_Oct3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-1I1KGJE\\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
        
            try
            {

                SqlCommand cmd = new SqlCommand("[dbo].[sp_Validation]",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_userid", TextBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@p_pwd", TextBox2.Text.ToString());
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Session["UserId"] = TextBox1.Text.ToString();
                    Label3.Text = "Login Successful!";

                    dr.Close();
                    cn.Close();

                    Response.Redirect("~/BookRequestForm.aspx");
                }
                else
                {
                    Label3.Text = "Invalid credentials";
                }

                dr.Close();

                cn.Close();

            }
            catch (Exception ex)
            {
                Label3.Text=ex.Message;
            }

        }
    }
}