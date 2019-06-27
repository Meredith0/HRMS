<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="printEmployee.aspx.cs" Inherits="HRMS.Resource.report.printEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            员工代号:
            <asp:TextBox ID="ename" runat="server"></asp:TextBox><br />

            <asp:GridView ID="GridView1" runat="server" align="center" height="100%" width="80%" >
                        <RowStyle  Height="25px" HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:GridView>

            <asp:Button ID="printEmp" runat="server" Text="打印个别员工" OnClick="printEmp_Click" />
            <hr />
            部门代号:
            <asp:TextBox ID="dname" runat="server"></asp:TextBox><br />
           <asp:GridView ID="GridView2" runat="server" align="center" height="100%" width="80%" >
                        <RowStyle   Height="25px" HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:GridView>


            <asp:Button ID="printDept" runat="server" Text="打印部门员工" OnClick="printDept_Click" />

        </div>
    </form>
</body>
</html>
