<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deleteUser.aspx.cs" Inherits="HRMS.Resource.userManagement.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 382px;
        }
        .auto-style2 {
            width: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div align="center">

            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">用户编号:</td>
                    <td class="auto-style2">
            <asp:TextBox ID="eid" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">

           
            &nbsp;&nbsp;&nbsp;&nbsp;

           
            <asp:Button ID="commit" runat="server" Text="删除" OnClick="commit_Click" />
            <asp:Label ID="resp" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>

            </div>
            <br />
            <br />
           
        </div>
    </form>
</body>
</html>
