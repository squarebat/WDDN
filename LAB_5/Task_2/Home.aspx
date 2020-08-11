<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WDDNLab5.Shop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Welcome" runat="server" Text="Welcome " 
            Font-Bold="true" ForeColor="Green" Font-Size="X-Large"></asp:Label>
        <div>
            <h4 style="color:cornflowerblue">What would you like to buy?</h4>
            <p>
                <asp:RadioButtonList ID="Things" AutoPostBack="true" runat="server" OnSelectedIndexChanged="List_Populate">
                    <asp:ListItem>Electronics</asp:ListItem>
                    <asp:ListItem>Books</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <p>
                <asp:ListBox ID="ListOfItems" runat="server" Height="148px" Width="272px">

                </asp:ListBox>
            </p>
            <p>
                <asp:Button runat="server" Text="Place Order" OnClick="CheckOut"/>
            </p>
        </div>
    </form>
</body>
</html>
