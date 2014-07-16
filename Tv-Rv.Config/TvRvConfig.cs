using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace Tv_Rv.Config
{
    public class TvRvConfig
    {
        [DisplayName("Адрес удаленного сервера")]
        public string RemoteHost { get; set; }
        public bool OldStyleServer { get; set; }
        public int IdPak { get; set; }
        public long MaxLogFileLength { get; set; }
        public TunerConfig TunerConfig { get; set; }
        public AnalyzerConfig AnalyzerConfig { get; set; }

        public TvRvConfig()
        {
            if (TunerConfig == null)
                TunerConfig = new TunerConfig();
            if (AnalyzerConfig == null)
                AnalyzerConfig = new AnalyzerConfig();
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
            RemoteHost = source.RemoteHost;
            OldStyleServer = source.OldStyleServer;
            IdPak = source.IdPak;
            MaxLogFileLength = source.MaxLogFileLength;
        }
    }
}
