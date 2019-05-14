<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckPlease.aspx.cs" Inherits="CheckPlease" %>

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
                <table>
                    <tr><th>桌號</th><th>金額</th><th>人數</th><th>工作人員</th><th></th></tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("TableNumbers")%></td><td><%# Eval("Prices")%></td>
                    <td><%# Eval("People")%></td><td><%# Eval("Uname")%></td>
                    <td><asp:LinkButton ID="HlbClose" runat="server" Text="結帳" CommandName="Close" onclientclick="return confirm('確定結帳嗎?')" ></asp:LinkButton>
                        <asp:LinkButton ID="HlbDetail" runat="server" Text="明細" CommandName="Detail"  ></asp:LinkButton>

                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
        <br />
          <asp:Repeater ID="Rtlist2" runat="server">
            <HeaderTemplate> 
                <p>餐點明細</p>
                <table>
                <tr>
                    <th>餐點名稱</th><th>數量</th><th>價格(一份)</th>
                </tr>
                </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("Foods")%></td>
                    <td><%# Eval("Counts")%></td>
                    <td><%# Eval("Prices")%></td>
                </tr>

            </ItemTemplate>
              <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
        <br />
        <asp:Label ID="LbMoney" runat="server" Text=""></asp:Label>
          <asp:Repeater ID="Rtlist3" runat="server">
            <HeaderTemplate> 
                <p>已結帳餐點明細</p>
                <table>
                <tr>
                    <th>餐點名稱</th><th>數量</th>
                </tr>
                </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("Foods")%></td>
                    <td><%# Eval("Counts")%></td>                    
                </tr>

            </ItemTemplate>
              <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
