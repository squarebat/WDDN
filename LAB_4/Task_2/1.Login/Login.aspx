<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WDDN_Lab4.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:
            <asp:TextBox ID="Unm" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:
            <asp:TextBox ID="Pwd" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Submit" runat="server" Text="Login" OnClick="Validate"/>
        </div>

        <br />
        <asp:Label ID="Error" ForeColor="Red" runat="server" Text=""></asp:Label>

    </form>
</body>
</html>
