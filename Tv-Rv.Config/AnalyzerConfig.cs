using System.ComponentModel;
using System.Xml.Serialization;

namespace Tv_Rv.Config
{
    public class AnalyzerConfig
    {
        public string IntfDevice { get; set; }
        [XmlAttribute]
        [DisplayName("Задействовать анализатор спектра")]
        public bool Enabled { get; set; }
        [DisplayName("Ширина полосы при сканировании аналогового ТВ сигнала")]
        public int AnalogTvSpan { get; set; }
        [DisplayName("Ширина полосы при сканировании аналогового радио сигнала")]
        public int AnalogRadioSpan { get; set; }
        [DisplayName("Количество измерений спектра сигнала")]
        public int MeasuresCount { get; set; }
        public int InitializationPause { get; set; }
        public int ThreadPause { get; set; }

        public AnalyzerConfig()
        {
            IntfDevice = @"AnalyserIntf\AnalyserIntf.exe";
            Enabled = true;
            AnalogTvSpan = 300000;
            AnalogRadioSpan = 400000;
            MeasuresCount = 5;
            InitializationPause = 120;
            ThreadPause = 300;
        }

        public void AssignValues(AnalyzerConfig source)
        {
            IntfDevice = source.IntfDevice;
            Enabled = source.Enabled;
            AnalogTvSpan = source.AnalogTvSpan;
            AnalogRadioSpan = source.AnalogRadioSpan;
            MeasuresCount = source.MeasuresCount;
            InitializationPause = source.InitializationPause;
            ThreadPause = source.ThreadPause;
        }
    }
}
