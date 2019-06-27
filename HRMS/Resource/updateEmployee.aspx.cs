using HRMS.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS.Resouce
{
    public partial class updateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
           // Session["loginUser"] = "1"; 
            if (!validator.isLogin() || !validator.updateValid())
            {
                Response.Redirect("403.aspx");
            }

            Panel2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var conn = ConnPool.getInstance;
            Panel2.Visible = true;
            try {          
            var res = conn.exeQuery(string.Format("select eid, ename,departID,age from employee where eid='{0}'", eid.Text));
            if (!ename.Text.Equals(""))
                res = conn.exeQuery(string.Format("update employee set ename='{0}' where eid='{1}'", ename.Text, eid.Text));
            if (!edepartment.Text.Equals(""))
                res = conn.exeQuery(string.Format("update employee set edepartment='{0}'where eid='{1}'", edepartment.Text, eid.Text));
            if (!eage.Text.Equals(""))
                res = conn.exeQuery(string.Format("update employee set age='{0}'where eid='{1}'", eage.Text, eid.Text));
            if (!epassword.Text.Equals(""))
                res = conn.exeQuery(string.Format("update employee set password='{0}'where eid='{1}'", epassword.Text, eid.Text));       
             var res2 = conn.exeQuery(string.Format("select eid,ename,departID,age,password from employee where eid='{0}'", eid.Text));           
            GridView1.DataSource = res2.DefaultView;
            GridView1.DataBind();
            }
            catch
            {
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('错误！请重新输入。 ');</script>");
            }
        }

        
    }
}