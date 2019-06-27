using HRMS.utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS.Resouce
{
    public partial class deleteDepartment : System.Web.UI.Page
    {

        private const string ConnString =
                   "server=139.196.120.94;userid=root;password=mysql@aliyun;charset=gb2312;database=HRM;pooling=false;";

        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
            //Session["loginUser"] = "1"; 
            if (!validator.isLogin() || !validator.deleteValid())
            {
                Response.Redirect("403.aspx");
            }

            if (!IsPostBack)
            {

                dataInit();
            }


        }

        private void dataInit()
        {
            MySqlConnection mySqlConn = new MySqlConnection(ConnString);
            string sqlText = "select * from Department";
            MySqlDataAdapter da = new MySqlDataAdapter(sqlText, mySqlConn);
            DataSet ds = new DataSet();
            mySqlConn.Open();
            da.Fill(ds, "Department");
            GridView1.DataSource = ds;
            GridView1.DataKeyNames = new string[] { "did" };
            GridView1.DataBind();
            mySqlConn.Close();
            mySqlConn.Dispose();
        }

        protected void delete_Click(object sender, EventArgs e)
        {


            //批量删除
            string sqlText = "(";
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cbx = (CheckBox)GridView1.Rows[i].FindControl("cbxId");
                if (cbx.Checked == true)
                {
                    sqlText = sqlText + Convert.ToInt32(GridView1.DataKeys[i].Value) + ",";
                }
            }

            //去掉最后的逗号，并且加上右括号  
            sqlText = sqlText.Substring(0, sqlText.Length - 1) + ")";
            string sql2 = "delete from employee where departID in" + sqlText;
            string sql1 = "delete from Department where did in" + sqlText;
            var list2 = new List<string>();
            list2.Add(sql2);
            list2.Add(sql1);

            try
            {
                //执行删除语句  
                var conn = ConnPool.getInstance;
                bool delCount = conn.transational(list2);
                dataInit();
            }
            catch (Exception ex)
            {
                //若有错误发生，输出错误信息  
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('错误！请重新输入。 ');</script>");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql2 = string.Format("delete from employee where departID ='{0}'",did.Text);
            string sql1 = string.Format("delete from Department where did='{0}'", did.Text);
            var list2 = new List<string>();
            list2.Add(sql2);
            list2.Add(sql1);

            try
            {
                //执行删除语句  
                var conn = ConnPool.getInstance;
                var res = conn.transational(list2);
                dataInit();
            }
            catch (Exception)
            {
                //若有错误发生，输出错误信息  
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('错误！请重新输入。 ');</script>");

            }
        }
    }
}