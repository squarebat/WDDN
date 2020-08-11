using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WDDNLab5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PostProcess(object sender, EventArgs e)
        {
            string unm = UserName.Text;
            string dob = Dob.Text;
            List<string> lang = new List<string>();
            for (int i = 0; i < Languages.Items.Count; i++)
            {
                if (Languages.Items[i].Selected)
                    lang.Add(Languages.Items[i].Text);
            }
            HttpCookie user_data = Request.Cookies["user_data"];
            string langs = String.Join(",", lang);
            if (user_data == null)
            {
                user_data = new HttpCookie("user_data");
            }
            user_data.Expires = DateTime.Now.AddMinutes(5);
            user_data["unm"] = unm;
            user_data["dob"] = dob;
            user_data["langs"] = langs;
            Response.Cookies.Add(user_data);
            Response.Redirect("display_user_data.aspx");
        }
    }
}