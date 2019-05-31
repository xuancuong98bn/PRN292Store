using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Exe_Student
{
    class DataProvider
    {
        private static DataProvider instance;

        string connectionString = ConfigurationManager.ConnectionStrings["ManagerPRN292"].ConnectionString;
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        public static DataProvider Instance {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DataProvider()
        {

        }

        public DataTable ExecuteQuery(string sql)
        {
            conn = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Thực hiện insert update delete
        /// lưu ý với trường hợp value truyền vào là text ở sql thì cần dấu ''
        /// </summary>
        /// <param name="sql"></param>
        public void ExecuteNonQuery(string sql)
        {
            conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void insertSujectDA()
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();
            //SqlDataAdapter da = new SqlDataAdapter();
            //da = data.InsertDataAdaper(conn, da, new Subject(10, "Tin học"));
            //da.InsertCommand.ExecuteNonQuery();
            //conn.Close();
        }
    }
}
