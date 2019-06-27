using HRMS.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS.Resource
{
    public partial class WebForm5 : System.Web.UI.Page
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
    }
}