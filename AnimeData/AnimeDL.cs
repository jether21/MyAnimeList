using System;
using System.Collections.Generic;
using AnimeModel;

namespace AnimeData
{
    public class AnimeDL
    {
        List<User> users;

        public AnimeDL()
        {
            users = new List<User>();
            AnimeList _userFactory = new UserFactory();
            users = _userFactory.GetDummyUsers();
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void UpdateUser(User user)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].name == user.name)
                {
                    users[i].anime = user.anime;
                    users[i].profile = user.profile;
                    users[i].dateUpdated = DateTime.Now;
                }
            }
        }
    }
}
