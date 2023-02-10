using Microsoft.AspNetCore.Mvc;

namespace RugbyManagement.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
