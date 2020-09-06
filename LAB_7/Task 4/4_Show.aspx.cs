using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_Task4
{
    public partial class _4_Show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*lab7DataContext dataContext = new lab7DataContext();
            GridView1.DataSource = from student in dataContext.students select new { Sid = student.sid, Name = student.name };*/
        }
                                  
        protected void Insert_Details(object sender, EventArgs e)
        {
            Response.Redirect("1_Insert.aspx");
        }

        protected void Update_Details(object sender, EventArgs e)
        {
            Response.Redirect("2_Update_dets.aspx");
        }

        protected void Delete_Details(object sender, EventArgs e)
        {
            Response.Redirect("3_Delete.aspx");
        }
    }
}