<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="HRMS.Resouce._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名:
            <asp:TextBox ID="username" runat="server"></asp:TextBox><br />
            
            密码: 
            <asp:TextBox ID="password" runat="server"></asp:TextBox><br />
            <asp:Button ID="login" runat="server" Text="登陆" OnClick="login_Click" />
            <asp:Label ID="resp" runat="server" Text="Label" ></asp:Label>
        </div>
    </form>
</body>
</html>
