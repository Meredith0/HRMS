<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="HRMS.Resouce._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
          .auto-style2 {
            width: 100%;
            height:100%;
        }
        .auto-style3 {
            color: #FFFFFF;
        }
        .auto-style4 {
            color: #000000;
        }
    </style>
</head>
<body >
<style="color: #444; margin:0;font: normal 14px/20px Arial, Helvetica, sans-serif; height:100%; background-color: #fff;"></style>
<div style="height:auto; min-height:100%; ">     
    <div style="text-align: center; width:800px; margin-left: -400px; position:absolute; top: 30%; left:50%;">
        <h2 style="margin-top:20px;font-size: 50px;" >
            <span class="auto-style3">欢迎使用人事信息管理系统</span>
        </h2>
        <form id="form1" runat="server" style="font-size:large">
            <div>
                <span class="auto-style4">员工编号:</span>
                <asp:TextBox ID="eid" runat="server"></asp:TextBox>
                <br />
                <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <span class="auto-style4">密码:</span> 
                <asp:TextBox ID="password" runat="server"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="login" runat="server" Text="登陆" OnClick="login_Click" Width="82px" />
                <asp:Label ID="resp" runat="server" Text="" ></asp:Label>
            </div>
        </form>
    </div>

</div>
    <p>
        <img class="auto-style2" src="../login.png" /></p>

   
</body>
</html>
