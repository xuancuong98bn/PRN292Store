using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        //Khai bao cac doi tuong trong ket noi CSDL
        SqlConnection cnn; //ket noi CSDL
        SqlDataAdapter da; //Lay du lieu tu CSDL
        SqlCommand cmd; //Thuc hien cau lenh insert, update, delete

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public object MessageBox { get; private set; }

        private DataProvider() { }


        /// <summary>
        /// Ham ket noi CSDL
        /// </summary>
        public void connect()
        {
            try
            {
                String strCnn = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

                cnn = new SqlConnection(strCnn);

                if (cnn.State == ConnectionState.Open)
                    cnn.Close();

                cnn.Open();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        /// <summary>
        /// Thuc hien cau lenh SQL select thong tin
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public DataTable ExcuteQuery(String strSql)
        {
            DataTable dt = new DataTable();
            try
            {
                connect();
                da = new SqlDataAdapter(strSql, cnn);
                da.Fill(dt);

            }
            catch (Exception e)
            {
            }

            return dt;
        }

        /// <summary>
        /// Thuc hien cau lenh SQL insert,update,delete
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public void ExcuteNonQuery(String strSql)
        {
            try
            {
                connect();
                cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                
            }

        }
    }
}