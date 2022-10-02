using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL_Lib;

namespace Sep30_WebApp
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie;
            cookie = Request.Cookies.Get("Customer Details");
            Customer c = new Customer();
            c.FirstName = cookie["FirstName"].ToString();
            c.LastName = cookie["LastName"].ToString();

            lblname.Text = c.FirstName +" "+ c.LastName;
        }
    }
}