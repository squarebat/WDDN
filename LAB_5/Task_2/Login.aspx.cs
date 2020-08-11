using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WDDNLab5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Validate(object sender, EventArgs e)
        {
            if (Uname.Text == "Khadija" && Pwd.Text == "admin")
            {
                Session["Uname"] = Uname.Text;
                Response.Redirect("Home.aspx");
            }
            else
            {
                Invalid.Text = "Username or password are invalid!";
            }
        }
    }
}