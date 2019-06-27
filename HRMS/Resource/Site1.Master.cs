using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMS.utils;

namespace HRMS.Resource
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
            Session["loginUser"] = "1"; //用于测试
            if (!validator.isLogin())
            {
                Response.Redirect("default.aspx");
            }

        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();

            string url;
            if (TreeView1.SelectedValue == "员工信息" && validator.selectValid())
            {
                url = "WebForm3.aspx";
                this.frmList.Attributes.Add("src ", url);
            }
        }
    }
}