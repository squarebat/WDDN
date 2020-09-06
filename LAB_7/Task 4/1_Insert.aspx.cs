using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_Task4
{
    public partial class _1_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        /*protected void db_init()
        {
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Con1"].ConnectionString;
        }*/
        protected void Insert_Details(object sender, EventArgs e)
        {
            using (lab7DataContext dbcontext = new lab7DataContext())
            {
                student stud = new student
                {
                    name = Name.Text,
                    sem = Convert.ToInt32(Sem.Text),
                    cpi = Convert.ToInt32(CPI.Text),
                    contact_no = Convert.ToDecimal(ContactNo.Text),
                    email_id = Email.Text
                };

                dbcontext.students.InsertOnSubmit(stud);
                dbcontext.SubmitChanges();
                Label1.Text = "Data Inserted Successfully!";
            }
        }

        protected void Update_Details(object sender, EventArgs e)
        {
            Response.Redirect("2_Update.aspx");
        }

        protected void Delete_Details(object sender, EventArgs e)
        {
            Response.Redirect("3_Delete.aspx");
        }

        protected void Show_Details(object sender, EventArgs e)
        {
            Response.Redirect("4_Show.aspx");
        }
    }
}