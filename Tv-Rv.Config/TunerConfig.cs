namespace Tv_Rv.Config
{
    public class TunerConfig
    {
        public string IdDevice { get; set; }
        public string IntfDevice { get; set; }
        public int MinimalSignalLevelPercent { get; set; }
        public int MinimalSignalThresholdPercent { get; set; }
        public int ScreenshotPause { get; set; }
        public int ThreadPause { get; set; }

        public void AssignValues(TunerConfig source)
        {
            IdDevice = source.IdDevice;
            IntfDevice = source.IntfDevice;
            MinimalSignalLevelPercent = source.MinimalSignalLevelPercent;
            MinimalSignalThresholdPercent = source.MinimalSignalThresholdPercent;
            ScreenshotPause = source.ScreenshotPause;
            ThreadPause = source.ThreadPause;
        }
    }
}
