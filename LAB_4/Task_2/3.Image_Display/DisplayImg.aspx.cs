using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WDDN_Lab4
{
    public partial class DisplayImg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void display_img(object sender, EventArgs e)
        {
            Img.Visible = !Img.Visible;
        }
    }
}