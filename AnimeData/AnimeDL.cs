using AnimeModel;
namespace AnimeData
{
    public class AnimeDL
    {

        List<UserModel> dummyUser = new List<UserModel>();

        public AnimeDL()
        {
            CreateDummyData();
        }
        private void CreateDummyData()
        {
            UserModel user1 = new UserModel { Username = "Miss Monday", Password = "kissmoko" };
            UserModel user2 = new UserModel { Username = "Miss Tuesday", Password = "kissmoko2" };
            UserModel user3 = new UserModel { Username = "jether21", Password = "needkokiss123" };
            UserModel user4 = new UserModel { Username = "Miss All-Sunday", Password = "ilovegothmilf" };

            dummyUser.Add(user1);
            dummyUser.Add(user2);
            dummyUser.Add(user3);
            dummyUser.Add(user4);
        }
        public UserModel GetDummyData(string Username, string Password)
        {
            UserModel foundUser = new UserModel();

            foreach (var dummy in dummyUser)
            {
                if (Username == dummy.Username && Password == dummy.Password)
                {
                    foundUser = dummy;
                }
            }
            return foundUser;

        }

    }
}

    

