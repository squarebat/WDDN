<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WDDNLab5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Tell us about yourself.</h3>
            Your Name: <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
            <br />
            <br />
            Date of birth: <asp:TextBox ID="Dob" TextMode="Date" runat="server" ></asp:TextBox>
            <br />
            <br />
            Preferred Languages:<br />
            <asp:CheckBoxList ID="Languages" runat="server">
                <asp:ListItem>C++</asp:ListItem>
                <asp:ListItem>Java</asp:ListItem>
                <asp:ListItem>Python</asp:ListItem>
                <asp:ListItem>PHP</asp:ListItem>
                <asp:ListItem>C#</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="PostProcess" Text="Submit" />
        </div>
    </form>
</body>
</html>
