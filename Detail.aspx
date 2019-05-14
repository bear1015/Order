<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="Detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="BtGoBack" runat="server" Text="回首頁" OnClick="BtGoBack_Click" />
        <asp:Repeater ID="RtList" runat="server" OnItemCommand="RtList_ItemCommand" OnItemDataBound="RtList_ItemDataBound">
            <HeaderTemplate>
                <p>可加點的桌子</p>
                <table>
                    <tr><th>桌號</th><th>金額</th></tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:LinkButton ID="HlbAdd" runat="server" Text="加點" CommandName="Add" ></asp:LinkButton>
                    </td>
                    <td><%# Eval("Prices")%></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
    </form>
</body>
</html>
