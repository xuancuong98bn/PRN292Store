using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Exe_Student
{
    class DataAccess
    {
        public string connectionString;
        //public string connectionStringRaw = @"Data Source = DESKTOP - UDI1P6F\SQLEXPRESS;Initial Catalog = ManagerPRN292; user id = sa; password=123456";

        public DataAccess(string nameDB)
        {
            connectionString = ConfigurationManager.ConnectionStrings[nameDB].ConnectionString;
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        //-------------- DATA ADAPTER ---------------
        public DataTable SelectTable(string table)
        {
            string sql = @"SELECT * FROM " + table;
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SelectByDA(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public SqlDataAdapter InsertDataAdaper(SqlConnection conn, SqlDataAdapter da, Subject subject)
        {
            string sql = @"INSERT INTO tblSubject VALUES (@id, @name)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", subject.id);
            cmd.Parameters.AddWithValue("@name", subject.name);
            da.InsertCommand = cmd;
            return da;
        }

        public SqlDataAdapter UpdateDataAdaper(SqlConnection connection, SqlDataAdapter dataAdapter)
        {
            string sql = @"UPDATE Customers SET CustomerID = @CustomerID, CompanyName = @CompanyName WHERE CustomerID = @oldCustomerID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@CustomerID", SqlDbType.NChar, 5, "CustomerID");
            command.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40, "CompanyName");
            SqlParameter parameter = command.Parameters.Add("@oldCustomerID", SqlDbType.NChar, 5, "CustomerID");

            parameter.SourceVersion = DataRowVersion.Original;
            dataAdapter.UpdateCommand = command;
            return dataAdapter;
        }

        public SqlDataAdapter DeleteDataAdaper(SqlConnection connection, SqlDataAdapter dataAdapter)
        {
            string sql = @"DELETE FROM Customers WHERE CustomerID = @CustomerID";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlParameter parameter = command.Parameters.Add("@CustomerID", SqlDbType.NChar, 5, "CustomerID");

            parameter.SourceVersion = DataRowVersion.Original;
            dataAdapter.InsertCommand = command;
            return dataAdapter;
        }

        //--------------------------------------------
        public List<Subject> SelectList()
        {
            SqlDataReader dr = null;
            SqlConnection conn = null;
            SqlCommand cmd = null;
            List<Subject> list = new List<Subject>();

            try
            {
                string sql = @"SELECT * FROM tblSubject";
                conn = new SqlConnection(connectionString);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id"]);
                    string name = dr["name"].ToString();
                    list.Add(new Subject(id, name));
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Close data reader object and database connection
                if (dr != null)
                    dr.Close();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return list;
        }

        public bool InsertData(Subject subject)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                string sql = @"INSERT INTO tblSubject VALUES (@id, @name)";
                conn = new SqlConnection(connectionString);
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", subject.id);
                cmd.Parameters.AddWithValue("@name", subject.name);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                // Close data reader object and database connection
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return true;
        }

        public bool UpdateData(Subject subject)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                string sql = @"UPDATE tblSubject SET name = @name WHERE id = @id";
                conn = new SqlConnection(connectionString);
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", subject.id);
                cmd.Parameters.AddWithValue("@name", subject.name);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                // Close data reader object and database connection
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return true;
        }

        public bool DeleteData(int id)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                string sql = @"DELETE FROM tblSubject WHERE id = @id";
                conn = new SqlConnection(connectionString);
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                // Close data reader object and database connection
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return true;
        }
    }
}
