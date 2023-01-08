using System.ComponentModel.DataAnnotations;

namespace Core_Project.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kulanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı adını giriniz.")]
        public string Username { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi giriniz.")]
        public string Password { get; set; }
    }
}
