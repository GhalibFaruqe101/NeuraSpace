using System;
using System.Data;
using Microsoft.Data.SqlClient;
public class database_connection
{
    private string connectionstring = "Server=Desktop-VTPLRO2\\SQLEXPRESS;Database=NeuraSpace;Trusted_Connection=True;TrustServerCertificate=True;";

    public int register_user(string fullname, string username, string password, string email, string phone)
    {
        using (SqlConnection connection = new SqlConnection(connectionstring))
        {
            string query = "insert into registered_customer (fullname, username, password, email, phone) values (@fullname, @username, @password, @email, @phone)";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@fullname", fullname);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                connection.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }

    public bool validation(string username, string password)
    {
        string query = "select count(*) from registered_customer where username = @username and password = @password";
        using (SqlConnection connection = new SqlConnection(connectionstring))
        {
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                connection.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
   