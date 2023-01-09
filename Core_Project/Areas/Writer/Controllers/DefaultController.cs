using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager anm = new AnnouncementManager(new EfAnnouncementDal());
        
        public IActionResult Index()
        {
            var values = anm.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            var values = anm.TGetByID(id);
            return View(values);

        }
    }
}
