using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WDDN_Lab4
{
    public partial class user_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void fill_cities(object sender, EventArgs e)
        {
            City.Items.Clear();
            
            string state = State.SelectedItem.Text;
            ListItem choose = new ListItem("Choose City", "Choose City");
            City.Items.Add(choose);

            if (state == "Gujarat")
            {
                ListItem amd = new ListItem("Ahmedabad", "Ahmedabad");
                ListItem vad = new ListItem("Vadodara", "Vadodara");
                City.Items.Add(amd);
                City.Items.Add(vad);
            }
            if (state == "Maharashtra")
            {
                ListItem mum = new ListItem("Mumbai", "Mumbai");
                ListItem pun = new ListItem("Pune", "Pune");
                City.Items.Add(mum);
                City.Items.Add(pun);
            }
        }
        protected void print_details(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Response.Write("<h4>The details you entered are displayed as follows</h4>");
                Label1.Text = "Full Name: " + Name.Text + "<br/>";
                Label2.Text = "Age: " + Age.Text + "<br/>";
                string gender = "I prefer not to say";
                if (Gender.SelectedItem != null)
                {
                    gender = Gender.SelectedItem.Text;
                }
                Label4.Text = "Gender: " + gender + "<br/>";
                string hobbies = "";
                for (int i = 0; i < Hobbies.Items.Count; i++)
                {
                    if (Hobbies.Items[i].Selected)
                    {
                        hobbies = hobbies + Hobbies.Items[i];
                        if (i < Hobbies.Items.Count - 1)
                        {
                            hobbies = hobbies + ", ";
                        }
                    }
                }
                Label5.Text = "Hobbies: " + hobbies + "<br/>";
                if (State.SelectedItem != null)
                    Label6.Text = "State: " + State.SelectedItem.Text + "<br/>";
                if (City.SelectedItem != null)
                    Label7.Text = "City: " + City.SelectedItem.Text + "<br/>";
                Label8.Text = "Pan: " + PanID.Text + "<br/>";
                Label9.Text = "Mobile no: " + Mobile.Text + "<br/><br/>";
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string pan = args.Value;
            if (pan.Length == 10 && (pan.StartsWith("A") || pan.StartsWith("B")))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}