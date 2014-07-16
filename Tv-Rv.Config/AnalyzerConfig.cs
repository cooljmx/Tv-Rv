namespace Tv_Rv.Config
{
    public class AnalyzerConfig
    {
        public string IdDevice { get; set; }
        public string IntfDevice { get; set; }
        public int AnalogTvSpan { get; set; }
        public int AnalogRadioSpan { get; set; }
        public int MeasuresCount { get; set; }
        public int InitializationPause { get; set; }
        public int ThreadPause { get; set; }

        public void AssignValues(AnalyzerConfig source)
        {
            IdDevice = source.IdDevice;
            IntfDevice = source.IntfDevice;
            AnalogTvSpan = source.AnalogTvSpan;
            AnalogRadioSpan = source.AnalogRadioSpan;
            MeasuresCount = source.MeasuresCount;
            InitializationPause = source.InitializationPause;
            ThreadPause = source.ThreadPause;
        }
    }
}
