using Microsoft.AspNetCore.Mvc;

namespace RugbyManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : Controller
    {
        [Route("ListTeams")]
        [HttpGet]
        public IActionResult UpsertStadium(int? stadiumId)
        {
            return View();
        }

        [Route("UpsertTeam")]
        [HttpPost]
        public IActionResult UpsertTeam(ListTeamsResult team)
        {
            return View();
        }
    }
}
