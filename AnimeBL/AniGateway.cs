
using AnimeData;
using System.Collections.Generic;

namespace AnimeBL
{
    public class AniGateway
    {
        private List<User> GetAllUsers()
        {
            UserData userData = new UserData();

            return userData.GetUsers();

        }

        public List<User> GetUsersByStatus(int userStatus)
        {
            List<User> usersByStatus = new List<User>();

            foreach (var user in GetAllUsers())
            {
                if (user.status == userStatus)
                {
                    usersByStatus.Add(user);
                }
            }

            return usersByStatus;
        }

        public User GetUser(string username, string Amine)
        {
            User foundUser = new User();

            foreach (var user in GetAllUsers())
            {
                if (user.name == username && user.Amine == Amine)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }

        public User GetUser(string username)
        {
            User foundUser = new User();

            foreach (var user in GetAllUsers())
            {
                if (user.name == username)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }
    }
}

