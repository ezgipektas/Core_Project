using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    
    public class ToDoListPanel:ViewComponent
    {
        ToDoListManager tdlm = new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = tdlm.TGetList();
            return View(values);
        }
    }
}
