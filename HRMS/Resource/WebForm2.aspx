<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="HRMS.Resouce.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 352px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <asp:TreeView ID="TreeView1" runat="server" ShowLines="True" align="left" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" >
                <Nodes>
                    <asp:TreeNode Text="信息查询" Value="信息查询" >
                        <asp:TreeNode Text="员工信息" Value="员工信息"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="信息录入 " Value="信息录入 ">
                        <asp:TreeNode Text="员工信息 " Value="员工信息 "></asp:TreeNode>
                        <asp:TreeNode Text="部门信息 " Value="部门信息 "></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="信息删除 " Value="信息删除 ">
                        <asp:TreeNode Text="员工信息 " Value="员工信息 "></asp:TreeNode>
                        <asp:TreeNode Text="部门信息 " Value="部门信息 "></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="信息修改" Value="信息修改">
                        <asp:TreeNode Text="员工信息 " Value="员工信息 "></asp:TreeNode>
                        <asp:TreeNode Text="部门信息 " Value="部门信息 "></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="信息浏览" Value="信息浏览">
                        <asp:TreeNode Text="员工信息 " Value="员工信息 "></asp:TreeNode>
                        <asp:TreeNode Text="部门信息 " Value="部门信息 "></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="数据报表" Value="数据报表">
                        <asp:TreeNode Text="员工信息 " Value="员工信息 "></asp:TreeNode>
                        <asp:TreeNode Text="部门信息 " Value="部门信息 "></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="系统帮助及使用说明" Value="系统帮助及使用说明"></asp:TreeNode>
                </Nodes>
            </asp:TreeView>
            <iframe id="frmList" runat="server" border="0"  frameborder="0" align="right" name="I1" scrolling="auto" width="80%" class="auto-style1"></iframe>
        </div>
    </form>
</body>
</html>
