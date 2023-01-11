using BusinessLayer.Concrete;
using Core_Project.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid && p.ConfirmPassword==p.Password)
            {
                AppUser au = new AppUser()
                {
                    Name = p.Name,
                    UserName = p.UserName,
                    Surname = p.Surname,
                    Email=p.Mail,
                    ImageUrl=p.ImageUrl
                };
                var result = await _userManager.CreateAsync(au, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }             
            }
            return View();
        }
    }
}
