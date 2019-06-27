<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="HRMS.Resouce.WebForm4" %>

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
        .auto-style2 {
            height: 25px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <br />
    <br/>
    <div>
        <br />
        <table class="auto-style1">
            <tr>
                <td>员工代码：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>员工姓名：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>所属部门：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>年&nbsp; 龄：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">登入密码：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Height="22px" Text="查询" Width="98px" />
                </td>
            </tr>
        </table>
        <br />
       <asp:GridView ID="GridView1" runat="server" align="center" height="100%" width="80%" >
                        <RowStyle  Height="25px" HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:GridView>

    </div>
</form>
</body>
</html>