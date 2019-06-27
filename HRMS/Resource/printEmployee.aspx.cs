using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMS.utils;

namespace HRMS.Resource.report
{
    public partial class printEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
           // Session["loginUser"] = "1"; //用于测试
            if (!validator.isLogin())
            {
                Response.Redirect("Resource/default.aspx");
            }
        }

        protected void printEmp_Click(object sender, EventArgs e)
        {
           var conn= ConnPool.getInstance;
           var res = conn.exeQuery("select * from employee where eid='" + ename.Text + "';");
           GridView1.DataSource = res.DefaultView;
           GridView1.DataBind();

        }

        protected void printDept_Click(object sender, EventArgs e)
        {
            var conn = ConnPool.getInstance;
            var res = conn.exeQuery("select * from Department where did='" + dname.Text + "';");
            GridView2.DataSource = res.DefaultView;
            GridView2.DataBind();
        }
    }
}