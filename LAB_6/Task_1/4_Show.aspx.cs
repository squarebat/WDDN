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
    public partial class _4_Show : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connection1"].ConnectionString;
            try
            {
                using (con)
                {
                    string query = "select * from dbo.students";
                    SqlCommand cmd = new SqlCommand(query,con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    DataDisplay.DataSource = rdr;
                    DataDisplay.DataBind();
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

        protected void Edit(object sender, EventArgs e)
        {
            Response.Redirect("2_Edit.aspx");

        }

        protected void Delete(object sender, EventArgs e)
        {
            Response.Redirect("3_Delete.aspx");
        }
    }
}