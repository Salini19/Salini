using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sep30_WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("Welcome to Login page");
            }
            else if (txtusername.Text == "Salini" && txtpassword.Text == "Salini@123")
            {
                //Response.Write("You are Logged in Sucessfully");
                Response.Redirect("http://www.google.com");
            }
            else
            {
                lblmessage.Text= "Invalid userid/password... Pls check..";
            }
            
        }

        
    }
}