using System.Web.Mvc;
using Common;
using Tv_Rv.Config.Web.Models;

namespace Tv_Rv.Config.Web.Controllers
{
    public class AnalyzerConfigController : Controller
    {
        [HttpGet]
        public PartialViewResult Index()
        {
            var model = Singleton<TvRvConfiguratorModel>.Instance;
            return PartialView(model.Config.AnalyzerConfig);
        }

        [HttpPost]
        public ActionResult Index(AnalyzerConfig model)
        {
            var data = Singleton<TvRvConfiguratorModel>.Instance;
            data.Config.AnalyzerConfig.AssignValues(model);
            data.Save();
            return RedirectToAction("Index", "TvRvConfigurator");
        }
    }
}
