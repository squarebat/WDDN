<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_Show.aspx.cs" Inherits="Lab7_Task4._4_Show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>All Data</h2>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="sid" DataSourceID="SqlDataSource1" Width="214px" AllowSorting="True">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="sid" HeaderText="sid" InsertVisible="False" ReadOnly="True" SortExpression="sid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
              
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:lab7_4ConnectionString %>" DeleteCommand="DELETE FROM [students] WHERE [sid] = @sid" InsertCommand="INSERT INTO [students] ([name]) VALUES (@name)" SelectCommand="SELECT [sid], [name] FROM [students]" UpdateCommand="UPDATE [students] SET [name] = @name WHERE [sid] = @sid">
                <DeleteParameters>
                    <asp:Parameter Name="sid" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="name" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="sid" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
        </div>
        
        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Insert_Details"/>
            &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Update_Details"/>

        &nbsp;

        <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Delete_Details"/>
&nbsp;
&nbsp;<br />
&nbsp;<div id="ShowDetails" runat="server">

            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="sid" DataSourceID="LinqDataSource1" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="sid" HeaderText="sid" InsertVisible="False" ReadOnly="True" SortExpression="sid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="sem" HeaderText="sem" SortExpression="sem" />
                    <asp:BoundField DataField="cpi" HeaderText="cpi" SortExpression="cpi" />
                    <asp:BoundField DataField="contact_no" HeaderText="contact_no" SortExpression="contact_no" />
                    <asp:BoundField DataField="email_id" HeaderText="email_id" SortExpression="email_id" />
                </Fields>
            </asp:DetailsView>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Lab7_Task4.lab7DataContext" EntityTypeName="" TableName="students" Where="sid == @sid">
                <WhereParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="sid" PropertyName="SelectedValue" Type="Int32" DefaultValue="2" />
                </WhereParameters>
            </asp:LinqDataSource>

      </div>      
            
    </form>
</body>
</html>
