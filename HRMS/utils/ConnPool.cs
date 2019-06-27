using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HRMS.utils
{
    public class ConnPool : System.Web.UI.Page
    {
        private const string ConnString =
            "server=139.196.120.94;userid=root;password=mysql@aliyun;charset=gb2312;database=HRM;pooling=true;MinPoolSize=5;MaxPoolSize=10";

        private MySqlConnection mySqlConn = null;
        private static volatile ConnPool instance = null;
        private static object lockHelper = new object();

        private ConnPool()
        {
            mySqlConn = new MySqlConnection(ConnString);
        }

        //单例
        public static ConnPool getInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new ConnPool();
                        }
                    }
                }
                return instance;
            }
        }
   
        public DataTable exeQuery(string StrSql) //执行查询
        {
            //当连接处于打开状态时关闭,然后再打开,避免有时候数据不能及时更新
            if (mySqlConn.State == ConnectionState.Open)
            {
                mySqlConn.Close();
            }

            try
            {
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(StrSql, mySqlConn);
                MySqlDataReader SqlDr = cmd.ExecuteReader();
                if (SqlDr.HasRows)
                {
                    DataTable dt = new DataTable();
                    //读取SqlDataReader里的内容
                    dt.Load(SqlDr);
                    //关闭对象和连接
                    SqlDr.Close();
                    mySqlConn.Close();
                    return dt;
                }

                return null;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                mySqlConn.Close();
            }
        }

        public int exeNonQuery(string StrSql) //执行非查询
        {
            //当连接处于打开状态时关闭,然后再打开,避免有时候数据不能及时更新
            if (mySqlConn.State == ConnectionState.Open)
            {
                mySqlConn.Close();
            }

            try
            {
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(StrSql, mySqlConn);
                int effectLine = cmd.ExecuteNonQuery();

                return effectLine;
            }
            catch (Exception ex)
            {
               // System.Console.WriteLine(ex.Message);
                Response.Write(ex.Message);
                return 0;
            }
            finally
            {
                mySqlConn.Close();
            }
        }

        public bool transational(List<string> sql) //事务
        {
            if (mySqlConn.State == ConnectionState.Open)
            {
                mySqlConn.Close();
            }

            mySqlConn.Open();
            MySqlTransaction transaction = mySqlConn.BeginTransaction();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mySqlConn;
            cmd.Transaction = transaction;

            try
            {
                for (int n = 0; n < sql.Count; n++)
                {
                    string strsql = sql[n];
                    if (strsql.Trim().Length > 1)
                    {
                        cmd.CommandText = strsql;
                        cmd.ExecuteNonQuery();
                    }
                }
                cmd.ExecuteNonQuery();
                transaction.Commit();
                mySqlConn.Close();
                return true;
            }
            catch
            {
                transaction.Rollback();
                mySqlConn.Close();
                return false;
            }
        }
    }
}