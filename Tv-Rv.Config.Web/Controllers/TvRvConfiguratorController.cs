using System.Web.Mvc;
using Common;
using Tv_Rv.Config.Web.Models;

namespace Tv_Rv.Config.Web.Controllers
{
    public class TvRvConfiguratorController : Controller
    {
        [HttpGet]
        public ActionResult Index(string selectedMenuItem = null)
        {
            var model = Singleton<TvRvConfiguratorModel>.Instance;
            model.SelectedMenuItem = selectedMenuItem;
            return View(model);
        }
	}
}