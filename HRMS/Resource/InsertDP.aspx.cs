using HRMS.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS.Resouce
{
    public partial class InsertDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
           // Session["loginUser"] = "1"; 
            if (!validator.isLogin() || !validator.insertValid())
            {
                Response.Redirect("403.aspx");
            }
            var conn = ConnPool.getInstance;

            if (!Page.IsPostBack)
            {
                ShowData1();
            }  
        }


        void ShowData1()
        {
            var conn = ConnPool.getInstance;
            var res = conn.exeQuery("select * from Department");
            GridView1.DataSource = res.DefaultView;
            GridView1.DataBind();
        }

     

            protected void insert_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = ConnPool.getInstance;
                string sqlstr = string.Format("insert into Department (did,dname,director) values ('{0}','{1}','{2}')", did.Text, dname.Text, director.Text);
                var res = conn.exeNonQuery(sqlstr);
                ShowData1();
            }
            catch (Exception)
            {
                //若有错误发生，输出错误信息  
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('错误！请重新输入。 ');</script>");

            }

        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            did.Text = "";
            dname.Text = "";
            director.Text = "";
        }
    }
}