using System.Collections.Generic;
using AnimeModel;

namespace AnimeData
{
    public class AnimeDL
    {
        List<AnimeAlbum> users;
        SqlData sqlData; 

        public AnimeDL()
        {
            users = new List<AnimeAlbum>();
            sqlData = new SqlData();

        }

        public List<AnimeAlbum> GetUsers()
        {
            users = sqlData.GetUsers();
            return users;
        }

        public int AddUser(AnimeAlbum user)
        {
            return sqlData.AddUser(user.name, user.anime, user.status);
        }

        public int UpdateUser(AnimeAlbum user)
        {
            return sqlData.UpdateUser(user.name, user.anime);
        }

        public int DeleteUser(AnimeAlbum user)
        {
            return sqlData.DeleteUser(user.name);
        }
    }
}
