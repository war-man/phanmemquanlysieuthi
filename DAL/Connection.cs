﻿using Common;
using DAL;
using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        #region Sanh Tuấn
        static string _strCon;
        static string StrCon
        {
            get
            {
                _strCon = string.IsNullOrEmpty(_strCon) ? BuildConfig() : _strCon;
                return _strCon;
            }
        }
        static string BuildConfig()
        {
            SQL sql = new Common.Utilities().ConnectionsName();
            return "Data Source=" + sql.ServerName + ";User ID = " + sql.UserName + "; password = " + sql.Password + "; Initial Catalog=" + sql.DatabaseName;
           
        }
        public static System.Data.DataTable GetDataBySql(string sql)
        {
            SqlConnection con = new SqlConnection(StrCon); con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, StrCon); System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds); con.Dispose(); con.Close();
            return ds.Tables[0];
        }
        #endregion

        private SqlConnection cnn;
        private string strConnect;
        public string StrConnect
        {
            get { return strConnect; }
            set { strConnect = value; }
        }

        /// <summary>
        /// load file xml
        /// </summary>
        public Connection()
        {
            Entities.SQL sql = new Entities.SQL();
            Common.Utilities com = new Common.Utilities();
            sql = com.ConnectionsName();
            strConnect = "Data Source=" + sql.ServerName + ";User ID=" + sql.UserName + ";password=" + sql.Password + ";Initial Catalog=" + sql.DatabaseName;
        }


        public Connection(string connectionString)
        {
            strConnect = connectionString;
        }

   
        public SqlConnection openConnection()
        {
            cnn = new SqlConnection(strConnect);
            cnn.Open();
            return cnn;
        }


        public void closeConnection()
        {
            cnn.Close();
        }

     
        public int executeSQL(string sql)
        {
            int num = 0;
            cnn = new SqlConnection(strConnect);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            num = cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            cnn.Close();
            return num;
        }
    }
}
