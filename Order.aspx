<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>

<%@ Register Src="~/usercontrol/Ddlcounts.ascx" TagPrefix="uc1" TagName="Ddlcounts" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript" src="js/jquery-1.11.3.js"></script>
<script type="text/javascript" src="js/jquery-ui.js"></script>
<script type="text/javascript" src="js/jquery.ui.datepicker-zh-TW.js"></script>
<script type="text/javascript" src="js/headerBanner.js"></script>
<script type="text/javascript" src="js/jquery.flexslider.js"></script>
      
</head>
<body>
    <form id="form1" runat="server">
    
        <div style="float:left">
                <asp:Button ID="Button1" runat="server" Text="冷盤"  OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="炒飯麵" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="炸物" OnClick="Button3_Click" />
                <asp:Button ID="Button4" runat="server" Text="湯品" OnClick="Button4_Click" />
                <asp:Button ID="Button5" runat="server" Text="快炒" OnClick="Button5_Click" />
                <asp:Button ID="Button6" runat="server" Text="燒烤" OnClick="Button6_Click" />
        <asp:Button ID="Button8" runat="server" Text="點餐完成回首頁" OnClick="Button8_Click" />
            <asp:Button ID="Button9" runat="server" Text="取消點餐回到首頁" OnClick="Button9_Click" />
                <br />       
         
        份數:<asp:DropDownList ID="DdlPeople" runat="server" Width="100px">
              <asp:ListItem>1</asp:ListItem>
              <asp:ListItem>2</asp:ListItem>
              <asp:ListItem>3</asp:ListItem>
              <asp:ListItem>4</asp:ListItem>
              <asp:ListItem>5</asp:ListItem>
              <asp:ListItem>6</asp:ListItem>
              <asp:ListItem>7</asp:ListItem>
              <asp:ListItem>8</asp:ListItem>              
          </asp:DropDownList>
        <asp:Label ID="LbPrice" runat="server" Text=""></asp:Label>
    
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" 
                    RepeatColumns="3" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True"></asp:RadioButtonList>
        
        
        <asp:Image ID="Image1" runat="server" />               
        <asp:Button ID="Button7" runat="server" Text="點餐" OnClick="Button7_Click" />
            <br />
            <asp:Label ID="LbStaff" runat="server" ></asp:Label><br />
        <asp:Label ID="LbPeople" runat="server" ></asp:Label>
        </div>
    <div style="float:left">
        <asp:Repeater ID="RtList" runat="server" OnItemDataBound="RtList_ItemDataBound" OnItemCommand="RtList_ItemCommand">
            <HeaderTemplate>
                <p>點餐明細</p>
                <table>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%# Eval("Foods")%><%# Eval("Counts")%>份&nbsp;&nbsp;<%# Eval("Prices")%>元
                        <asp:LinkButton ID="HlbDel" runat="server" Text="刪除" CommandName="Del" onclientclick="return confirm('確定刪除嗎?')"></asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
        </div>
    </form>
</body>
</html>
