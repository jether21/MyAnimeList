using AnimeData;
using AnimeModel;
using System.Collections.Generic;

namespace AnimeBL
{
    public class AniGateway
    {
        public List<AnimeAlbum> GetAllUsers()
        {
            AnimeDL AnimeData = new AnimeDL();
            return AnimeData.GetUsers();
        }


        public AnimeAlbum GetUser(string name, string anime)
        {
            foreach (var user in GetAllUsers())
            {
                if (user.name == name && user.anime == anime)
                {
                    return user;
                }
            }

            return null;
        }

        public AnimeAlbum GetUser(string name)
        {
            foreach (var user in GetAllUsers())
            {
                if (user.name == name)
                {
                    return user;
                }
            }

            return null;
        }
    }
}
