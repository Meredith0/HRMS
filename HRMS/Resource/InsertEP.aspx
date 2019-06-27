<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertEP.aspx.cs" Inherits="HRMS.Resouce.InsertE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
           
            width: %;
            height: 118px;
        }
        
        .auto-style5 {
            width: 147px;
            height: 28px;
        }
        .auto-style3 {
            width: 147px;
            height: 23px;
        }
        .auto-style8 {
            width: 147px;
        }
        </style>
</head>
<body>
    <form id="form1"  runat="server">
        <div>
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style8">员工代号：</td>
                <td class="auto-style8">
                    <asp:TextBox ID="eid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">员工姓名：</td>
                <td class="auto-style5">
                    <asp:TextBox ID="ename" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">所属部门：</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="departID" runat="server" >
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">年龄：</td>
                <td class="auto-style8">
                    <asp:TextBox ID="age" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">密码：</td>
                <td class="auto-style8">
                    <asp:TextBox ID="password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">主管：</td>
                <td class="auto-style8">
                    &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="16px">
                        <asp:ListItem Value="true">是</asp:ListItem>
                        <asp:ListItem Value="false">否</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            </table>
            <br />
            <div align="center">
                     
                &nbsp;<asp:Button ID="insert" runat="server" Text="确定" OnClick="insert_Click" Width="70px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="cancel" runat="server" Text="清空" OnClick="cancel_Click" Width="70px" />
            </div>
             <br />
             <asp:GridView ID="GridView1" runat="server" align="center" height="100%" width="80%"  AutoGenerateColumns="false">
                        <RowStyle   Height="25px" HorizontalAlign="Center" VerticalAlign="Middle" />
             <Columns>
                
                    <asp:BoundField DataField="eid" HeaderText="员工代号" />  
                    <asp:BoundField DataField="ename" HeaderText="员工姓名" />
                     <asp:BoundField DataField="dname" HeaderText="所属部门" />
                    <asp:BoundField DataField="age" HeaderText="年龄" />
                    <asp:BoundField DataField="password" HeaderText="密码" />
                     <asp:BoundField DataField="director" HeaderText="主管" />
                  </Columns>  
             </asp:GridView>

        </div>
    </form>
</body>
</html>
