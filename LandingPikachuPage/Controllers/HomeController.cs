using System.Web.Mvc;

namespace LandingPikachuPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}