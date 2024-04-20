using AnimeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeBL
{
    public class AniGateway
    {

        public bool Verification(string Username, string Password)
        {
            AnimeDL dataservice = new AnimeDL();
            var result = dataservice.GetDummyData(Username, Password);

            if (result.Username == Username && result.Password == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}