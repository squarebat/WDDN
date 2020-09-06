<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Product.aspx.cs" Inherits="ADO_2._2_Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="color:green" runat="server" id="welcome">Welcome User: </h2>
            <h3>These are all our products:</h3>
            <p>
                <asp:GridView ID="ProductView" runat="server" Width="306px">
                </asp:GridView>
            </p>
            <h3>What do you want to buy?</h3>
            <p>
                <asp:ListBox ID="ProductList" runat="server" Height="175px" Width="310px"></asp:ListBox>
            </p>
            <p>
                <asp:Button runat="server" Text="Place Order" OnClick="proceed"/>
            </p>
        </div>
    </form>
</body>
</html>
