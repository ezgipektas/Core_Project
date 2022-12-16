using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
