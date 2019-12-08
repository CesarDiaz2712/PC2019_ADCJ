using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.model.db
{
    class ConnectionUtils
    {
        private static String SERVER = "localhost";
        private static String PORT = "3306";
        private static String DATABASE = "seguimientoegresados";
        private static String USER = "root";
        private static String PASSWORD = "Maroonv271297";

        public static SqlConnection getConnection()
        {
            SqlConnection conn = null;
            try
            {
                String urlconn = String.Format("Data Source={0},{1};" +
                                               "Network Library=DBMSSOCN;" +
                                               "Initial Catalog={2};" +
                                               "User ID={3};" +
                                               "Password={4};",
                                               SERVER, PORT, DATABASE, USER, PASSWORD);
                conn = new SqlConnection(urlconn);
                conn.Open();
                return conn;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return conn;
        }
    }
}
