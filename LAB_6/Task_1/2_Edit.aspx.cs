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
    public partial class Edit : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connection1"].ConnectionString;
            UpdateSec.Visible = false;
        }

        protected void Fetch(object sender, EventArgs e)
        {
            if (Id.Text == null)
            {
                Response.Write("Enter a value!<br>");
                return;
            }
            int id = Convert.ToInt32(Id.Text);
            try
            {
                using (con)
                {
                    con.Open();
                    string query = "Select * " +
                        " from dbo.students  where id = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@Id", id);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();
                    Name.Text = rdr["Name"].ToString();
                    Sem.Text = rdr["Sem"].ToString();
                    Phone.Text = rdr["Phone_no"].ToString();
                    EmailId.Text = rdr["Email_id"].ToString();
                    con.Close();
                }
            }
            catch (Exception err)
            {
                Info.Text = "Error: ";
                Info.Text += err.Message;
            }
            UpdateSec.Visible = true;
        }

        protected void Update_data(object sender, EventArgs e)
        {
            UpdateSec.Visible = true;
            int id = Convert.ToInt32(Id.Text);
            string name = Name.Text;
            string sem = Sem.Text;
            string phone_no = Phone.Text;
            string email_id = EmailId.Text;
            try
            {
                using (con)
                {
                    con.Open();
                    string query = "UPDATE dbo.students set Name = @Name, " +
                        "Sem = @Sem, Phone_no = @Phone_no, Email_id = @EmailId where id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone_no", phone_no);
                    cmd.Parameters.AddWithValue("@Sem", sem);
                    cmd.Parameters.AddWithValue("@EmailId", email_id);
                    cmd.ExecuteNonQuery();
                    Info.Text = "The data has been updated successfully!<br>";
                    con.Close();
                }
            }
            catch (Exception err)
            {
                Info.Text = "Error: ";
                Info.Text += err.Message;
            }
        }

        protected void Insert(object sender, EventArgs e)
        {
            Response.Redirect("1_Insert.aspx");
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