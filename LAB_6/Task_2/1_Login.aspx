<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Login.aspx.cs" Inherits="ADO_2._1_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <h2>Login</h2>
            User ID:
            <asp:TextBox ID="Uid" runat="server" ></asp:TextBox>
            <br />
            <br />
            Password: <asp:TextBox ID="Pwd" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" Text="Login" OnClick="Validate"/>
            <br />
            <br />
            <asp:Label ID="Invalid" runat="server" ForeColor="Red" Text=""></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>

