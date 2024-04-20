using System;
using System.Collections.Generic;
using AnimeModel;

namespace AnimeData
{
    public class AnimeList
    {
        private List<User> dummyUsers = new List<User>();

        public List<User> GetDummyUsers()
        {
            if (dummyUsers.Count == 0)
            {
                dummyUsers.Add(CreateDummyUser("Admin123!", "Admin", "Admin@pup.com"));
                dummyUsers.Add(CreateDummyUser("Test123!", "Test", "Test@pup.com"));
                dummyUsers.Add(CreateDummyUser("Hello123!", "Hello", "Hello@pup.com"));
                dummyUsers.Add(CreateDummyUser("Bye123!", "Bye", "Bye@pup.com"));
            }

            return dummyUsers;
        }

        private User CreateDummyUser(string colorNum, string name, string Aniname)
        {
            User user = new User
            {
                name = name,
                colorNum = colorNum,
                profile = new Username { Aniname = Aniname, Username = name },
                dateUpdated = DateTime.Now,
                dateVerified = DateTime.Now.AddDays(1),
                status = 1
            };

            return user;
        }
    }
}
