using Microsoft.AspNetCore.Mvc;

namespace RugbyManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumController : Controller
    {
        [Route("GetStadium")]
        [HttpGet]
        public IActionResult GetStadium(int? stadiumId)
        {
            return View();
        }

        [Route("ListStadiums")]
        [HttpGet]
        public IActionResult UpsertStadium()
        {
            return View();
        }

        [Route("UpsertStadium")]
        [HttpPost]
        public IActionResult UpsertStadium(ListStadiumsResult stadium)
        {
            return View();
        }
    }
}
