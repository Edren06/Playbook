using Microsoft.AspNetCore.Mvc;
using RugbyManagement.Framework.Models;
using RugbyManagement.Framework.ViewModels;

namespace RugbyManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerTransferController : Controller
    {
        [Route("GetPlayerTransfers")]
        [HttpGet]
        public IActionResult GetPlayerTransfers(int? playerId, int? teamId, int? stadiumId)
        {
            try
            {
                PlayerTransferVm vm = new PlayerTransferVm();
                return new JsonResult(vm.GetTeamTransferList(playerId, teamId, stadiumId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("TransferPlayer")]
        [HttpPost]
        public IActionResult TransferPlayer(PlayerTransferPostModel transfer)
        {
            try
            {
                PlayerTransferVm vm = new PlayerTransferVm();
                vm.TransferPlayer(transfer);

                return new JsonResult("Player Transfered");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
