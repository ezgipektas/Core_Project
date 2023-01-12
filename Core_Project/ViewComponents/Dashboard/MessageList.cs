using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Project.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        MessageManager mm = new MessageManager(new EfMessageDal());
        
        public IViewComponentResult Invoke()
        {
            var values = mm.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}
