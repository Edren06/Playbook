using Microsoft.AspNetCore.Mvc;

namespace RugbyManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumController : Controller
    {
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
