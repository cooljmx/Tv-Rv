using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace Tv_Rv.Config
{
    public enum ServerStyles
    {
        Classic,
        Java,
        WebAPI
    }

    public class TvRvConfig
    {
        [DisplayName("Адрес сервера мониторинга")]
        public string RemoteServer { get; set; }
        public ServerStyles ServerStyle { get; set; }
        [DisplayName("Идентификатор ПАК")]
        [ReadOnly(true)]
        public int IdPak { get; set; }
        public long MaxLogFileSize { get; set; }
        public TunerConfig TunerConfig { get; set; }
        public AnalyzerConfig AnalyzerConfig { get; set; }

        public TvRvConfig()
        {
            if (TunerConfig == null)
                TunerConfig = new TunerConfig();
            if (AnalyzerConfig == null)
                AnalyzerConfig = new AnalyzerConfig();

            RemoteServer = @"http://localhost:5454";
            ServerStyle = ServerStyles.Classic;
            IdPak = 0;
            MaxLogFileSize = 0;
        }

        public void SaveToFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                var serializer = new XmlSerializer(typeof(TvRvConfig));
                serializer.Serialize(stream, this);
            }
        }

        public static TvRvConfig LoadFromFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                var serializer = new XmlSerializer(typeof (TvRvConfig));
                return (TvRvConfig) serializer.Deserialize(stream);
            }
        }

        public void AssignValues(TvRvConfig source)
        {
            RemoteServer = source.RemoteServer;
            ServerStyle = source.ServerStyle;
            IdPak = source.IdPak;
            MaxLogFileSize = source.MaxLogFileSize;
        }
    }
}
