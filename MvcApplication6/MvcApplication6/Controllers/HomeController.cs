using MvcApplication6.Models;
using System.Web.Mvc;

namespace MvcApplication6.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Format(FormatViewModel data)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View(data);
        }

        public ActionResult Index(string name)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormatViewModel data)
        {
            if (ModelState.IsValid)
            {
                return Content("登入成功");
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}