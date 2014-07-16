using System.Web.Mvc;

namespace Tv_Rv.Config.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
