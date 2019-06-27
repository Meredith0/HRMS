using HRMS.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS.utils
{
    public class LoginValidator : System.Web.UI.Page
    {
        public bool isLogin()
        {
            if (Page.Session["loginUser"] == null)
            {
                return false;
            }
            return true;
        }

        public bool selectValid()
        {
            var conn = ConnPool.getInstance;
            string sql = "SELECT auth FROM Auth  WHERE auth='select' and eid = '" + Page.Session["loginUser"] + "'";
            DataTable res = conn.exeQuery(sql);

            if (res == null || res.Rows[0][0].ToString() != "select")
            {
                return false;
            }
            return true;
        }

        public bool updateValid()
        {
            var conn = ConnPool.getInstance;
            string sql = "SELECT auth FROM Auth  WHERE auth='update' and eid = '" +
                         Page.Session["loginUser"] + "';";
            var res = conn.exeQuery(sql);

            if (res == null || res.Rows[0][0].ToString() != "update")
            {
                return false;
            }
            return true;
        }

        public bool deleteValid()
        {
            var conn = ConnPool.getInstance;
            string sql = "SELECT auth FROM Auth WHERE auth='delete' and eid = '" +
                         Page.Session["loginUser"] + "';";
            var res = conn.exeQuery(sql);

            if (res == null || res.Rows[0][0].ToString() != "delete")
            {
                return false;
            }
            return true;
        }

        public bool insertValid()
        {
            var conn = ConnPool.getInstance;
            string sql = "SELECT auth FROM Auth WHERE auth='insert' and eid = '" +
                         Page.Session["loginUser"] + "';";
            var res = conn.exeQuery(sql);

            if (res == null || res.Rows[0][0].ToString() != "insert")
            {
                return false;
            }
            return true;
        }

        public bool reportValid()
        {
            var conn = ConnPool.getInstance;
            string sql = "SELECT auth FROM Auth WHERE auth='report' and eid = '" +
                         Page.Session["loginUser"] + "';";
            var res = conn.exeQuery(sql);

            if (res == null || res.Rows[0][0].ToString() != "report")
            {
                return false;
            }
            return true;
        }
    }
}