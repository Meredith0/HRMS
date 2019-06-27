using HRMS.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS.Resouce
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
            //Session["loginUser"] = "1"; 
            if (!validator.isLogin() || !validator.selectValid())
            {
                Response.Redirect("403.aspx");
            }

            try
            {
                var conn = ConnPool.getInstance;
                var res = conn.exeQuery("select did as 'Department ID ',dname as 'Department Name' ,employee.eid as 'Employee ID',employee.ename as 'Employee Name',employee.age as 'Employee Age' from Department left join employee on Department.did=employee.departID ");
                GridView1.DataSource = res.DefaultView;
                GridView1.DataBind();
            }
            catch
            {
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('数据库链接错误！ ');</script>");
            }
        }

    }
}