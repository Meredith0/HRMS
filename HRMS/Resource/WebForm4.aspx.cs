using HRMS.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS.Resouce
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
            //Session["loginUser"] = "1"; 
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
                var res = conn.exeQuery("select * from employee");
                //单查询，多条件复合查询
                var sqlstr = string.Format(
                    "SELECT eid,ename,departID,age,password from employee where eid like '%{0}%' and ename like '%{1}%' and departID like '%{2}%' and age like '%{3}%' and password like '%{4}%'"
                    , TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox3.Text.Trim(), TextBox4.Text.Trim(), TextBox5.Text.Trim());
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