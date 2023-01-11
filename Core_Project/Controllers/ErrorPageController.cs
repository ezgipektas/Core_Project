using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
