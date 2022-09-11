using Microsoft.AspNetCore.Mvc;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class GendersController : Controller
    {
        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetAllGenders()
        {
            return View();
        }
    }
}
