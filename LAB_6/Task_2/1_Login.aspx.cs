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

namespace ADO_2
{
    public partial class _1_Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connection1"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from users";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            try
            {
                using (con)
                {
                    con.Open();
                    da.Fill(ds, "users");
                    con.Close();
                }
            }
            catch (Exception err)
            {
                Invalid.Text = err.Message;
            }
        }

        protected void Validate(object sender, EventArgs e)
        {
            string uid = Uid.Text;
            string pwd = Pwd.Text;
            if (uid == null || pwd == null)
            {
                Invalid.Text = "Username and password cannot be blank!";
                return;
            }
            int id = Convert.ToInt32(uid);
            DataRow fetch = ds.Tables["users"].AsEnumerable().FirstOrDefault(row=>row.Field<int>("userid")==id);
            if (fetch == null || fetch["password"].ToString() != pwd)
            {
                Invalid.Text = "User Id or password Invalid!";
            }
            else
            {
                Session["Uid"] = id;
                Response.Redirect("2_Product.aspx");
            }

        }
    }
}