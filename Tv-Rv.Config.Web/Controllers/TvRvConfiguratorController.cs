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
            var model = new TvRvConfiguratorModel {SelectedMenuItem = selectedMenuItem};
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(TvRvConfig data)
        {
            var model = Singleton<ConfigModel>.Instance;
            model.Config.AssignValues(data);
            model.Save();

            return RedirectToAction("Index", "TvRvConfigurator");
        }

        [HttpPost]
        public ActionResult Index(TunerConfig data)
        {
            var model = Singleton<ConfigModel>.Instance;
            model.Config.TunerConfig.AssignValues(data);
            model.Save();

            return RedirectToAction("Index", "Home");
        }
	}
}