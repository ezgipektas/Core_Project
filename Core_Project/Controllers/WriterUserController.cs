using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Project.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager wum = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()
        {           
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(wum.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddUser(AppUser p)
        {
            wum.TAdd(p);
            var values=JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}
