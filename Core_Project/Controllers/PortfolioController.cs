using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Windows.Markup;

namespace Core_Project.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager pm = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Listesi";
            var values = pm.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Proje Eklemei";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            pm.TAdd(portfolio);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = pm.TGetByID(id);
            pm.TDelete(values);
            return View("Index");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values = pm.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            pm.TUpdate(portfolio);
            return RedirectToAction("Index") ;
        }


    }
}
