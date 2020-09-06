<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Insert.aspx.cs" Inherits="WDDN_ADO._1_Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Enter your details here.</h3>

        </div>
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
        <asp:Button runat="server" Text="Submit" OnClick="Insert_data" />
        <br />
        <br />
        
        <asp:Label ID="Info" ForeColor="Green" runat="server" Text=""></asp:Label>
        <h3>Edit your details:</h3>

        <asp:Button runat="server" Text="Edit" OnClick="Edit" />
&nbsp;
        <asp:Button runat="server" Text="Delete" OnClick="Delete"/>
&nbsp;
        <asp:Button runat="server" Text="Show All Data" OnClick="Show"/>
   
     </form>
</body>
</html>
