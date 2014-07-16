using System.Web.Mvc;
using Common;
using Tv_Rv.Config.Web.Infrastructure;
using Tv_Rv.Config.Web.Models;

namespace Tv_Rv.Config.Web.Controllers
{
    public class AnalyzerConfigController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var model = Singleton<ConfigModel>.Instance;
            return View(model.Config.AnalyzerConfig);
        }

        [HttpPost]
        public ActionResult Index(AnalyzerConfig data)
        {
            var model = Singleton<ConfigModel>.Instance;
            model.Config.AnalyzerConfig.AssignValues(data);
            model.Save();

            return RedirectToAction("Index", "Home");
        }
    }
}
