using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager abm = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var value = abm.TGetList();
            return View(value);
        }
    }
}
