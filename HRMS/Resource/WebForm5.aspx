<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="HRMS.Resouce.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 2px ;
        }
    </style>
</head>
<body>
<br />
<br />
<form id="form1" runat="server">
    <div>
        <table class="auto-style1">
            <tr>
                <td>部门代号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>部门名称：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>部门主管：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查询" Width="87px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
       <asp:GridView ID="GridView1" runat="server" align="center" height="100%" width="80%" >
                        <RowStyle Height="25px" HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:GridView>

        <br />
    </div>
</form>
</body>
</html>