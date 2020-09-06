using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Lab7_Task4
{
    public partial class _3_Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Delete_Details(object sender, EventArgs e)
        {
            using (lab7DataContext dbcontext = new lab7DataContext())
            {
                student stud = dbcontext.students.SingleOrDefault(x => x.sid == Convert.ToInt32(Sid.Text));
                dbcontext.students.DeleteOnSubmit(stud);
                dbcontext.SubmitChanges();
                Label1.Text = "Data Deleted Successfully!";
            }
        }

        protected void Insert_Details(object sender, EventArgs e)
        {
            Response.Redirect("1_Insert.aspx");
        }

        protected void Update_Details(object sender, EventArgs e)
        {
            Response.Redirect("2_Update.aspx");
        }

        protected void Show_Details(object sender, EventArgs e)
        {
            Response.Redirect("4_Show.aspx");
        }
    }
}