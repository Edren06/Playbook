using CoinJar.Framework.Classes;
using CoinJar.Framework.Interfaces;
using CoinJar.Framework.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoinJar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinJarController : Controller
    {
        [Route("GetTotalAmount")]
        [HttpGet]
        public IActionResult GetTotalAmount()
        {
            try
            {
                CoinJarVm jar = new CoinJarVm();
                return new JsonResult(jar.GetTotalAmount());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("AddCoin")]
        [HttpPost]
        public IActionResult AddCoin(Coin coin)
        {
            try
            {
                CoinJarVm jar = new CoinJarVm();
                jar.AddCoin(coin);
                return new JsonResult("Added coin");
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
                CoinJarVm jar = new CoinJarVm();
                jar.Reset();
                return new JsonResult("Reset the jar values");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
