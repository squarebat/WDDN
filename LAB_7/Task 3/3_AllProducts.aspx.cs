using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7Task3
{
    public partial class _3_AllProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void redir_home(object sender, EventArgs e)
        {
            Response.Redirect("1_Home.aspx");
        }
    }
}