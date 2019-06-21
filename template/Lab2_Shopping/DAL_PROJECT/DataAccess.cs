using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL_PROJECT
{
    public static class DataAccess
    {
        public static string connectionString;
        public static string dbName = "PRN292_SHOPPING";
        static SqlConnection conn;
        //static SqlDataAdapter da;
        static SqlCommand cmd;
        //public string connectionStringRaw = @"Data Source = DESKTOP - UDI1P6F\SQLEXPRESS;Initial Catalog = ManagerPRN292; user id = sa; password=123456";

        static DataAccess()
        {
            connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
            conn = new SqlConnection(connectionString);

        }

        public static SqlConnection GetConnection()
        {
            return conn;
        }

        //-------------- SELECT COMMAND ---------------
        public static DataTable SelectTable(string table)
        {
            string sql = @"SELECT * FROM " + table;
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ExecuteQuery(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //-------------- FUCTION COMMAND ---------------
        /*
         * @"INSERT INTO tblSubject VALUES (@id, @name)";
         * @"UPDATE Customers SET CustomerID = @CustomerID, CompanyName = @CompanyName WHERE CustomerID = @oldCustomerID"
         * @"DELETE FROM Customers WHERE CustomerID = @CustomerID";
         * cmd.Parameters.AddWithValue("@id", id);
        */

        public static bool ExecuteNonQuery(string sql)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                // Close database connection
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return true;
        }

        /// <summary>
        /// Using for Count, Sum,... return 1 value at the first column of first row
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalarQuery(string sql)
        {
            object result = null;
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                conn.Open();
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Close database connection
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }

        //----------- Get Data using DataReader ------------
        

        //-------------------- OTHER -----------------------
        public static bool IsDupplicate(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows.Count != 0;
        }
    }
}
