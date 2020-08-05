<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayImg.aspx.cs" Inherits="WDDN_Lab4.DisplayImg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="imgform" runat="server" class="auto-style1">
        <div>
            <asp:Button runat="server" OnClick="display_img" Text="Toggle Image on/off" Width="137px" />
        </div>
    </form>
    <asp:Image ID="Img" ImageUrl="~/static1/3d_coffee.png" Visible="false" Width="100%" Height="100%" runat="server" />
</body>
</html>
