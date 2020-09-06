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
    public partial class _2_Product : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();

        protected void db_init()
        {
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connection1"].ConnectionString;
            try
            {
                using (con)
                {
                    con.Open();
                    string query = "Select * from products";
                    SqlCommand cmd = new SqlCommand(query, con);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "products");
                    query = "Select * from orders";
                    cmd.CommandText = query;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "orders");
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    con.Close();
                }
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Uid"] == null)
                {
                    Response.Redirect("1_Login.aspx");
                    return;
                }
                welcome.InnerText = "Welcome User: " + Session["Uid"];
                db_init();
                ProductView.DataSource = ds.Tables["products"];
                ProductView.DataBind();
                ProductList.Items.Clear();
                ProductList.SelectionMode = ListSelectionMode.Multiple;
                foreach (DataRow row in ds.Tables["products"].Rows)
                {
                    ProductList.Items.Add(row["pname"].ToString());
                }
            }
        }

        protected void proceed(object sender, EventArgs e)
        {
            try
            {
                db_init();
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connection1"].ConnectionString;
                Dictionary<string, int> products = new Dictionary<string, int>();
                for (int i = 0; i < ProductList.Items.Count; i++)
                {
                    if (ProductList.Items[i].Selected)
                    {
                        string pname = ProductList.Items[i].Text;
                        try
                        {
                            DataRow dr = ds.Tables["products"].AsEnumerable().FirstOrDefault(row => row.Field<string>("pname") == pname);
                            int cost = Convert.ToInt32(dr["cost"].ToString());
                            
                            products.Add(pname, cost);
                           
                            DataTable dt = ds.Tables["orders"];
                            
                            DataRow new_order = dt.NewRow();
                            
                            new_order["userid"] = Session["Uid"];
                            new_order["pid"] = dr["pid"].ToString();
                            dt.Rows.Add(new_order);
                            con.Open();
                            da.Update(ds, "orders");
                            con.Close();                            
                        }
                        catch (Exception err)
                        {
                            Response.Write("here" + err.Message + "<br>");
                        }
                    }
                }
                Session["order"] = products;
                Response.Redirect("3_Order.aspx");
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
            }
        }
    }
}