using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMS.utils;

namespace HRMS.UnitTest
{
    public partial class LoginValidatorTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["loginUser"] = "张三";
            var conn=ConnPool.getInstance;
            var res = conn.exeQuery(
                "SELECT auth FROM Auth join employee where ename='张三'");
           

            Response.Write(res.Rows[0][0]);

            LoginValidator validator = new LoginValidator();
            Response.Write("select " + validator.selectValid()+"  ");
            Response.Write("update " + validator.updateValid()+"  ");
            Response.Write("insert " + validator.insertValid()+"  ");
            Response.Write("delete " + validator.deleteValid());

        }
    }
}