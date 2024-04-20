using AnimeModel;

namespace AnimeData
{
    public class AnimeList
    {
        List<AnimeAlbum> TopAnime = new List<AnimeAlbum>();

        public AnimeList()
        {
            Anime();
        }
        public void Anime()
        {
            AnimeAlbum one = new AnimeAlbum
            {
                AnimeName = "Kusoge Hunter, Kamige ni Idoman to su",
                Title = "Shangri-La Frontier",
                Type = "TV",
                Premiered = "Fall 2023",
                Status = "Completed",
                Duration = "25 min",
                Episodes = "24 episodes",
                Genre = "Action, Adventure, Comedy, Fantasy, Sci-Fi, Shounen, Super Power",
                Producers = "Crunchyroll, Tencent Japan, Netmarble",

            };

            TopAnime.Add(one);

            AnimeAlbum two = new AnimeAlbum
            {
                AnimeName = "Andeddo Anrakku",
                Title = "Undead Unluck",
                Type = "TV",
                Premiered = "Fall 2023",
                Status = "Completed",
                Duration = "23 min",
                Episodes = "24 episodes",
                Genre = "Action, Comedy, Fantasy, Martial Arts, Sci-Fi, Shounen, Super Power, Supernatural",
                Producers = "Shueisha, Magic Capsule, Mainichi Broadcasting System, TMS Entertainment",
            };

            TopAnime.Add(two);

            AnimeAlbum three = new AnimeAlbum
            {
                AnimeName = "Wan Pisu?",
                Title = "One Piece",
                Type = "TV",
                Premiered = "Fall 1999",
                Status = "Ongoing",
                Duration = "24 min",
                Episodes = "1099 episodes",
                Genre = "Action, Adventure, Comedy, Drama, Fantasy, Shounen, Super Power",
                Producers = "Shueisha, Fuji TV, TAP",
            };

            TopAnime.Add(three);

            AnimeAlbum four = new AnimeAlbum
            {
                AnimeName = "Batenda: Kami no Gurasu",
                Title = "BARTENDER Glass of God",
                Type = "TV",
                Premiered = "Spring 2024",
                Status = "Releasing",
                Duration = "24-25 min",
                Episodes = "Ongoing",
                Genre = "Drama, Seinen, Slice of Life, Gourmet",
                Producers = "Shueisha, TOHO animation",
            };

            TopAnime.Add(four);

            AnimeAlbum five = new AnimeAlbum
            {
                AnimeName = " Hepburn: Shinseiki Evangerion",
                Title = "Neon Genesis Evangelion",
                Type = "TV",
                Premiered = "Fall 1995",
                Status = "Completed",
                Duration = "24 min",
                Episodes = "Completed",
                Genre = "Action, Drama, Mecha, Military, Mystery, Psychological, Sci-Fi, Suspense, Avant Garde",
                Producers = "Nihon Ad Systems, Kadokawa Shoten, TV Tokyo, Audio Tanaka",
            };

            TopAnime.Add(five);
        }

        public List<AnimeAlbum> GetTopAnime()
        {
            return TopAnime;
        }

    }
}