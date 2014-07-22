using System.Web.Mvc;
using Common;
using Tv_Rv.Config.Web.Models;

namespace Tv_Rv.Config.Web.Controllers
{
    public class TunerConfigController : Controller
    {
        [HttpGet]
        public PartialViewResult Index()
        {
            var model = Singleton<TvRvConfiguratorModel>.Instance;
            return PartialView(model.Config.TunerConfig);
        }

        [HttpPost]
        public ActionResult Index(TunerConfig model)
        {
            var data = Singleton<TvRvConfiguratorModel>.Instance;
            data.Config.TunerConfig.AssignValues(model);
            data.Save();
            return RedirectToAction("Index", "TvRvConfigurator");
        }
    }
}
