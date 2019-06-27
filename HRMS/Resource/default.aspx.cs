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
            //判空
            if (eid.Text==null||password.Text==null)
            {
                return;
            }

            var conn=ConnPool.getInstance;
            string sql=string.Format("select * from employee where eid='{0}' and password='{1}'", eid.Text, password.Text);
            var res = conn.exeQuery(sql);
            if (res == null)
            {
                resp.Text = "密码错误";
            }
            else
            {
                Session["loginUser"] = eid.Text;
                Response.Redirect("index.aspx");//跳转到首页
            }
        }
    }
}