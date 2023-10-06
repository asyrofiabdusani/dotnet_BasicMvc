using System.Web.Mvc;

namespace BasicMvc.Controllers
{
    public class SecondPageController : Controller
    {
        // GET: SecondPage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SecondTab()
        {
            return View("TestShared");
        }
    }
}