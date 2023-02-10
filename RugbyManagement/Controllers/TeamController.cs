using Microsoft.AspNetCore.Mvc;
using RugbyManagement.Framework.ViewModels;
using System.Numerics;

namespace RugbyManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : Controller
    {
        [Route("GetTeam")]
        [HttpGet]
        public IActionResult GetTeam(int teamId)
        {
            try
            {
                TeamVm vm = new TeamVm();
                return new JsonResult(vm.GetTeam(teamId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("ListTeams")]
        [HttpGet]
        public IActionResult ListTeams(int? stadiumId)
        {
            try
            {
                TeamVm vm = new TeamVm();
                return new JsonResult(vm.GetTeamList(stadiumId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("UpsertTeam")]
        [HttpPost]
        public IActionResult UpsertTeam(GetTeamResult team)
        {
            try
            {
                TeamVm vm = new TeamVm();
                vm.UpsertTeam(team);

                return new JsonResult(team.TeamId == 0 ? "Team created" : "Player Upserted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
