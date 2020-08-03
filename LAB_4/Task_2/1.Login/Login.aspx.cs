using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WDDN_Lab4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Validate(object sender, EventArgs e)
        {
            string err_msg = "One of the fields is empty!";
            string uname = Unm.Text;
            string pwd = Pwd.Text;
            if (uname != null && pwd != null)
            {
                if (uname == "admin" && pwd == "admin")
                {
                    Response.Redirect("user_details.aspx");
                }
                else
                {
                    err_msg = "Username or password is invalid!";
                }
            }
            Error.Text = err_msg;            
        }
    }
}