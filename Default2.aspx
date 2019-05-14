<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="Sid">
            <Columns>
                <asp:BoundField DataField="Sid" HeaderText="Sid" InsertVisible="False" ReadOnly="True" SortExpression="Sid" />
                <asp:BoundField DataField="Foods" HeaderText="Foods" SortExpression="Foods" />
                <asp:BoundField DataField="Counts" HeaderText="Counts" SortExpression="Counts" />
                <asp:BoundField DataField="Prices" HeaderText="Prices" SortExpression="Prices" />
                <asp:BoundField DataField="Uname" HeaderText="Uname" SortExpression="Uname" />
                <asp:BoundField DataField="TableNumbers" HeaderText="TableNumbers" SortExpression="TableNumbers" />
                <asp:BoundField DataField="People" HeaderText="People" SortExpression="People" />
                <asp:BoundField DataField="Cdate" HeaderText="Cdate" SortExpression="Cdate" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RestaurantConnectionString %>" SelectCommand="SELECT * FROM [Order_Temp]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
