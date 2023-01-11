using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Core_Project.Controllers
{
    [Authorize(Roles = "Admin")]
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
        public IActionResult DeleteSkill(int id)
        {
           var values= sm.TGetByID(id);
            sm.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {           
            var values = sm.TGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            sm.TUpdate(skill);
            return RedirectToAction("Index");

        }
    }
}
