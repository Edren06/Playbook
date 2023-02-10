using Microsoft.AspNetCore.Mvc;

namespace CoinJar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinJar : Controller
    {
        [Route("GetTotalAmount")]
        [HttpGet]
        public IActionResult GetTotalAmount()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("AddCoin")]
        [HttpPost]
        public IActionResult AddCoin()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("ResetCoins")]
        [HttpGet]
        public IActionResult ResetCoins()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
