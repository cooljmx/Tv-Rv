using System.Collections.Generic;

namespace Tv_Rv.Config.Web.Models
{
    public class TvRvConfiguratorModel
    {
        private readonly List<NavModel> menuItems = new List<NavModel>
        {
            new NavModel {ItemName = "Основные параметры", ControllerName = "Config", ActionName = "Index"},
            new NavModel {ItemName = "Параметры тюнера", ControllerName = "TunerConfig", ActionName = "Index"},
            new NavModel {ItemName = "Параметры анализатора", ControllerName = "AnalyzerConfig", ActionName = "Index"}
        };
        public string SelectedMenuItem { get; set; }
        public IEnumerable<NavModel> MenuItems{get { return menuItems; }}
    }
}