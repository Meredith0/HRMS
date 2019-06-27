using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMS.utils;

namespace HRMS.Resource.userManagement
{
    public partial class updateUSer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
            Session["loginUser"] = "1"; //用于测试
            if (!validator.isLogin() || !validator.updateValid())
            {
                Response.Redirect("../403.aspx");
            }
            init();
        }

        void init()
        {
            var conn = ConnPool.getInstance;
            var res = conn.exeQuery("select * from employee");
            GridView1.DataSource = res.DefaultView;
            GridView1.DataBind();
        }

        protected void commit_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            var conn = ConnPool.getInstance;
            string sql1 =
                string.Format("update employee set ename='{0}',departID='{1}',age='{2}',password='{3}' where eid='{4}';",
                    ename.Text, departID.Text, age.Text, password.Text, eid.Text);
            string sql2 = "delete from Auth where eid='" + eid.Text+"';";
            list.Add(sql1);
            list.Add(sql2);

            string selectAuth = string.Format("INSERT INTO Auth(eid,auth) values('{0}','select');", eid.Text);
            string updateAuth = string.Format("INSERT INTO Auth(eid,auth) values('{0}','update');", eid.Text);
            string deleteAuth = string.Format("INSERT INTO Auth(eid,auth) values('{0}','delete');", eid.Text);
            string insertAuth = string.Format("INSERT INTO Auth(eid,auth) values('{0}','insert');", eid.Text);
            string reportAuth = string.Format("INSERT INTO Auth(eid,auth) values('{0}','report');", eid.Text);
            if (CheckBox1.Checked)
            {
                list.Add(selectAuth);
            }

            if (CheckBox2.Checked)
            {
                list.Add(updateAuth);
            }

            if (CheckBox3.Checked)
            {
                list.Add(deleteAuth);
            }

            if (CheckBox4.Checked)
            {
                list.Add(insertAuth);
            }

            if (CheckBox5.Checked)
            {
                list.Add(reportAuth);
            }

          /*  string str = "";
            foreach (string i in list)
            {
                str += i + "        ";

            }
            Response.Write(str);*/
            var isSuccess = conn.transational(list);
            if (isSuccess)
            {
                resp.Text = "修改成功";
                init();
            }
            else
            {
                resp.Text = "修改失败";
            }
        }
    }
}