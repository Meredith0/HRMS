<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HRMS.Resouce.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style6 {
            width: 100%;
            height: 100%;
        }
      
        .auto-style5 {
            width: 100%;
        }
      
        .auto-style4 {
            font-size: xx-large;
            color: #000000;
        }
      .auto-style6{
            height: 100%;
            width: 100%;
        }
        .auto-style2 {
            height: 100%;
            width: 100%;
        }
        .auto-style3 {
             height: 100%;
             width: 169px;
        }
        .auto-style1 {
            height: 100%;
            margin-top: 0px;
        }
              
        </style>
</head>
<body>
    <form id="form1" runat="server" >
        <asp:Panel ID="Panel1" runat="server"   BackImageUrl="~/1.jpg" >
            <div style=" text-align:center;" class="auto-style5">
                <table class="auto-style5">
                    <tr>
                        <td>
                            <br />
                            <asp:Label ID="Label1" runat="server"  Text="人事管理系统" Font-Bold="False" Font-Size="XX-Large" CssClass="auto-style4" Font-Names="Adobe 繁黑體 Std B" ForeColor="black"  ></asp:Label>
                            <br />
                            <hr></td>
                    </tr>
                </table>
                <br />
                <div style="float:right">
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    <asp:Button ID="cancel" runat="server" Text="注销" OnClick="cancel_Click" />
                </div>
                <br />
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style3">
                            <asp:TreeView ID="TreeView1" runat="server" align="left" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" ImageSet="News" NodeIndent="10" Height="100%" Font-Size="X-Large" ForeColor="White">
                                <HoverNodeStyle Font-Underline="True" BorderStyle="None" />
                                <LeafNodeStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" />
                                <Nodes>
                                    <asp:TreeNode Text="信息查询" Value="信息查询">
                                        <asp:TreeNode Text="员工信息" Value="selectEP"></asp:TreeNode>
                                        <asp:TreeNode Text="部门信息" Value="selectDP"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="信息录入 " Value="信息录入 ">
                                        <asp:TreeNode Text="员工信息 " Value="InputEM"></asp:TreeNode>
                                        <asp:TreeNode Text="部门信息 " Value="InputDP"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="信息修改" Value="信息删除">
                                        <asp:TreeNode Text="员工信息 " Value="修改员工信息"></asp:TreeNode>
                                        <asp:TreeNode Text="部门信息 " Value="修改部门信息"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="信息删除" Value="信息删除">
                                        <asp:TreeNode Text="员工信息 " Value="deleteEM"></asp:TreeNode>
                                        <asp:TreeNode Text="部门信息 " Value="deleteDP"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="信息浏览" Value="信息浏览">
                                        <asp:TreeNode Text="主管信息 " Value="主管信息"></asp:TreeNode>
                                        <asp:TreeNode Text="各部门员工信息 " Value="各部门员工信息"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="打印数据" Value="打印数据">
                                        <asp:TreeNode Text="员工信息 " Value="打印员工信息"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="用户管理" Value="user">
                                        <asp:TreeNode Text="添加用户" Value="adduser"></asp:TreeNode>
                                        <asp:TreeNode Text="删除用户" Value="deleteuser"></asp:TreeNode>
                                        <asp:TreeNode Text="修改用户信息" Value="update"></asp:TreeNode>
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="系统帮助及使用说明" Value="系统帮助及使用说明"></asp:TreeNode>
                                </Nodes>
                                <NodeStyle Font-Names="Arial" Font-Size="10pt" ForeColor="black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                                <ParentNodeStyle Font-Bold="False" BackColor="Silver" ForeColor="Silver" />
                                
                                <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" />
                            </asp:TreeView>
                        </td>
                        <td>
                            <iframe id="frmList" runat="server"  name="I1" scrolling="auto" width="100%" class="auto-style1" ><a>
                           
                            </a></iframe>
                            <br />
                        </td>
                    </tr>
                </table>
            </div>
        </asp:Panel>
    </form>
     
</body>
</html>
