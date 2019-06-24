using HRMS.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS.Resouce
{
    public partial class TestDbConn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var conn = ConnPool.getInstance;
            var res=conn.exeQuery("select * from employee");

            GridView1.DataSource = res.DefaultView;
            GridView1.DataBind();


        }
    }
}