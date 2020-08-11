using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WDDNLab5
{
    public partial class Shop : System.Web.UI.Page
    {
        IDictionary<string, int> electronics = new Dictionary<string, int>();
        IDictionary<string, int> books = new Dictionary<string, int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Uname"]!=null)
            {
                Welcome.Text = "Welcome "+ Session["Uname"];
            }
            if (electronics.Count == 0)
            {
                electronics.Add("Laptop", 40000);
                electronics.Add("Desktop", 60000);
                electronics.Add("Flash Drive", 400);
                electronics.Add("Smart Phone", 12000);
                electronics.Add("Television Set", 40000);
                electronics.Add("Gaming Console", 80000);
            }
            if (books.Count == 0)
            {
                books.Add("Inferno",300);
                books.Add("Da Vinci Code",400);
                books.Add("The Shiva Trilogy",800);
                books.Add("To kill a mocking bird",200);
                books.Add("Fault in our stars",250);
                books.Add("The God of small things",250);
            }
        }

        protected void List_Populate(object sender, EventArgs e)
        {
            ListOfItems.Items.Clear();
            string section = Things.SelectedItem.Text;
            ListOfItems.SelectionMode = ListSelectionMode.Multiple;
            if (section == "Electronics")
            {          
                foreach (KeyValuePair<string, int> kp in electronics)
                {
                    ListOfItems.Items.Add(String.Format("{0}",kp.Key));
                }
            }
            if (section == "Books")
            {
                foreach (KeyValuePair<string, int> kp in books)
                {
                    ListOfItems.Items.Add(String.Format("{0}", kp.Key));
                }
                
            }
        }

        protected void CheckOut(object sender, EventArgs e)
        {
            Dictionary<string, int> SelectedItems = new Dictionary<string, int>();
            Dictionary<string, int> section;
            if (Things.SelectedItem.Text == "Books")
            {
                section = (Dictionary<string, int>) books;
            }
            else
            {
                section = (Dictionary<string, int>) electronics;
            }
            for (int i = 0; i < ListOfItems.Items.Count; i++)
            {
                if (ListOfItems.Items[i].Selected)
                {
                    SelectedItems.Add(ListOfItems.Items[i].Text,section[ListOfItems.Items[i].Text]);
                }
            }
            Session["Purchase"] = SelectedItems;
            Response.Redirect("order.aspx");
        }
    }
}