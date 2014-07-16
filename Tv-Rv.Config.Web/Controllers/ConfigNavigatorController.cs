using System.Web.Mvc;
using Tv_Rv.Config.Web.Models;

namespace Tv_Rv.Config.Web.Controllers
{
    public class ConfigNavigatorController : Controller
    {
        [HttpGet]
        public PartialViewResult Index(TvRvConfiguratorModel model, string selectedMenuItem = null)
        {
            return PartialView(model);
        }
    }
}
