using System;
using System.Collections.Generic;
using AnimeData;
using AnimeModel;

namespace AnimeUserInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlData sqlData = new SqlData();
            bool active = true;

            while (active)
            {
                Console.WriteLine("MyAniList");
                Console.WriteLine("I hope your family loves you");
                Console.WriteLine("1.Your Favorite anime");
                Console.WriteLine("2.Your Hate anime");
                Console.WriteLine("3.LIST");

                Console.WriteLine("Input Here");
                string number = Console.ReadLine();

                if (number == "1")
                {
                    Console.WriteLine("Anime name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Anime Review:");
                    string anime = Console.ReadLine();

                    Console.WriteLine("Anime Status:");
                    string status = Console.ReadLine();

                    sqlData.AddUser(name, anime, status);

                    Console.WriteLine("Thank you for reviewing");
                }
                else if (number == "2")
                {
                    Console.WriteLine("Input your Name:");
                    string name = Console.ReadLine();

                    sqlData.DeleteUser(name);

                    Console.WriteLine("Thank you again!");
                }
                else if (number == "3")
                {
                    Console.WriteLine("Here's the list");
                    Console.WriteLine("");
                    GetUsers(sqlData);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }

            Console.ReadKey();
        }

        public static void GetUsers(SqlData sqlData)
        {
            List<AnimeAlbum> usersFromDB = sqlData.GetUsers();

            foreach (var item in usersFromDB)
            {
                Console.WriteLine("Name: " + item.name);
                Console.WriteLine("Anime: " + item.anime);
                Console.WriteLine("Status: " + item.status);
                Console.WriteLine("---------------------");
            }
        }
    }
}
