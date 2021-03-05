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

        public User GetUser(string name)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT [Username], [Password] FROM [User] WHERE [Username] = @Username", dbConnection);
            command.Parameters.AddWithValue("@Username", name); // query to get user and password for specifik user
            SqlDataReader reader = command.ExecuteReader();
            User user = null;

            if (reader.Read())
            {
                user = ReadUser(reader);
            }
            reader.Close();
            dbConnection.Close();
            return user;
        }

        private User ReadUser(SqlDataReader reader)
        {
            // retrieve all data
            string username = (string)reader["Username"];
            string password = (string)reader["Password"];
            User user = new User(username, password);

            // return user
            return user;
        }
    }
}
