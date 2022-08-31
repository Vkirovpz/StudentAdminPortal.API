using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.Repositories;

namespace StudentAdminPortal.API.Controllers
{
    public class StudentsController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }
    }
}
