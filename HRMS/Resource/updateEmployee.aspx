<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateEmployee.aspx.cs" Inherits="HRMS.Resouce.updateEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Panel ID="Panel1" runat="server" align="center" >
                <asp:Label ID="Label4" runat="server" Text="请输入要修改的员工编号：" Font-Names="Adobe 楷体 Std R"></asp:Label>
                <asp:TextBox ID="eid" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="请输入修改后的信息：" Font-Names="Adobe 楷体 Std R"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="员工姓名：" Font-Names="Adobe 楷体 Std R"></asp:Label>
                <asp:TextBox ID="ename" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="所属部门：" Font-Names="Adobe 楷体 Std R"></asp:Label>
                <asp:TextBox ID="edepartment" runat="server"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="年龄：" Font-Names="Adobe 楷体 Std R"></asp:Label>
                <asp:TextBox ID="eage" runat="server"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Font-Names="Adobe 楷体 Std R" Text="密码："></asp:Label>
                <asp:TextBox ID="epassword" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确定" BorderColor="White" BorderStyle="Outset" Font-Bold="True" Font-Names="Adobe 楷体 Std R" Font-Overline="False" Width="83px" />
                <br />
                <asp:Panel ID="Panel2" runat="server">
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="修改后的该员工信息为：" Font-Names="Adobe 楷体 Std R"></asp:Label>
                    <br />
                    <asp:GridView ID="GridView1" runat="server" align="center" height="100%" width="80%" >
                        <RowStyle Height="25px" HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:GridView>
                </asp:Panel>
                <br />
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
