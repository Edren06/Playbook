using Microsoft.AspNetCore.Mvc;

namespace RugbyManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : Controller
    {
        [Route("GetPlayer")]
        [HttpGet]
        public IActionResult GetPlayer(int? playerId)
        {
            return View();
        }

        [Route("GetPlayers")]
        [HttpGet]
        public IActionResult GetPlayers(int? teamId, int? stadiumId)
        {
            return View();
        }

        [Route("UpsertPlayer")]
        [HttpPost]
        public IActionResult UpsertPlayer(GetPlayerResult player)
        {
            return View();
        }
    }
}
