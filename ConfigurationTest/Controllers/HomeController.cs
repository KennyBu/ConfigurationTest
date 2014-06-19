using System.Configuration;
using System.Web.Mvc;
using ConfigurationTest.Models;

namespace ConfigurationTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var url = ConfigurationManager.AppSettings["TheUrlToHit"];
            var model = new HomeViewModel();
            model.Url = url;

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
