using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows;


namespace DAL
{
    public class RegisterDAO
    {
        private SqlConnection dbConnection;

        public RegisterDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public void AddToDataBase(string username, string password)
        {
            try
            {
                dbConnection.Open();

                // Prepare the command to be executed on the db
                using (SqlCommand command = new SqlCommand("INSERT INTO [user] VALUES(@username, @password)", dbConnection))
                {
                    // Create and set the parameters values 
                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

                    // Let's ask the db to execute the query
                    int rowsAdded = command.ExecuteNonQuery();
                    if (rowsAdded > 0)
                        Console.WriteLine("Row inserted");
                    else
                        // Well this should never really happen
                        Console.WriteLine("No row inserted");

                }
            }
            catch (Exception ex)
            {
                // We should log the error somewhere, 
                // for this example let's just show a message
                Console.WriteLine("ERROR:" + ex.Message);
            }
            dbConnection.Close();
        }

        public bool checkExist(string username)
        {
            dbConnection.Open();
            using (SqlCommand command = new SqlCommand("SELECT [Username], [Password] FROM [User] WHERE [Username] = @Username", dbConnection))
            {
                command.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                reader.Close();
                dbConnection.Close();
                return false;
            }
        }
    }
}
