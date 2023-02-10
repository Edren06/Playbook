using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
