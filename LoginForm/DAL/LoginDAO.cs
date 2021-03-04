using System;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using Model;

namespace DAL
{
    public class LoginDAO
    {
        private SqlConnection dbConnection;

        public LoginDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public User GetUser()
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("", dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            User user = null;
            return user;
        }
    }
}
