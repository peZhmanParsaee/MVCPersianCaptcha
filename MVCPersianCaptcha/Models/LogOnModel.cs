using System.ComponentModel.DataAnnotations;

namespace MVCPersianCaptcha.Models
{
    public class LogOnModel
    {
        [Required(ErrorMessage = "لطفا نام کاربری را وارد نمائید")]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "لطفا کلمه عبور را وارد نمائید")]
        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }

        [Required(ErrorMessage = "لطفا کد امنیتی را وارد نمائید")]
        [Display(Name = "کد امنیتی (به عدد)")]
        public string CaptchaInputText { get; set; }
    }
}