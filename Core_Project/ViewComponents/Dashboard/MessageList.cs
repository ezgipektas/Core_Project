using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        UserMessageManager umm = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = umm.GetUserMessageWithUserService();
            return View(values);
        }
    }
}
