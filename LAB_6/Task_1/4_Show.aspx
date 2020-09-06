<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_Show.aspx.cs" Inherits="WDDN_ADO._4_Show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Students Data</h3>
            <asp:GridView ID="DataDisplay" runat="server">
            </asp:GridView><br/>

            <asp:Label ID="Info" ForeColor="Green" runat="server" Text=""></asp:Label>
            <h3>Edit your details:</h3>

            <asp:Button runat="server" Text="Insert" OnClick="Insert" />
    &nbsp;
            <asp:Button runat="server" Text="Edit" OnClick="Edit"/>
    &nbsp;
            <asp:Button runat="server" Text="Delete" OnClick="Delete"/>
        </div>
    </form>
</body>
</html>
