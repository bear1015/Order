<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="~/usercontrol/Ddlcounts.ascx" TagPrefix="uc1" TagName="Ddlcounts" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   <style>
        html {
            height: 100%;
        }

        body {
            background-image: url(../images/2.jpg);
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-position: center;
            background-size: cover;
        }
    </style>
</head>
<body >
    <form id="form1" runat="server">
    <div>
          桌號:<asp:DropDownList ID="DdlTable" runat="server" Width="150px">
                    <asp:ListItem>一號桌</asp:ListItem>
                    <asp:ListItem>二號桌</asp:ListItem>
                    <asp:ListItem>三號桌</asp:ListItem>
                    <asp:ListItem>四號桌</asp:ListItem>
                    <asp:ListItem>五號桌</asp:ListItem>
                    <asp:ListItem>六號桌</asp:ListItem>
                </asp:DropDownList>
        人數:<asp:DropDownList ID="DdlPeople" runat="server" Width="100px">
              <asp:ListItem>1</asp:ListItem>
              <asp:ListItem>2</asp:ListItem>
              <asp:ListItem>3</asp:ListItem>
              <asp:ListItem>4</asp:ListItem>
              <asp:ListItem>5</asp:ListItem>
              <asp:ListItem>6</asp:ListItem>
              <asp:ListItem>7</asp:ListItem>
              <asp:ListItem>8</asp:ListItem>              
          </asp:DropDownList>
        人員:<asp:DropDownList ID="DdlStaff" runat="server" Width="150px">
              <asp:ListItem>工作人員A</asp:ListItem>
              <asp:ListItem>工作人員B</asp:ListItem>
          </asp:DropDownList>
        <table>
            <tr>
                <td>電話</td><td class="auto-style1">04-23550981</td>
            </tr>
               <tr>
                <td>地址</td><td class="auto-style1">台中市工業一路46號</td>
            </tr>
               <tr>
                <td>公休日</td><td class="auto-style1">每週日公休</td>
            </tr>
               <tr>
                <td>營業時間</td><td class="auto-style1">11:00~14:00，17:00~22:00</td>
            </tr>
        </table>
        <asp:Button ID="BtOrder" runat="server" Text="點餐" OnClick="BtOrder_Click"  />
        <asp:Button ID="BtCheck" runat="server" Text="結帳" OnClick="BtCheck_Click" />
        <asp:Button ID="BtDetail" runat="server" Text="明細" OnClick="BtDetail_Click" />
    </div>
    </form>
</body>
</html>
