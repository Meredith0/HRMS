using HRMS.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS.Resouce
{
    public partial class TestDbConn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* var conn = ConnPool.getInstance;
            //var res=conn.exeQuery("SELECT auth FROM emp_auth INNER JOIN employee WHERE auth='select' and employee.ename = N'张三';");
            DataTable res = conn.exeQuery("SELECT count(*) FROM Auth ");
            GridView1.DataSource = res.DefaultView;
            GridView1.DataBind();*/

            Session["loginUser"] = "张三";
            LoginValidator validator = new LoginValidator();
            Response.Write("select " + validator.selectValid());
            Response.Write("update " + validator.updateValid());
            Response.Write("insert " + validator.insertValid());
            Response.Write("delete " + validator.deleteValid());
        }
    }
}