using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace MvcApplication6.Controllers
{
    public class ValidateController : Controller
    {
        public JsonResult CheckUserName(string 帳號)
        {
            bool isValidate = !Regex.IsMatch(帳號, "skilltree|demo|twMVC", RegexOptions.IgnoreCase);

            // Remote 驗證是使用 Get 因此要開放
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}