<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Home.aspx.cs" Inherits="Lab7Task3._1_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome!</h1>
            Enter Product Id:
            <asp:TextBox ID="Pid" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" Text="Submit" OnClick="process"/>
        </div>
        <br />
        <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
