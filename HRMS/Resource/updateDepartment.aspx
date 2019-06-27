<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateDepartment.aspx.cs" Inherits="HRMS.Resouce.updateDepartment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" align="center">
                <asp:Label ID="Label4" runat="server" Text="请输入要修改的部门编号："></asp:Label>
                <asp:TextBox ID="did" runat="server"></asp:TextBox>
                <br />
                <br /> <asp:Label ID="Label5" runat="server" Text="请输入："></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="部门名称："></asp:Label>
                <asp:TextBox ID="dname" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="部门主管："></asp:Label>
                <asp:TextBox ID="director" runat="server"></asp:TextBox>
                <br />      
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确定" />
                <br />
                <br />
                <asp:Panel ID="Panel2" runat="server">
                    <asp:Label ID="Label6" runat="server" Text="修改后的该部门信息为："></asp:Label>
                    <br />
                    <asp:GridView ID="GridView1" runat="server" align="center" height="100%" width="80%">
                        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" Height="25px" />
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
