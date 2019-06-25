﻿using HRMS.utils;
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
            // Page.Session["loginUser"]
            var conn = ConnPool.getInstance;
            string sql = "SELECT count(*) FROM Auth JOIN employee WHERE auth='select' and employee.ename = '"+ Page.Session["loginUser"]+"'";
            DataTable res = conn.exeQuery(sql);
           
            if(res == null || res.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        public bool updateValid()
        {
            var conn = ConnPool.getInstance;
            string sql = "SELECT count(*) FROM Auth INNER JOIN employee WHERE auth='update' and employee.ename = '" +
                         Page.Session["loginUser"] + "';";
            var res = conn.exeQuery(sql);

            if (res == null || res.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        public bool deleteValid()
        {
            var conn = ConnPool.getInstance;
            string sql = "SELECT count(*) FROM Auth INNER JOIN employee WHERE auth='delete' and employee.ename = '" +
                         Page.Session["loginUser"] + "';";
            var res = conn.exeQuery(sql);

            if (res == null || res.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        public bool insertValid()
        {
            var conn = ConnPool.getInstance;
            string sql = "SELECT count(*) FROM Auth INNER JOIN employee WHERE auth='insert' and employee.ename = '" +
                         Page.Session["loginUser"] + "';";
            var res = conn.exeQuery(sql);

            if (res == null || res.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}