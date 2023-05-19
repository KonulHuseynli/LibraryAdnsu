using Microsoft.AspNetCore.Mvc;

namespace UniversityProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
