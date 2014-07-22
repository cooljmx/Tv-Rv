using System.Web.Mvc;
using Common;
using Tv_Rv.Config.Web.Models;

namespace Tv_Rv.Config.Web.Controllers
{
    public class ConfigController : Controller
    {
        [HttpGet]
        public PartialViewResult Index()
        {
            var model = Singleton<TvRvConfiguratorModel>.Instance;
            return PartialView(model.Config);
        }

        [HttpPost]
        public ActionResult Index(TvRvConfig model)
        {
            var data = Singleton<TvRvConfiguratorModel>.Instance;
            data.Config.AssignValues(model);
            data.Save();
            return RedirectToAction("Index", "TvRvConfigurator");
        }
    }
}
