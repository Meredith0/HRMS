using HRMS.utils;
using System;


namespace HRMS.Resouce
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
           // Session["loginUser"] = "1"; 
            if (!validator.isLogin() )
            {
                Response.Redirect("default.aspx");
            }
            var conn = ConnPool.getInstance;
            var res = conn.exeQuery("select * from employee");


            var res1=conn.exeQuery("select ename from employee where eid=" + Session["loginUser"]);
            Label2.Text ="欢迎你!"+ res1.Rows[0][0].ToString();




        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
           
            string url;
            if (TreeView1.SelectedValue== "各部门员工信息")
            {
                url = "Reademployee.aspx";
                this.frmList.Attributes.Add("src ", url);
            }
            if (TreeView1.SelectedValue == "主管信息" )
            {
                url = "Readdirector.aspx";
                this.frmList.Attributes.Add("src ", url);
            }
            if (TreeView1.SelectedValue == "修改员工信息")
            {
                url = "updateEmployee.aspx";
                this.frmList.Attributes.Add("src ", url);
            }
            if (TreeView1.SelectedValue == "修改部门信息" )
            {
                url = "updateDepartment.aspx";
                this.frmList.Attributes.Add("src ", url);
            }
            if (TreeView1.SelectedValue == "InputEM" )
            {
                url = "InsertEP.aspx";
                this.frmList.Attributes.Add("src ", url);
            }

            if (TreeView1.SelectedValue == "InputDP")
            {
                url = "InsertDP.aspx";
                this.frmList.Attributes.Add("src ", url);
            }

            if (TreeView1.SelectedValue == "deleteEM")
            {
                url = "DeleteEP.aspx";
                this.frmList.Attributes.Add("src ", url);
            }

            if (TreeView1.SelectedValue == "deleteDP")
            {
                url = "DeleteDP.aspx";
                this.frmList.Attributes.Add("src ", url);
            }

            //
            

            if (TreeView1.SelectedValue == "selectEP")
            {
                url = "WebForm4.aspx";
                this.frmList.Attributes.Add("src ", url);
            }

            if (TreeView1.SelectedValue == "selectDP")
            {
                url = "WebForm5.aspx";
                this.frmList.Attributes.Add("src ", url);
            }

            if (TreeView1.SelectedValue == "打印员工信息")
            {
                url = "printEmployee.aspx";
                this.frmList.Attributes.Add("src ", url);
            }

            if (TreeView1.SelectedValue == "系统帮助及使用说明")
            {
                url = "help.aspx";
                this.frmList.Attributes.Add("src ", url);
            }
            //

            if (TreeView1.SelectedValue == "adduser")
            {
                url = "userManagement/addUser.aspx";
                this.frmList.Attributes.Add("src ", url);
            }

            if (TreeView1.SelectedValue == "deleteuser")
            {
                url = "userManagement/deleteUser.aspx";
                this.frmList.Attributes.Add("src ", url);
            }

            if (TreeView1.SelectedValue == "update")
            {
                url = "userManagement/updateUser.aspx";
                this.frmList.Attributes.Add("src ", url);
            }
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("default.aspx");
        }
    }
}