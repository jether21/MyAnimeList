using AnimeBL;

namespace AnimeBL
{
    public class AnimeValid
    {
        AniGateway getservices = new AniGateway();

        public bool AnimeValid(string Username)
        {
            bool result = new AniGateway();
        }

        public bool CheckIfUserNameExists(string username)
        {
            bool result = getservices.GetUser(username) != null;
            return result;
        }

        public bool CheckIfUserExists(string username, string password)
        {
            bool result = getservices.GetUser(username, password) != null;
            return result;
        }

    }
}
