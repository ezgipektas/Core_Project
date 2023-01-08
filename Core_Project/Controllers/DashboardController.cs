using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "İstatistikler";
            ViewBag.v3 = "İstatistikler Sayfası";
            return View();
        }
    }
}
