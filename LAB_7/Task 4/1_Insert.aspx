<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Insert.aspx.cs" Inherits="Lab7_Task4._1_Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Insert Details: </h2>
            Name:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <br />
            <br />
            Sem:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Sem" runat="server"></asp:TextBox>
            <br />
            <br />
            CPI:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="CPI" runat="server"></asp:TextBox>
            <br />
            <br />
            Contact No:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="ContactNo" runat="server"></asp:TextBox>
            <br />
            <br />
            Email Id:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Insert_Details"/>
            &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Update_Details"/>
&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Delete_Details"/>
&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Show All" OnClick="Show_Details"/>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="" ForeColor="Green"></asp:Label>

        </div>
    </form>
</body>
</html>
