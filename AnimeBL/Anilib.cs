using AnimeData;
using AnimeModel;
using System.Collections.Generic;

namespace AnimeBL
{
    public class Anilib
    {
         AnimeValid _validationServices;
         AnimeDL _userData;

        public bool CreateUser(AnimeAlbum users)
        {
            bool result = false;

            if (_validationServices.CheckIfUserExists(users.name,users.anime))
            {
                result = _userData.AddUser(users) > 0;
            }
            return result;
        }

      

        public bool CreateUser(string name, string anime, string status)
        {
            bool result = false;
            AnimeAlbum users = new AnimeAlbum {name = name, anime = anime, status = status};
          

            return CreateUser(users);
        }

        public bool UpdateUser(AnimeAlbum user)
        {
            bool result = false;

            if (_validationServices.CheckIfUserExists(user.name, user.anime)) 
            {
                result = _userData.UpdateUser(user) > 0;
            }

            return result;
        }

        public bool UpdateUser(string name, string anime, string status)
        {
            AnimeAlbum user = new AnimeAlbum { anime = anime, status = status };
            return UpdateUser(user);
        }

      

        public bool DeleteUser(AnimeAlbum user)
        {
            bool result = false;

            if (_validationServices.CheckIfUserExists(user.name, user.anime))
            {
                result = _userData.DeleteUser(user) > 0;
            }

            return result;
        }
    }
}
