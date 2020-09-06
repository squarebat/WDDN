using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO_2
{
    public partial class _3_Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["order"] == null)
            {
                DisplayOrders.Visible = false;
                Price.Text = "You haven't placed any orders yet!!!";
            }
            else
            {
                Dictionary<string, int> order_details = (Dictionary<string, int>)Session["order"];
                int cost = 0;
                
                foreach (KeyValuePair<string,int> kp in order_details)
                {
                    TableRow tr = new TableRow();
                    TableCell pname = new TableCell();
                    TableCell pcost = new TableCell();
                    pname.Controls.Add(new LiteralControl(kp.Key));
                    pcost.Controls.Add(new LiteralControl(kp.Value.ToString()));
                    tr.Cells.Add(pname);
                    tr.Cells.Add(pcost);
                    DisplayOrders.Rows.Add(tr);
                    cost += kp.Value;
                }
                Price.Text = "Total Amount: "+cost+" Rs" +
                    "<br> Come Again Soon!";
            }
        }
    }
}