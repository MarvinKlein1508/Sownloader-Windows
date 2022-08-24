namespace Sownloader.Core.Models
{
    public class PerformanceOwner
    {
        public int account_id { get; set; }
        public string handle { get; set; }
        public string pic_url { get; set; }
        public float price { get; set; }
        public float discount { get; set; }
        public string url { get; set; }
        public bool is_vip { get; set; }
        public bool is_verified { get; set; }
        public string verified_type { get; set; }
    }
}