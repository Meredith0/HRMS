using HRMS.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS.Resouce
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
           // Session["loginUser"] = "1"; 
            if (!validator.isLogin() || !validator.selectValid())
            {
                Response.Redirect("403.aspx");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = ConnPool.getInstance;
                var res = conn.exeQuery("select * from Department");
                //单查询，多条件复合查询
                var sqlstr = string.Format(
                    "SELECT did,dname,director from Department where did like '%{0}%' and dname like '%{1}%' and director like '%{2}%'"
                    , TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox3.Text.Trim());
                var res1 = conn.exeQuery(sqlstr);
                GridView1.DataSource = res1.DefaultView;
                GridView1.DataBind();
            }
            catch
            {
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('错误！请重新输入。 ');</script>");

            }

        }
    }
}