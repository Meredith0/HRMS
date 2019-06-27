<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteDP.aspx.cs" Inherits="HRMS.Resouce.deleteDepartment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <div align="center">

                <br />

            部门代号：<asp:TextBox ID="did" runat="server" Width="54px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="删除" Width="70px" />
            <br />
            <br />
                请选择所需要删除项：<asp:Button ID="delete" runat="server" OnClick="delete_Click" Text="批量删除" Width="70px" />

            </div>
            <br />
            <br />
        <asp:GridView ID="GridView1" runat="server" align="center" height="100%" width="80%" AutoGenerateColumns="false" >
            <RowStyle  Height="25px" HorizontalAlign="Center" VerticalAlign="Middle" />
 <Columns>      
                    <asp:BoundField DataField="did" HeaderText="部门代号" />  
                    <asp:BoundField DataField="dname" HeaderText="部门名称" />
                     <asp:BoundField DataField="director" HeaderText="部门主管" />
                   
                    <asp:TemplateField HeaderText="选择">  
                        <ItemTemplate>  
                            <asp:CheckBox id="cbxId" runat="Server" />  
                        </ItemTemplate>  
                    </asp:TemplateField>  
                </Columns>  
            </asp:GridView> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
        </div>
    </form>
</body>
</html>
