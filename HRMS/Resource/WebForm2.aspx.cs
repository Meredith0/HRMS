using HRMS.utils;
using System;


namespace HRMS.Resouce
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();
            Session["loginUser"] = "张三"; //用于测试
            if (!validator.isLogin())
            {
                Response.Redirect("Resource/default.aspx");
            }
          /*  else
            {
                if (validator.selectValid())
                {
                    TreeView1.Nodes[0].ChildNodes.RemoveAt(0);
                }

                if (validator.insertValid())
                {
                    TreeView1.Nodes[1].ChildNodes.RemoveAt(0);
                }

                if (validator.deleteValid())
                {
                    TreeView1.Nodes[2].ChildNodes.RemoveAt(0);
                }

                if (validator.updateValid())
                {
                    TreeView1.Nodes[3].ChildNodes.RemoveAt(0);
                }
            }*/
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            LoginValidator validator = new LoginValidator();

            string url;
            if (TreeView1.SelectedValue == "员工信息"&&validator.selectValid())
            {
                url = "WebForm3.aspx";
                this.frmList.Attributes.Add("src ", url);
            }
        }
    }
}