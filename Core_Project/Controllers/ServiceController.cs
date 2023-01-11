using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager sm = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {          
            var values = sm.TGetList();
            return View(values);
        }
        public IActionResult DeleteService(int id)
        {
            var values = sm.TGetByID(id);
            sm.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddService()
        {           
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            sm.TAdd(service);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {           
            var values=sm.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            sm.TUpdate(service);
            return RedirectToAction("Index");
        }

    }
}
