using HRMS.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS.Resouce
{
    public partial class updateDepartment : System.Web.UI.Page
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
            try
            {
                var res = conn.exeQuery(string.Format("select * from Department where did='{0}'", did.Text));
                if (!dname.Text.Equals(""))
                    res = conn.exeQuery(string.Format("update Department set dname='{0}' where did='{1}'", dname.Text, did.Text));
                else if (!director.Text.Equals(""))
                    res = conn.exeQuery(string.Format("update Department set director='{0}'where eid='{1}'", director.Text, did.Text));
                var res2 = conn.exeQuery(string.Format("select * from Department where did='{0}'", did.Text));
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