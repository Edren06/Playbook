using Microsoft.AspNetCore.Mvc;

namespace RugbyManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : Controller
    {
        [Route("GetTeam")]
        [HttpGet]
        public IActionResult GetTeam(int? teamId)
        {
            return View();
        }

        [Route("ListTeams")]
        [HttpGet]
        public IActionResult ListTeams(int? stadiumId)
        {
            return View();
        }

        [Route("UpsertTeam")]
        [HttpPost]
        public IActionResult UpsertTeam(GetTeamResult team)
        {
            return View();
        }
    }
}
