<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertDP.aspx.cs" Inherits="HRMS.Resouce.InsertDepartment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style5 {
            width: %;
            height: 118px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <br />
        <table align="center" class="auto-style5">
            <tr>
                <td>部门代号：</td>
                <td>
                    <asp:TextBox ID="did" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>部门名称：</td>
                <td>
                    <asp:TextBox ID="dname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>部门主管：</td>
                <td>
                    <asp:TextBox ID="director" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <div align="center">
                &nbsp;&nbsp;&nbsp;<asp:Button ID="insert" runat="server" Text="确定" OnClick="insert_Click" Width="70px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="cancel" runat="server" Text="取消" OnClick="cancel_Click" Width="70px" />
                       
        </div>
        <br />
        <asp:GridView ID="GridView1" runat="server" align="center" height="100%" width="80%"  AutoGenerateColumns="false">

             <RowStyle   Height="25px"  HorizontalAlign="Center" VerticalAlign="Middle" />
            <Columns>
                
                    <asp:BoundField DataField="did" HeaderText="部门代号" />  
                    <asp:BoundField DataField="dname" HeaderText="部门名称" />
                     <asp:BoundField DataField="director" HeaderText="部门主管" />
                   
                  </Columns>

        </asp:GridView>
    </form>
</body>
</html>
