using System.Collections.Generic;
using System.Data.SqlClient;
using AnimeModel;

namespace AnimeData
{
    public class SqlData
    {
        static string connectionString = "Server = tcp:20.2.250.60,1433; Database = aniList; User Id = sa; Password = bsit2!";
        SqlConnection sqlConnection;

        public SqlData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void Connect()
        {
            sqlConnection.Open();
        }

        public List<AnimeAlbum> GetUsers()
        {
            string selectStatement = "SELECT name, anime FROM users";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            List<AnimeAlbum> users = new List<AnimeAlbum>();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                string anime = reader["anime"].ToString();
                string status = reader["status"].ToString();

                AnimeAlbum readUser = new AnimeAlbum();
                readUser.name = name;
                readUser.anime = anime;
                readUser.status = status;

                users.Add(readUser);
            }

            reader.Close();
            sqlConnection.Close();

            return users;
        }

        public int AddUser(string name, string anime, string status)
        {
            int success;

            string insertStatement = "INSERT INTO users VALUES (@name,@anime,@status)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@name", name);
            insertCommand.Parameters.AddWithValue("@anime", anime);
            insertCommand.Parameters.AddWithValue("@status", status);
            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int UpdateUser(string name, string anime)
        {
            int success;
            string updateStatement = "UPDATE users SET anime = @anime WHERE name = @name";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@name", name);
            updateCommand.Parameters.AddWithValue("@anime", anime);
            
           success = updateCommand.ExecuteNonQuery(); 

            sqlConnection.Close();
            return success;
        }

        public int DeleteUser(string name)
        {
            int success;
            string deleteStatement = "DELETE FROM users WHERE name = @name";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            sqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@name", name);

            success = deleteCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }
    }
}
