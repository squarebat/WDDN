<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_details.aspx.cs" Inherits="WDDN_Lab4.user_details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
        
    <form id="form1" runat="server">
        <div>
            
            Full name:
            <asp:TextBox ID="Name" runat="server" Width="134px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:RequiredFieldValidator ID="UnmVal" ControlToValidate="Name" runat="server" ForeColor="Red" 
                ErrorMessage="Please enter your Name!"></asp:RequiredFieldValidator>
            <br />

            Age:
            <asp:TextBox ID="Age" runat="server"></asp:TextBox>
            <br />
            <asp:RangeValidator ID="AgeVal" runat="server" ControlToValidate="Age" MinimumValue="18" MaximumValue="50"
                ForeColor="Red" ErrorMessage="Age Must be between 18 to 50"></asp:RangeValidator>
            <br />
            Password:
            <input id="Pwd" type="password" runat="server"/><br />
            <br />
            Confirm Password:
            <input id="cpwd" type="password" runat="server"/><br />
            <asp:CompareValidator ID="PwdVal" runat="server" ControlToValidate="cpwd" ControlToCompare="Pwd" 
                ForeColor="Red" ErrorMessage="Passwords do not match!"></asp:CompareValidator>
            <br />
            Gender:<br />
&nbsp;      <asp:RadioButtonList ID="Gender" runat="server" Width="128px">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Hobbies:
            <br />
            <br />
            <asp:CheckBoxList ID="Hobbies" runat="server">
                <asp:ListItem>Coding</asp:ListItem>
                <asp:ListItem>Reading</asp:ListItem>
                <asp:ListItem>Travelling</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            State:&nbsp;&nbsp;
            <asp:DropDownList ID="State" AutoPostBack="true" runat="server"
                OnSelectedIndexChanged="fill_cities" Width="152px">
                <asp:ListItem>Choose State</asp:ListItem>
                <asp:ListItem>Gujarat</asp:ListItem>
                <asp:ListItem>Maharashtra</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            City:&nbsp;&nbsp;&nbsp; 
            <asp:DropDownList ID="City" runat="server" Height="22px" Width="157px">
            </asp:DropDownList>
            <br />
            <br />
            Mobile no:&nbsp;
            <asp:TextBox ID="Mobile" runat="server"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="MobVal" ControlToValidate="Mobile" ValidationExpression="^\d{10}$" runat="server" 
                ForeColor="Red" ErrorMessage="Phone no must be 10 digits long"></asp:RegularExpressionValidator>
            <br />
            Pan:&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="PanID" runat="server" CausesValidation="True"></asp:TextBox>
            <br />
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="PanID" 
                ErrorMessage="Pan must start with A or B and should be 10 digits long." ForeColor="Red"
                OnServerValidate="CustomValidator1_ServerValidate"  Enabled="True" ValidateEmptyText="True" Display="Dynamic"></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="print_details"/>
            &nbsp;
            <input id="Reset1" type="reset" value="reset" /><br />
            <br />
            
        </div>
    </form>
</body>
</html>
