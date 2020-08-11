<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WDDNLab5.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login</h2>
            Username:
            <asp:TextBox ID="Uname" runat="server" ></asp:TextBox>
            <br />
            <br />
            Password: <asp:TextBox ID="Pwd" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" Text="Login" OnClick="Validate"/>
            <br />
            <br />
            <asp:Label ID="Invalid" runat="server" ForeColor="Red" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
