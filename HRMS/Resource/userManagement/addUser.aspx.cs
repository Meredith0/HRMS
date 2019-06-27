using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMS.utils;

namespace HRMS.Resource.userManagement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
            //Session["loginUser"] = "1"; //用于测试
            if (!validator.isLogin())
            {
                Response.Redirect("Resource/default.aspx");
            }
        }

        protected void commit_Click(object sender, EventArgs e)
        {
            if (username.Text == null || departID.Text == null || age.Text == null || password.Text == null)
            {
                return;
            }

            var conn = ConnPool.getInstance;
            List<string> list = new List<string>();
            string sql1 =
                string.Format(
                    "INSERT INTO employee(eid,ename, departID, age, password,director)  VALUES ('{0}','{1}','{2}','{3}','{4}')",
                    eid.Text, username.Text, departID.Text, age.Text, password.Text,CheckBox0.Checked);

            list.Add(sql1);
            string selectAuth = string.Format("INSERT INTO Auth(eid,auth) values('{0}','select')", eid.Text);
            string updateAuth = string.Format("INSERT INTO Auth(eid,auth) values('{0}','update')", eid.Text);
            string deleteAuth = string.Format("INSERT INTO Auth(eid,auth) values('{0}','delete')", eid.Text);
            string browserAuth = string.Format("INSERT INTO Auth(eid,auth) values('{0}','browser')", eid.Text);
            string reportAuth = string.Format("INSERT INTO Auth(eid,auth) values('{0}','report')", eid.Text);

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
                list.Add(browserAuth);
            }

            if (CheckBox5.Checked)
            {
                list.Add(reportAuth);
            }

            var isSuccess=conn.transational(list);
            if (isSuccess)
            {
                resp.Text = "插入成功";
            }
            else
            {
                resp.Text = "插入失败";
            }
        }
    }
}