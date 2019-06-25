using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMS.utils;

namespace HRMS.Resouce
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void login_Click(object sender, EventArgs e)
        {
            var conn=ConnPool.getInstance;
            string sql=string.Format("select count(*) from employee where ename='{0}' and password='{1}'", username.Text, password.Text);
            var res = conn.exeQuery(sql);
            if (res.Rows.Count == 0)
            {
                resp.Text = "密码错误";
            }
            else
            {
                Response.Redirect("Resource/WebForm2.aspx");//跳转到首页
            }
        }
    }
}