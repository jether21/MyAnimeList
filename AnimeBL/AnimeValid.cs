namespace AnimeBL
{
    public class AnimeValid
    {
         AniGateway getservices = new AniGateway();

        public bool CheckIfNameExists(string name)
        {
            bool result = getservices.GetUser(name) != null;
            return result;
        }

        public bool CheckIfUserExists(string name, string anime)
        {
            bool result = getservices.GetUser(name, anime) != null;
            return result;
        }
    }
}
