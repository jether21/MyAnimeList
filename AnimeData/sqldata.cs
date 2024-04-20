using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AnimeModel;

namespace AnimeData
{
    internal class SqlData
    {
        private static string connectionString = "Data Source=JETHER\\SQLEXPRESS;Initial Catalog=JethersAniLib;Integrated Security=True;";
        private static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public static void Connect()
        {
            sqlConnection.Open();
        }

        public static List<User> GetUsers()
        {
            string selectStatement = "SELECT name, anime FROM users";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            List<User> users = new List<User>();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                string anime = reader["anime"].ToString();

                User readUser = new User();
                readUser.name = name;
                readUser.anime = anime;

                users.Add(readUser);
            }

            reader.Close();
            sqlConnection.Close();

            return users;
        }

        public static int AddUser(string name, string anime)
        {
            int success;

            string insertStatement = "INSERT INTO users (name, anime) VALUES (@name, @anime)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@name", name);
            insertCommand.Parameters.AddWithValue("@anime", anime);
            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public static void UpdateUser(string name, string anime)
        {
            var updateStatement = "UPDATE users SET anime = @anime WHERE name = @name";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@name", name);
            updateCommand.Parameters.AddWithValue("@anime", anime);

            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public static void DeleteUser(string name)
        {
            string deleteStatement = "DELETE FROM users WHERE name = @name";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            sqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@name", name);

            deleteCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
