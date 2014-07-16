using System;
using System.IO;
using System.Web;

namespace Tv_Rv.Config.Web.Models
{
    public class ConfigModel
    {
        private readonly string configPath;
        private readonly TvRvConfig config;
        public TvRvConfig Config {get { return config; } }

        protected ConfigModel()
        {
            var rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
            if (rootWebConfig.AppSettings.Settings.Count == 0) throw new Exception("Check web.config for <appSettings> node!");
            var configPathAttr = rootWebConfig.AppSettings.Settings["configPath"];
            if (configPathAttr == null) throw new Exception("Check web.config for <appSettings>\\<configPath> node!");
            configPath = configPathAttr.Value;

            config = File.Exists(configPath) ? TvRvConfig.LoadFromFile(configPath) : new TvRvConfig();
        }

        public void Save()
        {
            config.SaveToFile(configPath);
        }
    }
}