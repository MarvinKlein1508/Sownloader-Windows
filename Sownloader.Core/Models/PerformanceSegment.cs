namespace Sownloader.Core.Models
{
    public class PerformanceSegment
    {
        public int id { get; set; }
        public float start { get; set; }
        public float end { get; set; }
        public string type { get; set; }
        public object[] tags { get; set; }
    }
}