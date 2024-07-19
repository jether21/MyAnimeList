using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AnimeModel;
using AnimeBL;

namespace AniAPi.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        Anilib _anilib;
         AniGateway _aniGateway;

        public UserController(Anilib anilib, AniGateway aniGateway)
        {
            _anilib = anilib;
            _aniGateway = aniGateway;
        }

        [HttpGet]
        public IEnumerable<AnimeAlbum> GetAni()
        {
            var users = _aniGateway.GetAllUsers();
            List<AnimeAlbum> animeList = new List<AnimeAlbum>();

            foreach (var user in users)
            {
                animeList.Add(new AnimeAlbum { name = user.name, anime = user.anime, status = user.status });
            }

            return animeList;
        }

        [HttpPost]
        public JsonResult AddUser(AnimeAlbum request)
        {
            var result = _anilib.CreateUser(request.name, request.anime, request.status);

            return new JsonResult(result);
        }

        [HttpPatch]
        public JsonResult UpdateUser(AnimeAlbum request)
        {
            var result = _anilib.UpdateUser(request.name, request.anime, request.status);

            return new JsonResult(result);
        }

        [HttpDelete]
        public JsonResult DeleteUser(AnimeAlbum request)
        {
            var userToDelete = new AnimeAlbum { name = request.name };

            var result = _anilib.DeleteUser(userToDelete);
            return new JsonResult(result);
        }
    }
}
