using HRMS.utils;
using System;


namespace HRMS.Resouce
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var conn = ConnPool.getInstance;
            var res = conn.exeQuery("select * from employee");
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            string url;
            if (TreeView1.SelectedValue=="员工信息")
            {
                url = "WebForm3.aspx";
                this.frmList.Attributes.Add("src ", url);
            }


        }
    }
}