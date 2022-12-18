using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Core_Project.Controllers
{
    public class SkillController : Controller
    {
        SkillManager sm = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values=sm.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            sm.TAdd(skill);
            return RedirectToAction("Index");
        }
    }
}
