using Azure.Identity;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public static class User_logged 
{
    public static string logged_user { get; set; }
}
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
    public int admin_input_user(string fullname, string username, string password, string email, string phone)
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

    public DataTable show_user_logs(string username)

    {

        string query = "select l.log_id, u.username, l.recommendation_text, l.logged_at from user_logs l join registered_customer u on l.id = u.id where u.username = @username";
        using (SqlConnection connection = new SqlConnection(connectionstring))
        {
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    return datatable;

                }
            }
        }
    }

    public DataTable show_user_sensors(string username)
    {
        string query = "select s.sensor_id, u.username, s.temperature, s.humidity, s.recorded_at from sensor_information s join registered_customer u on s.id = u.id where u.username = @username";
        using (SqlConnection connection = new SqlConnection(connectionstring))
        {
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    return datatable;
                }
            }
        }
    }

    public DataTable show_user_recommandation(string username)
    {
        string query = "select u.username, l.recommendation_text, l.logged_at from user_logs l join registered_customer u on l.id = u.id where u.username = @username";
        using (SqlConnection connection = new SqlConnection(connectionstring))
        {
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    return datatable;
                }

            }
        }
    }

    public bool admin_login(string username, string password)
    {
        string query = "select count(*) from admin where username = @username and password = @password";
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

    public DataTable view_user_info()
    {
        string query = "select * from registered_customer";
        using (SqlConnection connection = new SqlConnection(connectionstring))
        {
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adopt = new SqlDataAdapter(cmd))
                {
                    DataTable data_table = new DataTable();
                    adopt.Fill(data_table);
                    return data_table;
                }
            }
        }
    }




    public DataTable search_user(string username)
    {
        string query = "select * from registered_customer where username like @username";
        using (SqlConnection connection = new SqlConnection(connectionstring))
        {
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", "%" + username + "%");
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    //    public DataTable remove_user(string username)
    //    {
    //        string query = "declare @user_id int; select @user_id = id from registered_customer where username = 'tarik'; if @user_id is not null begin delete from user_logs where id = @user_id; delete from user_recommendation where id = @user_id; delete from sensor_information where id = @user_id; delete from registered_customer where id = @user_id; print 'user and related data deleted successfully.'; end else begin print 'user not found.'; end";
    //;

    //        using (SqlConnection connection = new SqlConnection(connectionstring))
    //        {


    //            using (SqlCommand cmd = new SqlCommand(query, connection))
    //            {
    //                cmd.Parameters.AddWithValue("@username", username);
    //                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
    //                {
    //                    DataTable dataTable = new DataTable();
    //                    adapter.Fill(dataTable);
    //                    return dataTable;

    //                }
    //            }
    //        }

    //    }

    public bool remove_user(string username)
    {
        string getidquery = "select id from registered_customer where username = @username";
        string[] deletequeries = {
        "delete from user_logs where id = @id",
        "delete from user_recommendation where id = @id",
        "delete from sensor_information where id = @id",
        "delete from registered_customer where id = @id"
    };

        using (SqlConnection connection = new SqlConnection(connectionstring))
        {
            connection.Open();

            int id = -1;

            using (SqlCommand getidcmd = new SqlCommand(getidquery, connection))
            {
                getidcmd.Parameters.AddWithValue("@username", username);
                object result = getidcmd.ExecuteScalar();
                if (result == null) return false;
                id = Convert.ToInt32(result);
            }

            foreach (string query in deletequeries)
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            return true;
        }
    }



    public DataTable sensor_information(string username)
    {
       
        string query = "select s.sensor_id,u.username, s.temperature,s.humidity,s.recorded_at from sensor_information s join registered_customer u on s.id = u.id where u.username = @username;";

        
        using ( SqlConnection connection = new SqlConnection(connectionstring))
        {
            using(SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (SqlDataAdapter adopter = new SqlDataAdapter(cmd))
                        {
                    DataTable datatable = new DataTable();
                    adopter.Fill(datatable);
                    return datatable;



                }
                   
            }
        }
    }
    public DataTable logs_information(string username)
    {
        string query = " select l.log_id, u.username, l.recommendation_text, l.logged_at from user_logs l join registered_customer u on l.id = u.id where u.username = @username; ";


        using (SqlConnection connection = new SqlConnection(connectionstring))
        {
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("username", username);
                using (SqlDataAdapter adopter = new SqlDataAdapter(cmd))
                {
                    DataTable datatable = new DataTable();
                    adopter.Fill(datatable);
                    return datatable;

                }

            }
        }
    }


}
   