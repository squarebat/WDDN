<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_Order.aspx.cs" Inherits="ADO_2._3_Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Your Orders</h2>
            <asp:Table ID="DisplayOrders" runat="server" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="240px">
                <asp:TableRow runat="server" Font-Bold="True">
                    <asp:TableCell runat="server">Product</asp:TableCell>
                    <asp:TableCell runat="server">Price</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <asp:Label ID="Price" Text="" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
