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

namespace WDDN_ADO
{
    public partial class _1_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert_data(object sender, EventArgs e)
        {
            string name = Name.Text;
            string sem = Sem.Text;
            string phone_no = Phone.Text;
            string email_id = EmailId.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connection1"].ConnectionString;
            try
            {
                using (con)
                {
                    con.Open();
                    string cmd = "Insert" +
                        " into dbo.students  output inserted.id values(@Name,@Sem,@PhoneNo,@EmailId)";
                    SqlCommand query = new SqlCommand(cmd,con);
                    query.Prepare();
                    query.Parameters.AddWithValue("@Name",name);
                    query.Parameters.AddWithValue("@Sem",sem);
                    query.Parameters.AddWithValue("@PhoneNo",phone_no);
                    query.Parameters.AddWithValue("@EmailId",email_id);
                    int id = Convert.ToInt32(query.ExecuteScalar());
                    con.Close();
                    Info.Text = "Your details have been inserted to database successfully!<br>" +
                        "Your id is: "+id+"<br>";

                }
            }
            catch (Exception err)
            {
                Info.Text = "Error: ";
                Info.Text += err.Message;
            }
        }

        protected void Edit(object sender, EventArgs e)
        {
            Response.Redirect("2_Edit.aspx");
        }

        protected void Delete(object sender, EventArgs e)
        {
            Response.Redirect("3_Delete.aspx");

        }

        protected void Show(object sender, EventArgs e)
        {
            Response.Redirect("4_Show.aspx");
        }
    }
}