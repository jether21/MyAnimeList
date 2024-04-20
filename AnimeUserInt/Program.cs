using AnimeBL;
using AnimeModel;

namespace AnimeUserInt
{
    internal class Program
    {
        public static void ShowHistory(AnimeAlbum anime)
        {
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
            Console.WriteLine("<33 <33 <33 <33 <33 <33 <33 <33 <33 <33");
            Console.WriteLine("PICK ME PICK ME PICK ME PICK ME PICK ME!!!");
            Console.WriteLine(anime.AnimeName);
            Console.WriteLine(anime.Title);
            Console.WriteLine(anime.Type);
            Console.WriteLine(anime.Premiered);
            Console.WriteLine(anime.Status);
            Console.WriteLine(anime.Duration);
            Console.WriteLine(anime.Episodes);
            Console.WriteLine(anime.Genre);
            Console.WriteLine(anime.Producers);
            Console.WriteLine("<33 <33 <33 <33 <33 <33 <33 <33 <33 <33");
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
        }
        static void Main(string[] args)
        {
            Anilib businessServices = new Anilib();
            List<AnimeAlbum> TopAnime = businessServices.GetAnimeAlbums();

            Console.WriteLine("Enter User:    ");
            string Username = Console.ReadLine();

            Console.WriteLine("Enter Password:  ");
            string Password = Console.ReadLine();

            AniGateway veri = new AniGateway();
            bool reult = veri.Verification(Username, Password);

            if (reult)
            {
                Console.WriteLine("This is Animesuge");
                Console.WriteLine("Please choose an Anime");
                Console.WriteLine("1. Choose an Anime");
                Console.WriteLine("2. Add anime ");

                int options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        Console.WriteLine("+++++++++++++++");
                        Console.WriteLine("Choose anime");
                        Console.WriteLine("1. Shangri-La Frontier");
                        Console.WriteLine("2. Undead Unluck");
                        Console.WriteLine("3. Onepiece");
                        Console.WriteLine("4. BARTENDER Glass of God");
                        Console.WriteLine("5. Neon Genesis Evangelion");
                        Console.WriteLine("============================");

                        int aninumber = Convert.ToInt32(Console.ReadLine());
                        switch (aninumber)
                        {
                            case 1:
                                ShowHistory(TopAnime[0]);
                                break;
                            case 2:
                                ShowHistory(TopAnime[1]);
                                break;
                            case 3:
                                ShowHistory(TopAnime[2]);
                                break;
                            case 4:
                                ShowHistory(TopAnime[3]);
                                break;
                            case 5:
                                ShowHistory(TopAnime[4]);
                                break;

                            default:
                                Console.WriteLine("Error! Please retry again");
                                break;
                        }
                        break;

                    case 2:
                        AnimeAlbum aniip = new AnimeAlbum();

                        Console.WriteLine("Enter Top Anime");
                        aniip.AnimeName = Console.ReadLine();
                        Console.WriteLine("Enter Title");
                        aniip.Title = Console.ReadLine();
                        Console.WriteLine("Enter Type");
                        aniip.Type = Console.ReadLine();
                        Console.WriteLine("Enter Premiered Anime");
                        aniip.Premiered = Console.ReadLine();
                        Console.WriteLine("Enter Anime Status");
                        aniip.Status = Console.ReadLine();
                        Console.WriteLine("Enter Anime Duration");
                        aniip.Duration = Console.ReadLine();
                        Console.WriteLine("Enter Episodes");
                        aniip.Episodes = Console.ReadLine();
                        Console.WriteLine("Enter Genre");
                        aniip.Genre = Console.ReadLine();
                        Console.WriteLine("Enter Anime Producer");
                        aniip.Producers = Console.ReadLine();

                        ShowHistory(TopAnime[0]);
                        ShowHistory(TopAnime[1]);
                        ShowHistory(TopAnime[2]);
                        ShowHistory(TopAnime[3]);
                        ShowHistory(TopAnime[4]);
                        Console.WriteLine("++++ Added Anime Here ++++");
                        ShowHistory(aniip);
                        break;

                            default:
                                Console.WriteLine("Error! Please Try Again");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Please pick again");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error user");
            }
        }
    }
}



