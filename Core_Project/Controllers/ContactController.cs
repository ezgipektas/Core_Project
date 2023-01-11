using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = mm.TGetList();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var values = mm.TGetByID(id);
            mm.TDelete(values);
            return RedirectToAction("Index");
        }
        public IActionResult ContactDetails(int id)
        {
            var values = mm.TGetByID(id);
            return View(values);
        }
    }
}
