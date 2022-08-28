namespace Sownloader.Core.Models
{

    public class Performance
    {
        public object? rec_id { get; set; }
        public object? poi { get; set; }
        public string key { get; set; }
        public string performance_key { get; set; }
        public object? join_link { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string? message { get; set; }
        public DateTime created_at { get; set; }
        public object? expire_at { get; set; }
        public bool seed { get; set; }
        public bool closed { get; set; }
        public string ensemble_type { get; set; }
        public int child_count { get; set; }
        public string app_uid { get; set; }
        public string arr_type { get; set; }
        public string arr_key { get; set; }
        public object song_id { get; set; }
        public int? song_length { get; set; }
        public string perf_status { get; set; }
        public object? artist_twitter { get; set; }
        public string? media_url { get; set; }
        public string? video_media_url { get; set; }
        public string? video_media_mp4_url { get; set; }
        public string cover_url { get; set; }
        public string web_url { get; set; }
        public string? song_info_url { get; set; }
        public PerformanceStats stats { get; set; }
        public string performed_by { get; set; }
        public string performed_by_url { get; set; }
        public PerformanceOwner owner { get; set; }
        public object[] other_performers { get; set; }
        public object duet { get; set; }
        public object other { get; set; }
        public bool featured { get; set; }
        public object rm { get; set; }
        public bool _private { get; set; }
        public bool lyric_video { get; set; }
        public string lyrics { get; set; }
        public PerformanceSegment[] segments { get; set; }

        public string GetMediaUrlDecoded()
        {
            return UrlParser.ProcessRecording(media_url);
        }

        public string? GetVideoMediaUrlDecoded()
        {
            if(string.IsNullOrWhiteSpace(video_media_mp4_url))
            {
                return null;
            }

            return UrlParser.ProcessRecording(video_media_mp4_url);
        }
    }
}