using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_Task4
{
    public partial class _2_UpdateDets : System.Web.UI.Page
    {
        //int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Fields.Visible = false;
        }
        protected void Insert_Details(object sender, EventArgs e)
        {
            Response.Redirect("1_Insert.aspx");
        }
        protected void Fill_Details(object sender, EventArgs e)
        {
            using (lab7DataContext dbcontext = new lab7DataContext())
            {
                //id = Convert.ToInt32(Sid.Text);
                student stud = dbcontext.students.SingleOrDefault(x => x.sid == Convert.ToInt32(Sid.Text));
                Name.Text = stud.name;
                Sem.Text = Convert.ToString(stud.sem);
                CPI.Text = Convert.ToString(stud.cpi);
                ContactNo.Text = Convert.ToString(stud.contact_no);
                Email.Text = stud.email_id;
                Fields.Visible = true;
            }
        }
        protected void Update_Details(object sender, EventArgs e)
        {

            using (lab7DataContext dbcontext = new lab7DataContext())
            {
                student stud = dbcontext.students.SingleOrDefault(x => x.sid == Convert.ToInt32(Sid.Text));
                stud.name = Name.Text;
                stud.sem = Convert.ToInt32(Sem.Text);
                stud.cpi = Convert.ToDecimal(CPI.Text);
                stud.contact_no = Convert.ToDecimal(ContactNo.Text);
                stud.email_id = Email.Text;
                
                dbcontext.SubmitChanges();
                Label1.Text = "Data Updated Successfully!";
            }
            
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