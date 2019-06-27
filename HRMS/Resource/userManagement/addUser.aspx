<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addUser.aspx.cs" Inherits="HRMS.Resource.userManagement.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center"
>
          <div>
            <style="color: #444; margin:0;font: normal 14px/20px Arial, Helvetica, sans-serif; height:100%; background-color: #fff;"></style>
        <div style="text-align: center; margin-left: -400px; " class="auto-style1">
            <h1 style="margin:0; font-size:50px; line-height:100px; font-weight:bold;"> 添加用户</h1>
        
        <div>
            用户编号:
            <asp:TextBox ID="eid" runat="server"></asp:TextBox><br />
            用户名:
            <asp:TextBox ID="username" runat="server"></asp:TextBox><br />
            密码:
            <asp:TextBox ID="password" runat="server"></asp:TextBox><br />
            部门编号: 
            <asp:TextBox ID="departID" runat="server"></asp:TextBox><br />
            年龄:
            <asp:TextBox ID="age" runat="server"></asp:TextBox><br />
            
            <asp:CheckBox ID="CheckBox0" Text="主管" runat="server" />
            <asp:CheckBox ID="CheckBox1" Text="查询权限" runat="server" />
            <asp:CheckBox ID="CheckBox2" Text="更新权限" runat="server" />
            <asp:CheckBox ID="CheckBox3" Text="删除权限" runat="server" />
            <asp:CheckBox ID="CheckBox4" Text="浏览权限" runat="server" />
            <asp:CheckBox ID="CheckBox5" Text="报表权限" runat="server" /><br />
           
            <asp:Button ID="commit" runat="server" Text="新增用户" OnClick="commit_Click" />

            <asp:Label ID="resp" runat="server" Text=""></asp:Label>

            </div>
            </div>
        </div>
    </form>
</body>
</html>
