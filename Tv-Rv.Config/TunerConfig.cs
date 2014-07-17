using System.ComponentModel;
using System.Xml.Serialization;

namespace Tv_Rv.Config
{
    public class TunerConfig
    {
        public string IntfDevice { get; set; }
        [XmlAttribute]
        public bool Enabled { get; set; }
        [DisplayName("Минимальный уровень сигнала в % (0-50%)")]
        public int MinimalSignalLevelPercent { get; set; }
        [DisplayName("Минимальный уровень восстановленного сигнала в % (0-50, не может быть меньше MinimalSignalLevelPercent)")]
        public int MinimalSignalThresholdPercent { get; set; }
        [DisplayName("Минимальная пауза между снимками видео контента в сек.")]
        public int ScreenshotPause { get; set; }
        public int ThreadPause { get; set; }
        [DisplayName("Максимальное время захвата несущей DVB в сек.")]
        public int DVBScanningTime { get; set; }

        public TunerConfig()
        {
            IntfDevice = @"TunerIntf\TunerIntf.exe";
            Enabled = true;
            MinimalSignalLevelPercent = 5;
            MinimalSignalThresholdPercent = 12;
            ScreenshotPause = 300;
            ThreadPause = 120;
            DVBScanningTime = 5;
        }

        public void AssignValues(TunerConfig source)
        {
            IntfDevice = source.IntfDevice;
            Enabled = source.Enabled;
            MinimalSignalLevelPercent = source.MinimalSignalLevelPercent;
            MinimalSignalThresholdPercent = source.MinimalSignalThresholdPercent;
            ScreenshotPause = source.ScreenshotPause;
            ThreadPause = source.ThreadPause;
        }
    }
}
