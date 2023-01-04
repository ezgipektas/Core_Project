using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Windows.Markup;

namespace Core_Project.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager pm = new PortfolioManager(new EfPortfolioDal());

        PortfolioValidator validations = new PortfolioValidator();
        
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
            ValidationResult results = validations.Validate(portfolio);
            if (results.IsValid)
            {
                pm.TAdd(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = pm.TGetByID(id);
            pm.TDelete(values);
            return RedirectToAction("Index");
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
            ValidationResult results=validations.Validate(portfolio);
            if (results.IsValid)
            {
                pm.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
       
        }


    }
}
