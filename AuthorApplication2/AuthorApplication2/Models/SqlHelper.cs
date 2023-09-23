using Microsoft.Data.SqlClient;

namespace AuthorApplication2.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection() // connection factory
        {
            var connString = @"server=200411LTP2786\SQLEXPRESS;database=TestDB;integrated security = true;Encrypt = false";
            SqlConnection SqlConn = new SqlConnection(connString);
            return SqlConn;
            
        }
    }
}
