using HRMS.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS.Resouce
{
    public partial class InsertE : System.Web.UI.Page
    {
        
        private const string ConnString =
            "server=139.196.120.94;userid=root;password=mysql@aliyun;charset=gb2312;database=HRM;pooling=false;";

        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
           // Session["loginUser"] = "1"; 
            if (!validator.isLogin() || !validator.insertValid())
            {
                Response.Redirect("403.aspx");
            }

            if (!Page.IsPostBack)
            {
                ShowData1();
            }
           
           
        }
        void ShowData1()
        {
            var conn = ConnPool.getInstance;
            var res = conn.exeQuery("select eid,ename,dname,age,password,employee.director from employee, Department where employee.departID = Department.did order by  eid ");
            GridView1.DataSource = res.DefaultView;
            GridView1.DataBind();
            string sql = string.Format(" select * from Department");
            var res1 = conn.exeQuery(sql);
            departID.DataSource = res1.DefaultView;
            departID.DataTextField = "dname";
            departID.DataValueField = "did";
            departID.DataBind();

        }

        protected void insert_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = ConnPool.getInstance;
                int dP = int.Parse(this.departID.SelectedItem.Value);
                int a;
                if (DropDownList1.SelectedValue == "true")
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }
                string sqlstr = string.Format("INSERT INTO employee (eid,ename,departID,age,password,director) values('{0}','{1}','{2}','{3}','{4}',{5})", eid.Text, ename.Text, this.departID.SelectedItem.Value, age.Text, password.Text, a);
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
            ename.Text = "";
            eid.Text = "";
            age.Text = "";
            password.Text = "";  
            departID.Text= "";
        }

      
    }
    }
