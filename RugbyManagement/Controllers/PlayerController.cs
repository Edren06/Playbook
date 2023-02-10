using Microsoft.AspNetCore.Mvc;
using RugbyManagement.Framework.Models;
using RugbyManagement.Framework.ViewModels;

namespace RugbyManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : Controller
    {
        [Route("GetPlayer")]
        [HttpGet]
        public IActionResult GetPlayer(int playerId)
        {
            try
            {
                PlayerVm vm = new PlayerVm();
                return new JsonResult(vm.GetPlayer(playerId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("GetPlayers")]
        [HttpGet]
        public IActionResult GetPlayers(int? teamId, int? stadiumId)
        {
            try
            {
                PlayerVm vm = new PlayerVm();
                return new JsonResult(vm.GetPlayerList(teamId, stadiumId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("UpsertPlayer")]
        [HttpPost]
        public IActionResult UpsertPlayer(PlayerPostModel player)
        {
            try
            {
                PlayerVm vm = new PlayerVm();
                vm.UpsertPlayer(player);

                return new JsonResult(player.PlayerId == 0 ? "Player created" : "Player Upserted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
