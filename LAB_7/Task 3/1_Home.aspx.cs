using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7Task3
{
    public partial class _1_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void process(object sender, EventArgs e)
        {
            if (Pid.Text != "")
            {
                Response.Redirect("2_Product.aspx?pid=" + Pid.Text);
            }
            else
            {
                Label1.Text = "Please enter product id!";
            }
        }
    }
}