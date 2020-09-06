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
    public partial class _3_Delete : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connection1"].ConnectionString;
        }

        protected void Delete(object sender, EventArgs e)
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
                    string query = "delete " +
                        " from dbo.students  where id = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Info.Text = "Data deleted Successully!<br>";
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

        protected void Edit(object sender, EventArgs e)
        {
            Response.Redirect("2_Edit.aspx");

        }

        protected void Show(object sender, EventArgs e)
        {
            Response.Redirect("4_Show.aspx");
        }
    }
}