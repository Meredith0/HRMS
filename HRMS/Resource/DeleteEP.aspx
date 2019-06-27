<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteEP.aspx.cs" Inherits="HRMS.Resouce.Deletemployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form2" runat="server">
        <div>
            <div align="center">

                <br />

            员工代号：<asp:TextBox ID="eid" runat="server" Width="54px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="删除" Width="70px" />
            <br />
            <br />
            &nbsp; 请选择所需要删除项：<asp:Button ID="delete" runat="server"  OnClick="delete_Click" Text="批量删除" Width="70px" />
                &nbsp;</div>
            <br />
            <br />
       <asp:GridView ID="GridView1" runat="server" align="center" height="100%" width="80%" AutoGenerateColumns="false" >
            <RowStyle  Height="25px" HorizontalAlign="Center" VerticalAlign="Middle" />

                <Columns>      
                    <asp:BoundField DataField="eid" HeaderText="员工代号" />  
                    <asp:BoundField DataField="ename" HeaderText="员工姓名" />
                     <asp:BoundField DataField="departID" HeaderText="所属部门" />
                    <asp:BoundField DataField="age" HeaderText="年龄" />
                    <asp:BoundField DataField="password" HeaderText="密码" />
                     <asp:BoundField DataField="director" HeaderText="主管" />
                    <asp:TemplateField HeaderText="选择">  
                        <ItemTemplate>  
                            <asp:CheckBox id="cbxId" runat="Server" />  
                        </ItemTemplate>  
                    </asp:TemplateField>  
                </Columns>  
            </asp:GridView> 
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
            <br />
        </div>
    </form>
</body>
</html>
