using Microsoft.AspNetCore.Mvc;
using RugbyManagement.Framework.ViewModels;
using System.Numerics;

namespace RugbyManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumController : Controller
    {
        [Route("GetStadium")]
        [HttpGet]
        public IActionResult GetStadium(int stadiumId)
        {
            try
            {
                StadiumVm vm = new StadiumVm();
                return new JsonResult(vm.GetStadium(stadiumId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("ListStadiums")]
        [HttpGet]
        public IActionResult ListStadiums()
        {
            try
            {
                StadiumVm vm = new StadiumVm();
                return new JsonResult(vm.GetStadiumList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("UpsertStadium")]
        [HttpPost]
        public IActionResult UpsertStadium(GetStadiumResult stadium)
        {
            try
            {
                StadiumVm vm = new StadiumVm();
                vm.UpsertStadium(stadium);

                return new JsonResult(stadium.StadiumId == 0 ? "Stadium created" : "Stadium Upserted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
