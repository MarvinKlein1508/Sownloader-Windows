namespace Sownloader.Core.Models
{
    public class PerformanceStats
    {
        public int total_performers { get; set; }
        public string truncated_other_performers { get; set; }
        public int total_listens { get; set; }
        public string truncated_listens { get; set; }
        public int total_loves { get; set; }
        public string truncated_loves { get; set; }
        public int total_comments { get; set; }
        public string truncated_comments { get; set; }
        public int total_commenters { get; set; }
        public int total_gifts { get; set; }
        public string truncated_gifts { get; set; }
    }
}