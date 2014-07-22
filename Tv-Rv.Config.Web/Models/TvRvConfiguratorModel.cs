using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace Tv_Rv.Config.Web.Models
{
    public class TvRvConfiguratorModel
    {
        private readonly string configPath;
        private readonly TvRvConfig config;
        protected TvRvConfiguratorModel()
        {
            var rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
            if (rootWebConfig.AppSettings.Settings.Count == 0) throw new Exception("Check web.config for <appSettings> node!");
            var configPathAttr = rootWebConfig.AppSettings.Settings["configPath"];
            if (configPathAttr == null) throw new Exception("Check web.config for <appSettings>\\<configPath> node!");
            configPath = configPathAttr.Value;

            config = File.Exists(configPath) ? TvRvConfig.LoadFromFile(configPath) : new TvRvConfig();
        }

        private readonly List<NavModel> menuItems = new List<NavModel>
        {
            new NavModel {ItemName = "Основные параметры", ControllerName = "Config", ActionName = "Index"},
            new NavModel {ItemName = "Параметры тюнера", ControllerName = "TunerConfig", ActionName = "Index"},
            new NavModel {ItemName = "Параметры анализатора", ControllerName = "AnalyzerConfig", ActionName = "Index"}
        };
        public string SelectedMenuItem { get; set; }
        public IEnumerable<NavModel> MenuItems{get { return menuItems; }}
        public TvRvConfig Config { get { return config; } }

        public void Save()
        {
            config.SaveToFile(configPath);
        }
    }
}