using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL_Lib;

namespace Sep30_WebApp
{
    public partial class CustomerLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed3_SelectionChanged(object sender, EventArgs e)
        {
            lbldate.Text = calDOB.SelectedDate.ToLongDateString();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.FirstName = txtfirstname.Text;
            c.LastName = txtlastname.Text;
            c.Dob=Convert.ToDateTime(lbldate.Text);
            c.City = txtcity.Text;
            c.State = txtstate.Text;

            HttpCookie cookie = new HttpCookie("Customer Details");
            cookie.Expires = DateTime.Now.AddMinutes(10);
            cookie.Values.Add("FirstName", c.FirstName);
            cookie.Values.Add("LastName", c.LastName);
            cookie.Values.Add("DoB", c.Dob.ToLongDateString());
            cookie.Values.Add("City", c.City);
            cookie.Values.Add("State", c.State);

            Response.Cookies.Add(cookie);

            lblsucess.Text = "Thanks for the input";
        }

    }
}