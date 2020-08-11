using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WDDNLab5
{
    public partial class display_user_data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie user_data = Request.Cookies["user_data"];
            if (user_data == null)
            {
                Response.Write("You haven't submitted " +
                    "your details. <a href='WebForm1.aspx'>Click here to enter your details</a>");
            }
            else
            {
                Label1.Text = user_data["unm"];
                Label2.Text = user_data["dob"];
                Label3.Text = user_data["langs"];
                //Delete Cookie
                user_data.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(user_data);
            }
        }
    }
}