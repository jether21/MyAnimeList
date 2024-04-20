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
                    Console.WriteLine("Anime name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Anime Review");
                    string anime = Console.ReadLine();
                    SqlData.AddUser(name, anime);

                    Console.WriteLine("Thank you for reviewing");
                }
                else if (number == "2")
                {
                    Console.WriteLine("Input your Name");
                    string name = Console.ReadLine();
                    SqlData.DeleteUser(name);

                    Console.WriteLine("Thank you again!");
                }
                else if (number == "3")
                {
                    Console.WriteLine("Here's the list");
                    Console.WriteLine("");
                    GetUsers();
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }

            Console.ReadKey(); 
        }

        public static void GetUsers()
        {
            List<User> usersFromDB = SqlData.GetUsers();

            foreach (var item in usersFromDB)
            {
                Console.WriteLine("Name: " + item.name);
                Console.WriteLine("Anime: " + item.anime);
                Console.WriteLine("---------------------");
            }
        }
    }
}
