using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcApplication6.Models
{
    public class FormatViewModel
    {
        [EmailAddress]
        [Remote("CheckUserName", "Validate", ErrorMessage = "帳號不可包含以下字串 skilltree demo twMVC")]
        [Required(ErrorMessage = "請輸入帳號")]
        public string 帳號 { get; set; }

        [UIHint("password")]
        [StringLength(20, MinimumLength=4)]
        [Required(ErrorMessage = "請輸入密碼")]
        public string 密碼 { get; set; }

    }

}