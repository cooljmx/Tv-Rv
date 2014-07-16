using System.Web.Mvc;
using Common;
using Tv_Rv.Config.Web.Infrastructure;
using Tv_Rv.Config.Web.Models;

namespace Tv_Rv.Config.Web.Controllers
{
    public class TunerConfigController : Controller
    {
        [HttpGet]
        public PartialViewResult Index()
        {
            var model = Singleton<ConfigModel>.Instance;
            return PartialView(model.Config.TunerConfig);
        }
    }
}
