using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMS.utils;

namespace HRMS.Resource.userManagement
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
            Session["loginUser"] = "1"; //用于测试
            if (!validator.isLogin())
            {
                Response.Redirect("Resource/default.aspx");
            }
        }

        protected void commit_Click(object sender, EventArgs e)
        {
            var conn = ConnPool.getInstance;
            string sql = string.Format("delete from employee where eid={0}", eid.Text);
            var effectLine = conn.exeNonQuery(sql);
            if (effectLine == 1)
            {
                resp.Text = "删除成功";

            }
            else
            {
                resp.Text = "删除失败";
            }
        }
    }
}