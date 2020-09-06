<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_Delete.aspx.cs" Inherits="WDDN_ADO._3_Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Id:
            <asp:TextBox ID="Id" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Delete" Text="Delete data" />
            <br />
            <br />
            <asp:Label ID="Info" ForeColor="Green" runat="server" Text=""></asp:Label>
            <h3>Edit your details:</h3>

            <asp:Button runat="server" Text="Insert" OnClick="Insert" />
    &nbsp;
            <asp:Button runat="server" Text="Edit" OnClick="Edit"/>
    &nbsp;
            <asp:Button runat="server" Text="Show All Data" OnClick="Show"/>
        </div>
    </form>
</body>
</html>
