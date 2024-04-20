using AnimeData;
using AnimeModel;
using System.Security.Cryptography.X509Certificates;

namespace AnimeBL
{
    public class Anilib
    {
        public List<AnimeAlbum> Vaporeon = new List<AnimeAlbum>();
        public List<AnimeAlbum> GetAnimeAlbums()
        {
            AnimeList dataServices = new AnimeList();
            return dataServices.GetTopAnime();
        }
        public void AddAnime(AnimeAlbum anime)
        {
            Vaporeon.Add(anime);
        }

        
    }
}