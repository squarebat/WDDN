<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Edit.aspx.cs" Inherits="WDDN_ADO.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        Enter Id:
        <asp:TextBox ID="Id" TextMode="Number" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Fetch" Text="Fetch" />
        
        <div id="UpdateSec" runat="server">
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <br />
            <br />
            Sem:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Sem" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone no:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Phone" runat="server"></asp:TextBox>
            <br />
            <br />
            Email Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="EmailId" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" Text="Update" OnClick="Update_data" />
            <br />
            <br />
            <asp:Label ID="Info" ForeColor="Green" runat="server" Text=""></asp:Label>
            <h3>Edit your details:</h3>

            <asp:Button runat="server" Text="Insert" OnClick="Insert" />
    &nbsp;
            <asp:Button runat="server" Text="Delete" OnClick="Delete"/>
    &nbsp;
            <asp:Button runat="server" Text="Show All Data" OnClick="Show"/>
            </div>
    </form>
</body>
</html>
