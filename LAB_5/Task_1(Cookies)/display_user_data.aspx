<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="display_user_data.aspx.cs" Inherits="WDDNLab5.display_user_data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>The details you've entered are as follows:</h3>
            
        </div>
        <b>Your Name: </b><asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <b>Date of birth: </b><asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br />
        <b>Preferred languages: </b><asp:Label ID="Label3" runat="server" Text=""></asp:Label>
     
    </form>
</body>
</html>
